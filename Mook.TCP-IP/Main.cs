using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mook.TCP_IP
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
        /// 监听客户端连接
        /// </summary>
        private TcpListener tcpListener;

        /// <summary>
        /// 负责和客户端通信的套接字
        /// </summary>
        private Socket socketProxy;

        /// <summary>
        /// 获取连接服务端的客户端IP
        /// </summary>
        private string clientIp;

        /// <summary>
        /// 服务是否启动
        /// </summary>
        private bool started = false;

        /// <summary>
        /// 获取本机IP
        /// </summary>
        public static string GetIp { get; } = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(p => p.AddressFamily.ToString() == "InterNetwork")?.ToString();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            TxtServerIP.Text = GetIp;
        }

        private void BtnStartServer_Click(object sender, EventArgs e)
        {
            ip = TxtServerIP.Text.Trim();
            if (string.IsNullOrWhiteSpace(ip))
            {
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
            if (BtnStartServer.Text == "启动服务")
            {
                try
                {
                    IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
                    tcpListener = new TcpListener(ipep);
                    tcpListener.Start();
                    PicState.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("Mook.TCP_IP.Res.green.png"));                    
                    ShowMessage("服务启动成功！");
                    BtnStartServer.Text = "停止服务";
                    started = true;
                    TxtServerIP.Enabled = false;
                    TxtPort.Enabled = false;
                    Task.Factory.StartNew(() => ListenerClient(), cts.Token);
                    ShowMessage("开始监听客户端传来的信息...");
                }
                catch (Exception ex)
                {
                    ShowMessage("服务启动失败！" + ex.Message);
                }
            }
            else
            {
                BtnStartServer.Text = "启动服务";
                PicState.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("Mook.TCP_IP.Res.red.png"));
                TxtServerIP.Enabled = true;
                TxtPort.Enabled = true;
                started = false;
                cts.Cancel();
                tcpListener.Stop();
                tcpListener = null;
                if (socketProxy != null)
                    socketProxy.Close();
                ShowMessage("服务停止成功！");
            }
        }

        /// <summary>
        /// 监听客户端发来的请求
        /// </summary>
        private void ListenerClient()
        {
            while (started)
            {
                if (tcpListener.Pending())
                {
                    socketProxy = tcpListener.AcceptSocket();
                    socketProxy.Send(Encoding.Default.GetBytes("服务器连接成功！"));
                    ShowMessage("客户端连接成功！");
                    Task.Factory.StartNew(() => ReceiveClientMessages());
                }
            }
        }

        /// <summary>
        /// 接收来自客户端的信息 
        /// </summary>
        private void ReceiveClientMessages()
        {
            while (started)
            {
                try
                {
                    if (!socketProxy.Connected) break;
                    byte[] buffer = new byte[1024 * 1024];
                    int length = socketProxy.Receive(buffer);
                    clientIp = ((IPEndPoint)socketProxy.RemoteEndPoint).Address.ToString() + " ";
                    string receiveMessage = Encoding.Default.GetString(buffer, 0, length);
                    if (ChkHex.Checked)
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        foreach (byte bt in buffer)
                        {
                            stringBuilder.Append(bt.ToString("X2") + " ");
                        }
                        receiveMessage = stringBuilder.ToString();
                        //float.TryParse(receiveMessage, out float result);
                        //receiveMessage = ((int)result).ToString("X2");
                    }
                    ShowMessage(receiveMessage);
                    //处理数据


                    //返回结果
                    socketProxy.Send(Encoding.Default.GetBytes("OK"));
                }
                catch
                {
                    ShowMessage("客户端已断开连接！");
                    break;
                }
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
            if (!ChkClientIp.Checked)
                clientIp = "";
            string message = time + clientIp + info + wordWrap;
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

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                NotifyIcon.Visible = true;
                ShowInTaskbar = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (started)
            {
                if (MessageBox.Show("正在执行数据接收，确定关闭吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Dispose();
                    Close();
                }
                else
                    e.Cancel = true;
            }
            else
            {
                Dispose();
                Close();
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                Activate();
                ShowInTaskbar = true;
                NotifyIcon.Visible = false;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (started)
            {
                if (MessageBox.Show("正在执行数据接收，确定关闭吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Dispose();
                    Close();
                }
            }
            else
            {
                Dispose();
                Close();
            }
        }
    }
}
