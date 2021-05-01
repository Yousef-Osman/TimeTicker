using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace TimeTicker
{
    public partial class Form1 : Form
    {
        private Timer timer1 { get; set; }
        private DateTime start { get; set; }
        private DateTime end { get; set; }
        private bool mouseDown { get; set; }
        private Point lastLocation { get; set; }
        private bool isPercentage { get; set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isPercentage = true;
            start = new DateTime(2021, 4, 28, 15, 0, 0);
            end = new DateTime(2021, 5, 3, 22, 0, 0);

            RunTimer(sender, e);
        }

        private void RunTimer(object sender, EventArgs e)
        {
            updateProgressBar();
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateProgressBar();
        }

        private void updateProgressBar()
        {
            var now = DateTime.Now;
            var remainig = Convert.ToDouble((end - now).Ticks);
            var full = Convert.ToDouble((end - start).Ticks);

            var progress = remainig / full;

            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;

            if (progress > 0)
            {
                circularProgressBar1.Value = (int)(Math.Round(progress, 2) * 100);
                circularProgressBar1.Text = updateProgressBarText(progress);
                circularProgressBar1.Update();
            }
            else
            {
                timer1.Stop();
                circularProgressBar1.Value = 0;
                circularProgressBar1.Text = $"Done";
            }
        }

        private string updateProgressBarText(Double progress)
        {
            if (isPercentage == true)
                return $"{(Math.Round(progress, 4) * 100).ToString()} %";
            else
            {
                var diffrence = end.Subtract(DateTime.Now);
                var result = String.Format("{0}:{1}:{2}", diffrence.Hours, diffrence.Minutes, diffrence.Seconds);

                if (diffrence.Days > 0)
                {
                    Console.WriteLine(diffrence.Days);

                    var years = end.Year - DateTime.Now.Year;
                    var months = end.Month - DateTime.Now.Month;
                    var days = end.Day - DateTime.Now.Day;

                    if (years <= 0 && months <= 0)
                        result += string.Format($"\n{days} Days");
                    else
                        result += string.Format("\n{0}Y,{1}M,{2}D", years, months, days);
                }

                return $"{result}";
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value * 0.1;
        }

        private void opacityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Value = (int)(this.Opacity * 10);
            PanelHome.Visible = false;
            PanelTimer.Visible = false;
            PanelTicker.Visible = false;
            PanelOpacity.Visible = true;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            PanelOpacity.Visible = false;
            PanelTimer.Visible = false;
            PanelTicker.Visible = false;
            PanelHome.Visible = true;
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Clicks == 1)
                mouseDown = true;

            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DTBStart.Value = DateTime.Now;
            DTBEnd.Value = DateTime.Now;

            PanelHome.Visible = false;
            PanelOpacity.Visible = false;
            PanelTicker.Visible = false;
            PanelTimer.Visible = true;
        }

        private void TimerOkBtn_Click(object sender, EventArgs e)
        {
            start = DTBStart.Value;
            end = DTBEnd.Value;

            if (start < end && end > DateTime.Now)
            {
                RunTimer(sender, e);
            }
            else
            {
                timer1.Stop();
                circularProgressBar1.Value = 0;
                circularProgressBar1.Text = $"Invalid";
            }

            PanelTimer.Visible = false;
            PanelOpacity.Visible = false;
            PanelTicker.Visible = false;
            PanelHome.Visible = true;
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            isPercentage = (isPercentage == true) ? false : true;
            timer1.Stop();
            RunTimer(sender, e);
        }

        private void tickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Intervals));

            PanelTimer.Visible = false;
            PanelOpacity.Visible = false;
            PanelHome.Visible = false;
            PanelTicker.Visible = true;
        }

        private void BtnOkTicker_Click(object sender, EventArgs e)
        {
            NumTick.Value = (NumTick.Value <= 0) ? 1 : NumTick.Value;

            if ((Intervals)comboBox1.SelectedItem == Intervals.Seconds)
                timer1.Interval = ((int)NumTick.Value) * 1000;
            else if ((Intervals)comboBox1.SelectedItem == Intervals.Minutes)
                timer1.Interval = ((int)NumTick.Value) * 60 * 1000;
            else if ((Intervals)comboBox1.SelectedItem == Intervals.Hours)
                timer1.Interval = ((int)NumTick.Value) * 60 * 60 * 1000;

            PanelTimer.Visible = false;
            PanelOpacity.Visible = false;
            PanelTicker.Visible = false;
            PanelHome.Visible = true;
        }

        private void BtnSaveTime_Click(object sender, EventArgs e)
        {

        }
    }

    public enum Intervals
    {
        Seconds = 0,
        Minutes = 1,
        Hours = 2
    }
}
