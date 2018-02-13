namespace TCPServer01
{
    partial class frmTcpServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTcpServer));
            this.tbConsoleOutput = new System.Windows.Forms.TextBox();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lblIpPort = new System.Windows.Forms.Label();
            this.btnStartListening = new System.Windows.Forms.Button();
            this.tbPayload = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblPayload = new System.Windows.Forms.Label();
            this.lblClients = new System.Windows.Forms.Label();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.cbIpSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbConsoleOutput
            // 
            this.tbConsoleOutput.Location = new System.Drawing.Point(13, 13);
            this.tbConsoleOutput.Multiline = true;
            this.tbConsoleOutput.Name = "tbConsoleOutput";
            this.tbConsoleOutput.Size = new System.Drawing.Size(761, 396);
            this.tbConsoleOutput.TabIndex = 0;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Enabled = false;
            this.tbIPAddress.Location = new System.Drawing.Point(64, 415);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(119, 20);
            this.tbIPAddress.TabIndex = 1;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(189, 415);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(67, 20);
            this.tbPort.TabIndex = 2;
            // 
            // lblIpPort
            // 
            this.lblIpPort.AutoSize = true;
            this.lblIpPort.Location = new System.Drawing.Point(17, 419);
            this.lblIpPort.Name = "lblIpPort";
            this.lblIpPort.Size = new System.Drawing.Size(44, 13);
            this.lblIpPort.TabIndex = 3;
            this.lblIpPort.Text = "IP/Port:";
            // 
            // btnStartListening
            // 
            this.btnStartListening.Location = new System.Drawing.Point(147, 443);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(109, 23);
            this.btnStartListening.TabIndex = 4;
            this.btnStartListening.Text = "Start &Listening";
            this.btnStartListening.UseVisualStyleBackColor = true;
            this.btnStartListening.Click += new System.EventHandler(this.btnStartListening_Click);
            // 
            // tbPayload
            // 
            this.tbPayload.Location = new System.Drawing.Point(543, 416);
            this.tbPayload.Name = "tbPayload";
            this.tbPayload.Size = new System.Drawing.Size(231, 20);
            this.tbPayload.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(543, 442);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(230, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblPayload
            // 
            this.lblPayload.AutoSize = true;
            this.lblPayload.Location = new System.Drawing.Point(493, 420);
            this.lblPayload.Name = "lblPayload";
            this.lblPayload.Size = new System.Drawing.Size(48, 13);
            this.lblPayload.TabIndex = 7;
            this.lblPayload.Text = "Payload:";
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Location = new System.Drawing.Point(781, 19);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(41, 13);
            this.lblClients.TabIndex = 9;
            this.lblClients.Text = "Clients:";
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(781, 36);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(213, 355);
            this.lbClients.TabIndex = 10;
            // 
            // cbIpSelect
            // 
            this.cbIpSelect.FormattingEnabled = true;
            this.cbIpSelect.Location = new System.Drawing.Point(64, 444);
            this.cbIpSelect.Name = "cbIpSelect";
            this.cbIpSelect.Size = new System.Drawing.Size(77, 21);
            this.cbIpSelect.TabIndex = 11;
            this.cbIpSelect.SelectedIndexChanged += new System.EventHandler(this.cbIpSelect_SelectedIndexChanged);
            // 
            // frmTcpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 478);
            this.Controls.Add(this.cbIpSelect);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.lblPayload);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbPayload);
            this.Controls.Add(this.btnStartListening);
            this.Controls.Add(this.lblIpPort);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.tbConsoleOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTcpServer";
            this.Text = "TCP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConsoleOutput;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lblIpPort;
        private System.Windows.Forms.Button btnStartListening;
        private System.Windows.Forms.TextBox tbPayload;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblPayload;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.ComboBox cbIpSelect;
    }
}

