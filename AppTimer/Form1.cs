using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AppTimer
{
    public partial class AppTimer : MetroForm
    {
        DateTime a;

        public AppTimer()
        {
            InitializeComponent();
            this.myDate.Value = DateTime.Now;
        }

        private void AppTimer_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.BalloonTipText = "App Timer is running in background.\nDouble Click the icon to show the app";
                notifyIcon.BalloonTipTitle = "App Timer";
                notifyIcon.ShowBalloonTip(1000);
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var timeofStart = DateTime.Now.ToString("hh:mm:ss tt");
            var timeofEnd = myDate.Value.ToString("hh:mm tt");
            a = Convert.ToDateTime(timeofStart);
            DateTime b = Convert.ToDateTime(timeofEnd);
            var x = b.Subtract(a).TotalSeconds;
            labelRemaining.Text = x.ToString() + " Seconds";
            if (x < 0)
            {
                timer.Stop();
                labelRemaining.Text = "Timer has stopped.";
            }
            else
            {
                if (DateTime.Now.ToShortTimeString().Equals(myDate.Value.ToShortTimeString()))
                {
                    var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);
                }
            }
        }
    }
}
