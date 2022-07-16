using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestExam_ServerWinForm_
{
    internal class MyClient
    {
        public string Name { get; set; }

        private MyServer _server;

        public string Id { get; private set; }
        protected TcpClient tcpClient;
        internal NetworkStream networkStream { get; set; }



        public MyClient(TcpClient tcpClient, MyServer myServer)
        {
            Id = Guid.NewGuid().ToString();
            _server = myServer;
            this.tcpClient = tcpClient;
            _server.AddConnection(this);

        }

        public void Work()
        {
            try
            {
                networkStream = tcpClient.GetStream();
                this.Name = GetMsgOrFile();
                string msg = $"{this.Name} in chat!";
                _server.msg = msg + Environment.NewLine;
               



                while (true)
                {
                    try
                    {
                        msg = GetMsgOrFile() + " - ";
                        msg = $"{Name} : {msg} {DateTime.Now.ToShortTimeString()}";
                        _server.msg = msg + Environment.NewLine;
                    }
                    catch (Exception ex)
                    {
                        msg = $"{this.Name} OUT OF chat!";                   
                        _server.msg = msg + Environment.NewLine;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _server.DeleteConnetion(this.Id);
                Close();
            }
        }

        public string GetMsgOrFile()
        {
            byte[] data = new byte[256];
            StringBuilder builder = new StringBuilder();
            int byteCount = 0;
            do
            {
                byteCount = networkStream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, byteCount));
            } while (networkStream.DataAvailable);
            if (builder.ToString().Equals("/@/file"))
            {
                builder.Clear();
              /*  do
                {
                    byteCount = tcpClient.Client.Receive(data);
                    builder.Append(Encoding.Unicode.GetString(data, 0, byteCount));
                } while (tcpClient.Client.Available > 0);*/

                using (NetworkStream networkStream = new NetworkStream(tcpClient.Client))
                {
                    using (FileStream fileStream = File.Open("History file\\History.txt", FileMode.OpenOrCreate))
                    {
                        networkStream.CopyTo(fileStream);
                    }
                }
            }
            else
            {
                //Console.WriteLine($"Client msg:\t{builder.ToString()}");
                _server.msg = builder.ToString() + Environment.NewLine;
              //  File.AppendAllText("MsgHistory.txt", builder.ToString() + "\n");
            }
            return builder.ToString();
        }
        public object GetLocalIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No IP address in system");
        }
        public void Close()
        {
            tcpClient.Close();
            networkStream.Close();
        }
    }
}
