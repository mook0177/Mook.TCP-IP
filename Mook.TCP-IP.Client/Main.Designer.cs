namespace Mook.TCP_IP.Client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BtnSend = new System.Windows.Forms.Button();
            this.ChkWordWrap = new System.Windows.Forms.CheckBox();
            this.ChkTime = new System.Windows.Forms.CheckBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtServerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.BtnConnectServer = new System.Windows.Forms.Button();
            this.PicState = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RtxMessage = new System.Windows.Forms.RichTextBox();
            this.RtxSendMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicState)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSend.Location = new System.Drawing.Point(613, 353);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(139, 76);
            this.BtnSend.TabIndex = 12;
            this.BtnSend.Text = "发送";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // ChkWordWrap
            // 
            this.ChkWordWrap.AutoSize = true;
            this.ChkWordWrap.Checked = true;
            this.ChkWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkWordWrap.Location = new System.Drawing.Point(104, 33);
            this.ChkWordWrap.Name = "ChkWordWrap";
            this.ChkWordWrap.Size = new System.Drawing.Size(82, 18);
            this.ChkWordWrap.TabIndex = 1;
            this.ChkWordWrap.Text = "换行显示";
            this.ChkWordWrap.UseVisualStyleBackColor = true;
            // 
            // ChkTime
            // 
            this.ChkTime.AutoSize = true;
            this.ChkTime.Checked = true;
            this.ChkTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkTime.Location = new System.Drawing.Point(7, 33);
            this.ChkTime.Name = "ChkTime";
            this.ChkTime.Size = new System.Drawing.Size(82, 18);
            this.ChkTime.TabIndex = 2;
            this.ChkTime.Text = "时间显示";
            this.ChkTime.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(7, 94);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(179, 32);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "清空接收区";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClear);
            this.groupBox2.Controls.Add(this.ChkTime);
            this.groupBox2.Controls.Add(this.ChkWordWrap);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(13, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 149);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP地址";
            // 
            // TxtServerIP
            // 
            this.TxtServerIP.Location = new System.Drawing.Point(7, 35);
            this.TxtServerIP.Name = "TxtServerIP";
            this.TxtServerIP.Size = new System.Drawing.Size(179, 23);
            this.TxtServerIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "服务器端口号";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(7, 82);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(179, 23);
            this.TxtPort.TabIndex = 3;
            // 
            // BtnConnectServer
            // 
            this.BtnConnectServer.Location = new System.Drawing.Point(7, 118);
            this.BtnConnectServer.Name = "BtnConnectServer";
            this.BtnConnectServer.Size = new System.Drawing.Size(127, 32);
            this.BtnConnectServer.TabIndex = 4;
            this.BtnConnectServer.Text = "连接服务器";
            this.BtnConnectServer.UseVisualStyleBackColor = true;
            this.BtnConnectServer.Click += new System.EventHandler(this.BtnConnectServer_Click);
            // 
            // PicState
            // 
            this.PicState.Image = ((System.Drawing.Image)(resources.GetObject("PicState.Image")));
            this.PicState.Location = new System.Drawing.Point(146, 118);
            this.PicState.Name = "PicState";
            this.PicState.Size = new System.Drawing.Size(40, 32);
            this.PicState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicState.TabIndex = 5;
            this.PicState.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PicState);
            this.groupBox1.Controls.Add(this.BtnConnectServer);
            this.groupBox1.Controls.Add(this.TxtPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtServerIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // RtxMessage
            // 
            this.RtxMessage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RtxMessage.HideSelection = false;
            this.RtxMessage.Location = new System.Drawing.Point(222, 17);
            this.RtxMessage.Name = "RtxMessage";
            this.RtxMessage.Size = new System.Drawing.Size(540, 330);
            this.RtxMessage.TabIndex = 9;
            this.RtxMessage.Text = "";
            this.RtxMessage.TextChanged += new System.EventHandler(this.RtxMessage_TextChanged);
            // 
            // RtxSendMessage
            // 
            this.RtxSendMessage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RtxSendMessage.Location = new System.Drawing.Point(222, 354);
            this.RtxSendMessage.Name = "RtxSendMessage";
            this.RtxSendMessage.Size = new System.Drawing.Size(372, 76);
            this.RtxSendMessage.TabIndex = 11;
            this.RtxSendMessage.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(774, 441);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.RtxSendMessage);
            this.Controls.Add(this.RtxMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP协议客户端";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicState)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.CheckBox ChkWordWrap;
        private System.Windows.Forms.CheckBox ChkTime;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Button BtnConnectServer;
        private System.Windows.Forms.PictureBox PicState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RtxMessage;
        private System.Windows.Forms.RichTextBox RtxSendMessage;
    }
}