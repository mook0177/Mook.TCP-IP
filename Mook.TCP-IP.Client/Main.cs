using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mook.TCP_IP.Client
{
    public partial class Main : Form
    {
        /// <summary>
        /// 服务器IP
        /// </summary>
        private string ip;

        /// <summary>
        /// 服务器监听端口
        /// </summary>
        private int port;

        /// <summary>
        /// 取消线程
        /// </summary>
        readonly CancellationTokenSource cts = new CancellationTokenSource();

        /// <summary>
        /// 客户端的套接字
        /// </summary>
        private Socket socketClient;

        /// <summary>
        /// 是否连接服务器
        /// </summary>
        private bool connected = false;

        public Main()
        {
            InitializeComponent();
        }

        private void BtnConnectServer_Click(object sender, EventArgs e)
        {
            ip = TxtServerIP.Text.Trim();
            if (string.IsNullOrWhiteSpace(ip))
            {
                TxtServerIP.Focus();
                MessageBox.Show("请输入服务器IP地址", "提示");
                return;
            }
            int.TryParse(TxtPort.Text.Trim(), out port);
            if (port == 0)
            {
                TxtPort.Focus();
                MessageBox.Show("端口号异常", "提示");
                return;
            }
            if (BtnConnectServer.Text == "连接服务器")
            {
                try
                {
                    socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
                    socketClient.Connect(ipep);
                    connected = true;
                    Task.Factory.StartNew(() => ReceiveMessage(), cts.Token);
                    PicState.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("Mook.TCP_IP.Client.Res.green.png"));
                    BtnConnectServer.Text = "断开服务器";
                    TxtServerIP.Enabled = false;
                    TxtPort.Enabled = false;
                }
                catch (Exception ex)
                {
                    ShowMessage("连接服务器失败！" + ex.Message);
                }
            }
            else
            {
                BtnConnectServer.Text = "连接服务器";
                PicState.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("Mook.TCP_IP.Client.Res.red.png"));
                TxtServerIP.Enabled = true;
                TxtPort.Enabled = true;
                connected = false;
                cts.Cancel();
                socketClient.Close();
                ShowMessage("服务器断开成功！");
            }
        }

        /// <summary>
        /// 接收服务端发来的信息
        /// </summary>
        private void ReceiveMessage()
        {
            while (connected)
            {
                if (!socketClient.Connected) break;
                byte[] buffer = new byte[1024 * 1024];
                int length = socketClient.Receive(buffer);
                string receiveMessage = Encoding.Default.GetString(buffer, 0, length);
                ShowMessage(receiveMessage);
            }
        }

        /// <summary>
        /// 发送信息到服务端
        /// </summary>
        /// <param name="message">发送内容</param>
        private void ClientSendMessage(string message)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(message);
                socketClient.Send(buffer);
                ShowMessage(message);
            }
            catch
            {
                ShowMessage("服务器已中断连接,无法发送消息！");
            }
        }

        /// <summary>
        /// 信息接收设置
        /// </summary>
        /// <param name="info"></param>
        private void ShowMessage(string info)
        {
            string wordWrap = "";
            if (ChkWordWrap.Checked)
                wordWrap = "\n";
            string time = "";
            if (ChkTime.Checked)
                time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " ";
            string message = time + info + wordWrap;
            SetText(this, RtxMessage, message);
            SaveLog(message);
        }

        delegate void SetTextCallback(Form frm, RichTextBox rtx, string text);

        public static void SetText(Form frm, RichTextBox rtx, string text)
        {
            if (rtx.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                frm.Invoke(d, new object[] { frm, rtx, text });
            }
            else
                rtx.AppendText(text);
        }

        /// <summary>
        /// 保存日志
        /// </summary>
        /// <param name="message"></param>
        public void SaveLog(string message)
        {
            string dirPath = Path.Combine(Application.StartupPath, "Log");
            string filePath = Path.Combine(dirPath, DateTime.Now.ToString("yyyyMMdd") + ".txt");
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            if (!File.Exists(filePath))
                File.Create(filePath).Close();
            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(message + "\r\n");
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            ClientSendMessage(RtxSendMessage.Text.Trim());
            RtxSendMessage.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            RtxMessage.Clear();
        }

        private void RtxMessage_TextChanged(object sender, EventArgs e)
        {
            if (RtxMessage.Lines.Length > 2000)
            {
                int start = RtxMessage.GetFirstCharIndexFromLine(0);
                int end = RtxMessage.GetFirstCharIndexFromLine(500);
                RtxMessage.Select(start, end);
                RtxMessage.SelectedText = "";
                RtxMessage.Focus();
                RtxMessage.Select(RtxMessage.TextLength, 0);
            }
        }
    }
}
