
namespace TimeTicker
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.PanelOpacity = new System.Windows.Forms.Panel();
            this.OkBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelTimer = new System.Windows.Forms.Panel();
            this.DTBEnd = new System.Windows.Forms.DateTimePicker();
            this.BtnSaveTime = new System.Windows.Forms.Button();
            this.BtnTimerOk = new System.Windows.Forms.Button();
            this.DTBStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelTicker = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NumTick = new System.Windows.Forms.NumericUpDown();
            this.BtnOkTicker = new System.Windows.Forms.Button();
            this.LabelTicker = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.PanelHome.SuspendLayout();
            this.PanelOpacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.PanelTimer.SuspendLayout();
            this.PanelTicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTick)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.opacityToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.tickerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 100);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // opacityToolStripMenuItem
            // 
            this.opacityToolStripMenuItem.Name = "opacityToolStripMenuItem";
            this.opacityToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.opacityToolStripMenuItem.Text = "Opacity";
            this.opacityToolStripMenuItem.Click += new System.EventHandler(this.opacityToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // tickerToolStripMenuItem
            // 
            this.tickerToolStripMenuItem.Name = "tickerToolStripMenuItem";
            this.tickerToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.tickerToolStripMenuItem.Text = "Ticker";
            this.tickerToolStripMenuItem.Click += new System.EventHandler(this.tickerToolStripMenuItem_Click);
            // 
            // PanelHome
            // 
            this.PanelHome.Controls.Add(this.label1);
            this.PanelHome.Controls.Add(this.circularProgressBar1);
            this.PanelHome.Location = new System.Drawing.Point(0, 0);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(192, 244);
            this.PanelHome.TabIndex = 3;
            this.PanelHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.PanelHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.PanelHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remainig";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Aqua;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Black;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(19, 67);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.DarkSlateGray;
            this.circularProgressBar1.OuterMargin = -8;
            this.circularProgressBar1.OuterWidth = 8;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Aqua;
            this.circularProgressBar1.ProgressWidth = 7;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 2;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.Value = 68;
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // PanelOpacity
            // 
            this.PanelOpacity.Controls.Add(this.OkBtn);
            this.PanelOpacity.Controls.Add(this.trackBar1);
            this.PanelOpacity.Controls.Add(this.label2);
            this.PanelOpacity.Location = new System.Drawing.Point(0, 0);
            this.PanelOpacity.Name = "PanelOpacity";
            this.PanelOpacity.Size = new System.Drawing.Size(192, 244);
            this.PanelOpacity.TabIndex = 4;
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.Black;
            this.OkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkBtn.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.OkBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.OkBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.ForeColor = System.Drawing.Color.Aqua;
            this.OkBtn.Location = new System.Drawing.Point(59, 173);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 35);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(21, 97);
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(151, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 8;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(50, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opacity";
            // 
            // PanelTimer
            // 
            this.PanelTimer.Controls.Add(this.DTBEnd);
            this.PanelTimer.Controls.Add(this.BtnSaveTime);
            this.PanelTimer.Controls.Add(this.BtnTimerOk);
            this.PanelTimer.Controls.Add(this.DTBStart);
            this.PanelTimer.Controls.Add(this.label5);
            this.PanelTimer.Controls.Add(this.label4);
            this.PanelTimer.Controls.Add(this.label3);
            this.PanelTimer.Location = new System.Drawing.Point(0, 0);
            this.PanelTimer.Name = "PanelTimer";
            this.PanelTimer.Size = new System.Drawing.Size(192, 244);
            this.PanelTimer.TabIndex = 4;
            // 
            // DTBEnd
            // 
            this.DTBEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DTBEnd.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DTBEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DTBEnd.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.DTBEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTBEnd.Location = new System.Drawing.Point(21, 147);
            this.DTBEnd.Margin = new System.Windows.Forms.Padding(0);
            this.DTBEnd.Name = "DTBEnd";
            this.DTBEnd.Size = new System.Drawing.Size(151, 23);
            this.DTBEnd.TabIndex = 7;
            // 
            // BtnSaveTime
            // 
            this.BtnSaveTime.BackColor = System.Drawing.Color.Black;
            this.BtnSaveTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveTime.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnSaveTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.BtnSaveTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BtnSaveTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveTime.ForeColor = System.Drawing.Color.Aqua;
            this.BtnSaveTime.Location = new System.Drawing.Point(110, 188);
            this.BtnSaveTime.Name = "BtnSaveTime";
            this.BtnSaveTime.Size = new System.Drawing.Size(62, 35);
            this.BtnSaveTime.TabIndex = 6;
            this.BtnSaveTime.Text = "Save";
            this.BtnSaveTime.UseVisualStyleBackColor = false;
            this.BtnSaveTime.Click += new System.EventHandler(this.BtnSaveTime_Click);
            // 
            // BtnTimerOk
            // 
            this.BtnTimerOk.BackColor = System.Drawing.Color.Black;
            this.BtnTimerOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTimerOk.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnTimerOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.BtnTimerOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BtnTimerOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimerOk.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTimerOk.ForeColor = System.Drawing.Color.Aqua;
            this.BtnTimerOk.Location = new System.Drawing.Point(21, 188);
            this.BtnTimerOk.Name = "BtnTimerOk";
            this.BtnTimerOk.Size = new System.Drawing.Size(62, 35);
            this.BtnTimerOk.TabIndex = 6;
            this.BtnTimerOk.Text = "Ok";
            this.BtnTimerOk.UseVisualStyleBackColor = false;
            this.BtnTimerOk.Click += new System.EventHandler(this.TimerOkBtn_Click);
            // 
            // DTBStart
            // 
            this.DTBStart.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DTBStart.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DTBStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DTBStart.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.DTBStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTBStart.Location = new System.Drawing.Point(21, 89);
            this.DTBStart.Margin = new System.Windows.Forms.Padding(0);
            this.DTBStart.Name = "DTBStart";
            this.DTBStart.Size = new System.Drawing.Size(151, 23);
            this.DTBStart.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(76, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(72, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(37, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Set Timer";
            // 
            // PanelTicker
            // 
            this.PanelTicker.Controls.Add(this.comboBox1);
            this.PanelTicker.Controls.Add(this.NumTick);
            this.PanelTicker.Controls.Add(this.BtnOkTicker);
            this.PanelTicker.Controls.Add(this.LabelTicker);
            this.PanelTicker.Location = new System.Drawing.Point(0, 0);
            this.PanelTicker.Name = "PanelTicker";
            this.PanelTicker.Size = new System.Drawing.Size(192, 244);
            this.PanelTicker.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // NumTick
            // 
            this.NumTick.Location = new System.Drawing.Point(65, 76);
            this.NumTick.Name = "NumTick";
            this.NumTick.Size = new System.Drawing.Size(63, 24);
            this.NumTick.TabIndex = 8;
            // 
            // BtnOkTicker
            // 
            this.BtnOkTicker.BackColor = System.Drawing.Color.Black;
            this.BtnOkTicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOkTicker.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnOkTicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.BtnOkTicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BtnOkTicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOkTicker.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOkTicker.ForeColor = System.Drawing.Color.Aqua;
            this.BtnOkTicker.Location = new System.Drawing.Point(59, 173);
            this.BtnOkTicker.Name = "BtnOkTicker";
            this.BtnOkTicker.Size = new System.Drawing.Size(75, 35);
            this.BtnOkTicker.TabIndex = 6;
            this.BtnOkTicker.Text = "Ok";
            this.BtnOkTicker.UseVisualStyleBackColor = false;
            this.BtnOkTicker.Click += new System.EventHandler(this.BtnOkTicker_Click);
            // 
            // LabelTicker
            // 
            this.LabelTicker.AutoSize = true;
            this.LabelTicker.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTicker.ForeColor = System.Drawing.Color.Aqua;
            this.LabelTicker.Location = new System.Drawing.Point(58, 22);
            this.LabelTicker.Name = "LabelTicker";
            this.LabelTicker.Size = new System.Drawing.Size(77, 29);
            this.LabelTicker.TabIndex = 3;
            this.LabelTicker.Text = "Ticker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(192, 244);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.PanelHome);
            this.Controls.Add(this.PanelOpacity);
            this.Controls.Add(this.PanelTimer);
            this.Controls.Add(this.PanelTicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.PanelOpacity.ResumeLayout(false);
            this.PanelOpacity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.PanelTimer.ResumeLayout(false);
            this.PanelTimer.PerformLayout();
            this.PanelTicker.ResumeLayout(false);
            this.PanelTicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel PanelHome;
        private System.Windows.Forms.Panel PanelOpacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem opacityToolStripMenuItem;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.Panel PanelTimer;
        private System.Windows.Forms.DateTimePicker DTBStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnTimerOk;
        private System.Windows.Forms.DateTimePicker DTBEnd;
        private System.Windows.Forms.ToolStripMenuItem tickerToolStripMenuItem;
        private System.Windows.Forms.Panel PanelTicker;
        private System.Windows.Forms.Label LabelTicker;
        private System.Windows.Forms.Button BtnOkTicker;
        private System.Windows.Forms.Button BtnSaveTime;
        private System.Windows.Forms.NumericUpDown NumTick;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

