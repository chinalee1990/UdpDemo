namespace UdpServerDemo
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_AddClient = new System.Windows.Forms.Button();
            this.listBox_Client = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_AddClient
            // 
            this.button_AddClient.Location = new System.Drawing.Point(193, 187);
            this.button_AddClient.Name = "button_AddClient";
            this.button_AddClient.Size = new System.Drawing.Size(75, 23);
            this.button_AddClient.TabIndex = 0;
            this.button_AddClient.Text = "添加客户端";
            this.button_AddClient.UseVisualStyleBackColor = true;
            this.button_AddClient.Click += new System.EventHandler(this.button_AddClient_Click);
            // 
            // listBox_Client
            // 
            this.listBox_Client.FormattingEnabled = true;
            this.listBox_Client.ItemHeight = 12;
            this.listBox_Client.Location = new System.Drawing.Point(12, 12);
            this.listBox_Client.Name = "listBox_Client";
            this.listBox_Client.Size = new System.Drawing.Size(256, 160);
            this.listBox_Client.TabIndex = 1;
            this.listBox_Client.DoubleClick += new System.EventHandler(this.listBox_Client_DoubleClick);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 241);
            this.Controls.Add(this.listBox_Client);
            this.Controls.Add(this.button_AddClient);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddClient;
        private System.Windows.Forms.ListBox listBox_Client;
    }
}