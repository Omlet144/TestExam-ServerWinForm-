namespace TestExam_ServerWinForm_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_listbox = new System.Windows.Forms.Button();
            this.label_clients = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_start_server = new System.Windows.Forms.Button();
            this.btn_stop_server = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_listbox
            // 
            this.button_listbox.Location = new System.Drawing.Point(258, 286);
            this.button_listbox.Name = "button_listbox";
            this.button_listbox.Size = new System.Drawing.Size(135, 26);
            this.button_listbox.TabIndex = 14;
            this.button_listbox.Text = "Refresh";
            this.button_listbox.UseVisualStyleBackColor = true;
            this.button_listbox.Click += new System.EventHandler(this.button_listbox_Click);
            // 
            // label_clients
            // 
            this.label_clients.AutoSize = true;
            this.label_clients.Location = new System.Drawing.Point(355, 78);
            this.label_clients.Name = "label_clients";
            this.label_clients.Size = new System.Drawing.Size(38, 13);
            this.label_clients.TabIndex = 13;
            this.label_clients.Text = "Clients";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(258, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 186);
            this.listBox1.TabIndex = 11;
            // 
            // btn_start_server
            // 
            this.btn_start_server.Location = new System.Drawing.Point(73, 15);
            this.btn_start_server.Name = "btn_start_server";
            this.btn_start_server.Size = new System.Drawing.Size(124, 60);
            this.btn_start_server.TabIndex = 10;
            this.btn_start_server.Text = "Start server";
            this.btn_start_server.UseVisualStyleBackColor = true;
            this.btn_start_server.Click += new System.EventHandler(this.btn_start_server_Click);
            // 
            // btn_stop_server
            // 
            this.btn_stop_server.Location = new System.Drawing.Point(306, 15);
            this.btn_stop_server.Name = "btn_stop_server";
            this.btn_stop_server.Size = new System.Drawing.Size(124, 60);
            this.btn_stop_server.TabIndex = 9;
            this.btn_stop_server.Text = "Stop server";
            this.btn_stop_server.UseVisualStyleBackColor = true;
            this.btn_stop_server.Click += new System.EventHandler(this.btn_stop_server_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "History";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(12, 172);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(243, 108);
            this.listBox2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clean history";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_listbox);
            this.Controls.Add(this.label_clients);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_start_server);
            this.Controls.Add(this.btn_stop_server);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_listbox;
        private System.Windows.Forms.Label label_clients;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_start_server;
        private System.Windows.Forms.Button btn_stop_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
    }
}

