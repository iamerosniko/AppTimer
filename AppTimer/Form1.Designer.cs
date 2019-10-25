using System.Windows.Forms;

namespace AppTimer
{
    partial class AppTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppTimer));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.myDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.labelRemaining = new MetroFramework.Controls.MetroLabel();
            this.btnSet = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Hidden in Background";
            this.notifyIcon.BalloonTipTitle = "App Timer";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "NotifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // myDate
            // 
            this.myDate.CustomFormat = "HH:mm tt";
            this.myDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.myDate.Location = new System.Drawing.Point(161, 37);
            this.myDate.Name = "myDate";
            this.myDate.ShowUpDown = true;
            this.myDate.Size = new System.Drawing.Size(99, 20);
            this.myDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Time";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Remaining :";
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Location = new System.Drawing.Point(146, 131);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(114, 19);
            this.labelRemaining.TabIndex = 4;
            this.labelRemaining.Text = "Timer not running";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(14, 73);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(246, 46);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 163);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(273, 163);
            this.MinimumSize = new System.Drawing.Size(273, 163);
            this.Name = "AppTimer";
            this.Resizable = false;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Resize += new System.EventHandler(this.AppTimer_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.DateTimePicker myDate;
        private MetroFramework.Controls.MetroLabel label1;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel labelRemaining;
        private MetroFramework.Controls.MetroButton btnSet;
    }
}

