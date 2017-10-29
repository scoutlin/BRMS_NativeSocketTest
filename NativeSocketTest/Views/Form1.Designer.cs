namespace TestSocket
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Server = new System.Windows.Forms.Button();
            this.button_Client = new System.Windows.Forms.Button();
            this.button_Server2 = new System.Windows.Forms.Button();
            this.button_ClientClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ServerClose = new System.Windows.Forms.Button();
            this.button_ServerSend = new System.Windows.Forms.Button();
            this.button_ClientSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Server
            // 
            this.button_Server.Location = new System.Drawing.Point(12, 0);
            this.button_Server.Name = "button_Server";
            this.button_Server.Size = new System.Drawing.Size(105, 87);
            this.button_Server.TabIndex = 0;
            this.button_Server.Text = "Server";
            this.button_Server.UseVisualStyleBackColor = true;
            this.button_Server.Click += new System.EventHandler(this.button_Server_Click);
            // 
            // button_Client
            // 
            this.button_Client.Location = new System.Drawing.Point(170, 0);
            this.button_Client.Name = "button_Client";
            this.button_Client.Size = new System.Drawing.Size(126, 87);
            this.button_Client.TabIndex = 1;
            this.button_Client.Text = "Client";
            this.button_Client.UseVisualStyleBackColor = true;
            this.button_Client.Click += new System.EventHandler(this.button_Client_Click);
            // 
            // button_Server2
            // 
            this.button_Server2.Location = new System.Drawing.Point(12, 93);
            this.button_Server2.Name = "button_Server2";
            this.button_Server2.Size = new System.Drawing.Size(130, 72);
            this.button_Server2.TabIndex = 2;
            this.button_Server2.Text = "Server Receive";
            this.button_Server2.UseVisualStyleBackColor = true;
            this.button_Server2.Click += new System.EventHandler(this.button_Server2_Click);
            // 
            // button_ClientClose
            // 
            this.button_ClientClose.Location = new System.Drawing.Point(170, 271);
            this.button_ClientClose.Name = "button_ClientClose";
            this.button_ClientClose.Size = new System.Drawing.Size(126, 72);
            this.button_ClientClose.TabIndex = 3;
            this.button_ClientClose.Text = "ClientClose";
            this.button_ClientClose.UseVisualStyleBackColor = true;
            this.button_ClientClose.Click += new System.EventHandler(this.button_ClientClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Client Receive";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ServerClose
            // 
            this.button_ServerClose.Location = new System.Drawing.Point(12, 271);
            this.button_ServerClose.Name = "button_ServerClose";
            this.button_ServerClose.Size = new System.Drawing.Size(130, 72);
            this.button_ServerClose.TabIndex = 5;
            this.button_ServerClose.Text = "Server Close";
            this.button_ServerClose.UseVisualStyleBackColor = true;
            this.button_ServerClose.Click += new System.EventHandler(this.button_ServerClose_Click);
            // 
            // button_ServerSend
            // 
            this.button_ServerSend.Location = new System.Drawing.Point(12, 171);
            this.button_ServerSend.Name = "button_ServerSend";
            this.button_ServerSend.Size = new System.Drawing.Size(130, 66);
            this.button_ServerSend.TabIndex = 6;
            this.button_ServerSend.Text = "ServerSend";
            this.button_ServerSend.UseVisualStyleBackColor = true;
            this.button_ServerSend.Click += new System.EventHandler(this.button_ServerSend_Click);
            // 
            // button_ClientSend
            // 
            this.button_ClientSend.Location = new System.Drawing.Point(170, 171);
            this.button_ClientSend.Name = "button_ClientSend";
            this.button_ClientSend.Size = new System.Drawing.Size(126, 66);
            this.button_ClientSend.TabIndex = 7;
            this.button_ClientSend.Text = "ClientSend";
            this.button_ClientSend.UseVisualStyleBackColor = true;
            this.button_ClientSend.Click += new System.EventHandler(this.button_ClientSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 405);
            this.Controls.Add(this.button_ClientSend);
            this.Controls.Add(this.button_ServerSend);
            this.Controls.Add(this.button_ServerClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_ClientClose);
            this.Controls.Add(this.button_Server2);
            this.Controls.Add(this.button_Client);
            this.Controls.Add(this.button_Server);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Server;
        private System.Windows.Forms.Button button_Client;
        private System.Windows.Forms.Button button_Server2;
        private System.Windows.Forms.Button button_ClientClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ServerClose;
        private System.Windows.Forms.Button button_ServerSend;
        private System.Windows.Forms.Button button_ClientSend;
    }
}

