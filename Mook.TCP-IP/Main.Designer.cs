namespace Mook.TCP_IP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnClear = new System.Windows.Forms.Button();
            this.ChkClientIp = new System.Windows.Forms.CheckBox();
            this.ChkTime = new System.Windows.Forms.CheckBox();
            this.ChkWordWrap = new System.Windows.Forms.CheckBox();
            this.ChkHex = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PicState = new System.Windows.Forms.PictureBox();
            this.BtnStartServer = new System.Windows.Forms.Button();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtServerIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RtxMessage = new System.Windows.Forms.RichTextBox();
            this.NotifyMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicState)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.NotifyMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "退出";
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(101, 26);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(7, 115);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(180, 32);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "清空接收区";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ChkClientIp
            // 
            this.ChkClientIp.AutoSize = true;
            this.ChkClientIp.Location = new System.Drawing.Point(104, 66);
            this.ChkClientIp.Name = "ChkClientIp";
            this.ChkClientIp.Size = new System.Drawing.Size(68, 18);
            this.ChkClientIp.TabIndex = 3;
            this.ChkClientIp.Text = "显示IP";
            this.ChkClientIp.UseVisualStyleBackColor = true;
            // 
            // ChkTime
            // 
            this.ChkTime.AutoSize = true;
            this.ChkTime.Checked = true;
            this.ChkTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkTime.Location = new System.Drawing.Point(7, 66);
            this.ChkTime.Name = "ChkTime";
            this.ChkTime.Size = new System.Drawing.Size(82, 18);
            this.ChkTime.TabIndex = 2;
            this.ChkTime.Text = "时间显示";
            this.ChkTime.UseVisualStyleBackColor = true;
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
            // ChkHex
            // 
            this.ChkHex.AutoSize = true;
            this.ChkHex.Location = new System.Drawing.Point(7, 33);
            this.ChkHex.Name = "ChkHex";
            this.ChkHex.Size = new System.Drawing.Size(75, 18);
            this.ChkHex.TabIndex = 0;
            this.ChkHex.Text = "HEX显示";
            this.ChkHex.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClear);
            this.groupBox2.Controls.Add(this.ChkClientIp);
            this.groupBox2.Controls.Add(this.ChkTime);
            this.groupBox2.Controls.Add(this.ChkWordWrap);
            this.groupBox2.Controls.Add(this.ChkHex);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(13, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 166);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区设置";
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
            // BtnStartServer
            // 
            this.BtnStartServer.Location = new System.Drawing.Point(7, 118);
            this.BtnStartServer.Name = "BtnStartServer";
            this.BtnStartServer.Size = new System.Drawing.Size(127, 32);
            this.BtnStartServer.TabIndex = 4;
            this.BtnStartServer.Text = "启动服务";
            this.BtnStartServer.UseVisualStyleBackColor = true;
            this.BtnStartServer.Click += new System.EventHandler(this.BtnStartServer_Click);
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(7, 82);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(179, 23);
            this.TxtPort.TabIndex = 0;
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
            // TxtServerIP
            // 
            this.TxtServerIP.Location = new System.Drawing.Point(7, 35);
            this.TxtServerIP.Name = "TxtServerIP";
            this.TxtServerIP.Size = new System.Drawing.Size(179, 23);
            this.TxtServerIP.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PicState);
            this.groupBox1.Controls.Add(this.BtnStartServer);
            this.groupBox1.Controls.Add(this.TxtPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtServerIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            // RtxMessage
            // 
            this.RtxMessage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RtxMessage.HideSelection = false;
            this.RtxMessage.Location = new System.Drawing.Point(222, 15);
            this.RtxMessage.Name = "RtxMessage";
            this.RtxMessage.Size = new System.Drawing.Size(540, 417);
            this.RtxMessage.TabIndex = 4;
            this.RtxMessage.Text = "";
            this.RtxMessage.TextChanged += new System.EventHandler(this.RtxMessage_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(774, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RtxMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP协议服务端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.NotifyMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicState)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.CheckBox ChkClientIp;
        private System.Windows.Forms.CheckBox ChkTime;
        private System.Windows.Forms.CheckBox ChkWordWrap;
        private System.Windows.Forms.CheckBox ChkHex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PicState;
        private System.Windows.Forms.Button BtnStartServer;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtServerIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtxMessage;
    }
}