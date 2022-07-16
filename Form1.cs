using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExam_ServerWinForm_
{
    public partial class Form1 : Form
    {
        MyServer server = new MyServer();


        private void RefreshClient()
        {
            try { 
            listBox1.Items.Clear();
            foreach (var item in server.clients)
            {
                listBox1.Items.Add(item.Name + " - ID: " + item.Id + "; IP: " + item.GetLocalIpAddress());
            }
            // textBox2.Clear();
            // string box = textBox2.Text;
            //if (box.Contains(server.msg) == true)
            //if(server.msg == textBox2.Text)
            //{
            //    server.msg = "";
            //}
            //else
            //{
            //    textBox2.Text += server.msg /*+ Environment.NewLine*/;
            //}
            //textBox2.Text = server.msg;
             listBox2.Items.Add(server.msg);
            }
            catch (Exception ex){ ex.Message.ToString(); }


        }
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Enabled = false;
            //this.textBox2.Enabled = false;
        }

        private void btn_start_server_Click(object sender, EventArgs e)
        {
            btn_stop_server.Enabled = true;
            btn_start_server.Enabled = false;
            try
            {
                Thread thread = new Thread(new ThreadStart(server.Listen));
                thread.Start();
                this.BackColor = Color.Green;
                textBox1.Text = "START SERVER";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                server.CloseServer();
            }
        }

        private void btn_stop_server_Click(object sender, EventArgs e)
        {
            server.CloseServer();
            this.BackColor = Color.Red;
            textBox1.Text = "STOP SERVER";
            btn_stop_server.Enabled = false;
            btn_start_server.Enabled = true;
        }

        private void button_listbox_Click(object sender, EventArgs e)
        {
            RefreshClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_stop_server.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
