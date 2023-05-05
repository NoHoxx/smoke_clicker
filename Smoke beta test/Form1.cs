using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smoke_beta_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration

        private void LeftTB_Scroll(object sender, ScrollEventArgs e)
        {
            leftCPSCount.Text = $"{LeftTB.Value} CPS";
        }

        private void LeftCliker_Tick(object sender, EventArgs e)
        {
            LeftCliker.Interval = 1000 / Leftjittercps;
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
            {
                if (LeftCheckB_on.Checked)
                if (MouseButtons == MouseButtons.Left)
                {
                        SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                        Task.Delay(20).Wait();
                        SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                }
            }
        }

        private void RightTB_Scroll(object sender, ScrollEventArgs e)
        {
            RightCPSCount.Text = $"{RightTB.Value} CPS";
        }

        private void RightClicker_Tick(object sender, EventArgs e)
        {
            RightClicker.Interval = 1000 / RightTB.Value;
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
            {
                if (RightCheckB_on.Checked)
                if (MouseButtons == MouseButtons.Right)
                {
                        SendMessage(GetForegroundWindow(), 0x204, 0, 0);
                        Task.Delay(20).Wait();
                        SendMessage(GetForegroundWindow(), 0x203, 0, 0);
                }
            }
        }

        int Leftjittercps;
        private void Leftjitter_Tick(object sender, EventArgs e)
        {
            Leftjittercps = new Random().Next(LeftTB.Value - 4, LeftTB.Value * 2 - 5);
        }
    }
}
