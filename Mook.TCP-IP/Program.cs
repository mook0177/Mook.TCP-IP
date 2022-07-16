using System;
using System.Threading;
using System.Windows.Forms;

namespace Mook.TCP_IP
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mutex = new Mutex(false, "Mook.TCP-IP");
            var running = !mutex.WaitOne(0, false);
            if (!running)
                Application.Run(new Main());
            else
                MessageBox.Show("程序已打开", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
