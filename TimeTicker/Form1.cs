using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace TimeTicker
{
    public partial class Form1 : Form
    {
        private Timer timer1;
        private bool mouseDown;
        private Point lastLocation;

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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000 * 600;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var start = new DateTime(2021, 4, 28, 15, 0, 0);
            var end = new DateTime(2021, 5, 3, 22, 0, 0);

            updateProgressBar(start, end);
        }

        private void updateProgressBar(DateTime start, DateTime end)
        {
            var now = DateTime.Now;
            var remainig = Convert.ToDouble((end - now).Ticks);
            var full = Convert.ToDouble((end - start).Ticks);

            var progress = remainig / full;

            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;

            circularProgressBar1.Value = (int)(Math.Round(progress, 2) * 100);
            circularProgressBar1.Text = $"{(Math.Round(progress, 4) * 100).ToString()} %";
            circularProgressBar1.Update();
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
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
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
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void TimerOkBtn_Click(object sender, EventArgs e)
        {
            var start = DTBStart.Value;
            var end = DTBEnd.Value;

            updateProgressBar(start, end);

            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }
    }
}
