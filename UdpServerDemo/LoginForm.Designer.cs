namespace UdpServerDemo
{
    partial class LoginForm
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
            this.button_LoginClient = new System.Windows.Forms.Button();
            this.button_LoginServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_LoginClient
            // 
            this.button_LoginClient.Location = new System.Drawing.Point(74, 37);
            this.button_LoginClient.Name = "button_LoginClient";
            this.button_LoginClient.Size = new System.Drawing.Size(75, 23);
            this.button_LoginClient.TabIndex = 0;
            this.button_LoginClient.Text = "客户端";
            this.button_LoginClient.UseVisualStyleBackColor = true;
            this.button_LoginClient.Click += new System.EventHandler(this.button_Client_Click);
            // 
            // button_LoginServer
            // 
            this.button_LoginServer.Location = new System.Drawing.Point(74, 87);
            this.button_LoginServer.Name = "button_LoginServer";
            this.button_LoginServer.Size = new System.Drawing.Size(75, 23);
            this.button_LoginServer.TabIndex = 0;
            this.button_LoginServer.Text = "服务端";
            this.button_LoginServer.UseVisualStyleBackColor = true;
            this.button_LoginServer.Click += new System.EventHandler(this.button_Server_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 139);
            this.Controls.Add(this.button_LoginServer);
            this.Controls.Add(this.button_LoginClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_LoginClient;
        private System.Windows.Forms.Button button_LoginServer;
    }
}