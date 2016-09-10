namespace UdpServerDemo
{
    partial class FormComm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_RemoteIP = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTimerSend = new System.Windows.Forms.Button();
            this.textBox_RemotePort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_LocalPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_RecvCount = new System.Windows.Forms.Label();
            this.label_SendCount = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ClearSend = new System.Windows.Forms.Button();
            this.richTextBox_Recv = new System.Windows.Forms.RichTextBox();
            this.textBox_Send = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_RemoteIP
            // 
            this.textBox_RemoteIP.Location = new System.Drawing.Point(43, 35);
            this.textBox_RemoteIP.Name = "textBox_RemoteIP";
            this.textBox_RemoteIP.Size = new System.Drawing.Size(94, 21);
            this.textBox_RemoteIP.TabIndex = 1;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(176, 181);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(8, 181);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(129, 23);
            this.button_Set.TabIndex = 2;
            this.button_Set.Text = "设置";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "RemoteIp:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTimerSend
            // 
            this.btnTimerSend.Location = new System.Drawing.Point(277, 181);
            this.btnTimerSend.Name = "btnTimerSend";
            this.btnTimerSend.Size = new System.Drawing.Size(75, 23);
            this.btnTimerSend.TabIndex = 2;
            this.btnTimerSend.Text = "定时发送";
            this.btnTimerSend.UseVisualStyleBackColor = true;
            this.btnTimerSend.Click += new System.EventHandler(this.btnTimerSend_Click);
            // 
            // textBox_RemotePort
            // 
            this.textBox_RemotePort.Location = new System.Drawing.Point(43, 67);
            this.textBox_RemotePort.Name = "textBox_RemotePort";
            this.textBox_RemotePort.Size = new System.Drawing.Size(94, 21);
            this.textBox_RemotePort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port:";
            // 
            // textBox_LocalPort
            // 
            this.textBox_LocalPort.Location = new System.Drawing.Point(45, 141);
            this.textBox_LocalPort.Name = "textBox_LocalPort";
            this.textBox_LocalPort.Size = new System.Drawing.Size(92, 21);
            this.textBox_LocalPort.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Local:";
            // 
            // label_RecvCount
            // 
            this.label_RecvCount.AutoSize = true;
            this.label_RecvCount.Location = new System.Drawing.Point(369, 186);
            this.label_RecvCount.Name = "label_RecvCount";
            this.label_RecvCount.Size = new System.Drawing.Size(77, 12);
            this.label_RecvCount.TabIndex = 3;
            this.label_RecvCount.Text = "RecvCount = ";
            // 
            // label_SendCount
            // 
            this.label_SendCount.AutoSize = true;
            this.label_SendCount.Location = new System.Drawing.Point(370, 208);
            this.label_SendCount.Name = "label_SendCount";
            this.label_SendCount.Size = new System.Drawing.Size(77, 12);
            this.label_SendCount.TabIndex = 3;
            this.label_SendCount.Text = "SendCount = ";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(495, 181);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(44, 23);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "清零";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Send);
            this.groupBox1.Controls.Add(this.button_ClearSend);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_RemoteIP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_RemotePort);
            this.groupBox1.Controls.Add(this.label_SendCount);
            this.groupBox1.Controls.Add(this.textBox_LocalPort);
            this.groupBox1.Controls.Add(this.label_RecvCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_Set);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Send);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnTimerSend);
            this.groupBox1.Controls.Add(this.button_Clear);
            this.groupBox1.Location = new System.Drawing.Point(14, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 233);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button_ClearSend
            // 
            this.button_ClearSend.Location = new System.Drawing.Point(176, 211);
            this.button_ClearSend.Name = "button_ClearSend";
            this.button_ClearSend.Size = new System.Drawing.Size(140, 23);
            this.button_ClearSend.TabIndex = 4;
            this.button_ClearSend.Text = "清空发送缓冲区";
            this.button_ClearSend.UseVisualStyleBackColor = true;
            this.button_ClearSend.Click += new System.EventHandler(this.button_ClearSend_Click);
            // 
            // richTextBox_Recv
            // 
            this.richTextBox_Recv.Location = new System.Drawing.Point(13, 3);
            this.richTextBox_Recv.Name = "richTextBox_Recv";
            this.richTextBox_Recv.ReadOnly = true;
            this.richTextBox_Recv.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_Recv.Size = new System.Drawing.Size(532, 422);
            this.richTextBox_Recv.TabIndex = 7;
            this.richTextBox_Recv.Text = "";
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(176, 21);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBox_Send.Size = new System.Drawing.Size(355, 141);
            this.textBox_Send.TabIndex = 5;
            this.textBox_Send.Text = "";
            // 
            // FormComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 707);
            this.Controls.Add(this.richTextBox_Recv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormComm";
            this.Text = "Udp_Local";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_RemoteIP;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTimerSend;
        private System.Windows.Forms.TextBox textBox_RemotePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_LocalPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_RecvCount;
        private System.Windows.Forms.Label label_SendCount;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_Recv;
        private System.Windows.Forms.Button button_ClearSend;
        private System.Windows.Forms.RichTextBox textBox_Send;
    }
}

