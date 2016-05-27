using System.Drawing;

namespace RuneScape_VoS_Notifier
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcoVOS = new System.Windows.Forms.NotifyIcon(this.components);
            this.cntxtNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picDisplayOne = new System.Windows.Forms.PictureBox();
            this.picDisplayTwo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimeUntilNextVOS = new System.Windows.Forms.Label();
            this.past5VoSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStripPreviousVoSOne = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStripPreviousVoSTwo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStripPreviousVoSThree = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStripPreviousVoSFour = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStripPreviousVoSFive = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxtNotifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcoVOS
            // 
            this.notifyIcoVOS.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcoVOS.BalloonTipText = "Checking for current Voice of Seren...";
            this.notifyIcoVOS.BalloonTipTitle = "Voice of Seren";
            this.notifyIcoVOS.ContextMenuStrip = this.cntxtNotifyIcon;
            this.notifyIcoVOS.Icon = global::RuneScape_VoS_Notifier.Properties.Resources.Prifddinas_lodestone_icon;
            this.notifyIcoVOS.Text = "Voice of Seren";
            this.notifyIcoVOS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcoVOS_MouseDoubleClick);
            // 
            // cntxtNotifyIcon
            // 
            this.cntxtNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.past5VoSToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cntxtNotifyIcon.Name = "cntxtNotifyIcon";
            this.cntxtNotifyIcon.Size = new System.Drawing.Size(153, 92);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.maximizeToolStripMenuItem.Text = "M&aximize";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // picDisplayOne
            // 
            this.picDisplayOne.BackColor = System.Drawing.Color.Transparent;
            this.picDisplayOne.Image = global::RuneScape_VoS_Notifier.Properties.Resources.Badge_cancel;
            this.picDisplayOne.Location = new System.Drawing.Point(50, 59);
            this.picDisplayOne.Name = "picDisplayOne";
            this.picDisplayOne.Size = new System.Drawing.Size(81, 81);
            this.picDisplayOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisplayOne.TabIndex = 0;
            this.picDisplayOne.TabStop = false;
            // 
            // picDisplayTwo
            // 
            this.picDisplayTwo.BackColor = System.Drawing.Color.Transparent;
            this.picDisplayTwo.Image = global::RuneScape_VoS_Notifier.Properties.Resources.Badge_cancel;
            this.picDisplayTwo.Location = new System.Drawing.Point(160, 59);
            this.picDisplayTwo.Name = "picDisplayTwo";
            this.picDisplayTwo.Size = new System.Drawing.Size(81, 81);
            this.picDisplayTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisplayTwo.TabIndex = 1;
            this.picDisplayTwo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Voice of Seren";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(39, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Until Next VoS:";
            // 
            // lblTimeUntilNextVOS
            // 
            this.lblTimeUntilNextVOS.AutoSize = true;
            this.lblTimeUntilNextVOS.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeUntilNextVOS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeUntilNextVOS.ForeColor = System.Drawing.Color.White;
            this.lblTimeUntilNextVOS.Location = new System.Drawing.Point(178, 151);
            this.lblTimeUntilNextVOS.Name = "lblTimeUntilNextVOS";
            this.lblTimeUntilNextVOS.Size = new System.Drawing.Size(66, 14);
            this.lblTimeUntilNextVOS.TabIndex = 4;
            this.lblTimeUntilNextVOS.Text = "checking...";
            // 
            // past5VoSToolStripMenuItem
            // 
            this.past5VoSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStripPreviousVoSOne,
            this.tlStripPreviousVoSTwo,
            this.tlStripPreviousVoSThree,
            this.tlStripPreviousVoSFour,
            this.tlStripPreviousVoSFive});
            this.past5VoSToolStripMenuItem.Name = "past5VoSToolStripMenuItem";
            this.past5VoSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.past5VoSToolStripMenuItem.Text = "P&ast 5 VoS";
            // 
            // tlStripPreviousVoSOne
            // 
            this.tlStripPreviousVoSOne.Name = "tlStripPreviousVoSOne";
            this.tlStripPreviousVoSOne.Size = new System.Drawing.Size(152, 22);
            this.tlStripPreviousVoSOne.Text = "#1: --";
            // 
            // tlStripPreviousVoSTwo
            // 
            this.tlStripPreviousVoSTwo.Name = "tlStripPreviousVoSTwo";
            this.tlStripPreviousVoSTwo.Size = new System.Drawing.Size(152, 22);
            this.tlStripPreviousVoSTwo.Text = "#2: --";
            // 
            // tlStripPreviousVoSThree
            // 
            this.tlStripPreviousVoSThree.Name = "tlStripPreviousVoSThree";
            this.tlStripPreviousVoSThree.Size = new System.Drawing.Size(152, 22);
            this.tlStripPreviousVoSThree.Text = "#3: --";
            // 
            // tlStripPreviousVoSFour
            // 
            this.tlStripPreviousVoSFour.Name = "tlStripPreviousVoSFour";
            this.tlStripPreviousVoSFour.Size = new System.Drawing.Size(152, 22);
            this.tlStripPreviousVoSFour.Text = "#4: --";
            // 
            // tlStripPreviousVoSFive
            // 
            this.tlStripPreviousVoSFive.Name = "tlStripPreviousVoSFive";
            this.tlStripPreviousVoSFive.Size = new System.Drawing.Size(152, 22);
            this.tlStripPreviousVoSFive.Text = "#5: --";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::RuneScape_VoS_Notifier.Properties.Resources.App_Background;
            this.ClientSize = new System.Drawing.Size(291, 173);
            this.Controls.Add(this.lblTimeUntilNextVOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDisplayTwo);
            this.Controls.Add(this.picDisplayOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "RuneScape - Voice of Seren";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.cntxtNotifyIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcoVOS;
        private System.Windows.Forms.PictureBox picDisplayOne;
        private System.Windows.Forms.PictureBox picDisplayTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeUntilNextVOS;
        private System.Windows.Forms.ContextMenuStrip cntxtNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem past5VoSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlStripPreviousVoSOne;
        private System.Windows.Forms.ToolStripMenuItem tlStripPreviousVoSTwo;
        private System.Windows.Forms.ToolStripMenuItem tlStripPreviousVoSThree;
        private System.Windows.Forms.ToolStripMenuItem tlStripPreviousVoSFour;
        private System.Windows.Forms.ToolStripMenuItem tlStripPreviousVoSFive;
    }
}

