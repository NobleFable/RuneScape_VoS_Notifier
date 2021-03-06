﻿using RuneScape_VoS_Notifier.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuneScape_VoS_Notifier
{
    public partial class FormMain : Form
    {

        private struct PastVoS
        {
            public string Display;
        }

        public static FormMain Instance
        {
            get; private set;
        }

        static CheckerThread checker;

        static List<PastVoS> pastVoS = new List<PastVoS>();

        public FormMain()
        {
            Instance = this;
            InitializeComponent();
            checker = new CheckerThread();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcoVOS.Visible = true;
                notifyIcoVOS.ShowBalloonTip(10);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcoVOS.Visible = false;
            }
        }

        private void notifyIcoVOS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        public void SetLabelText(string text)
        {
            lblTimeUntilNextVOS.BeginInvoke((MethodInvoker)delegate () { this.lblTimeUntilNextVOS.Text = text; });
        }

        public void SetVoS(string clanOne, string clanTwo)
        {
            picDisplayOne.BeginInvoke((MethodInvoker)delegate () { this.picDisplayOne.Image = GetVoSImage(clanOne); });
            picDisplayTwo.BeginInvoke((MethodInvoker)delegate () { this.picDisplayTwo.Image = GetVoSImage(clanTwo); });
        }

        private Bitmap GetVoSImage(string clan)
        {
            if (clan == null)
                return RuneScape_VoS_Notifier.Properties.Resources.Badge_cancel;
            switch (clan)
            {
                case "Crwys": return RuneScape_VoS_Notifier.Properties.Resources.Crwys_Clan;
                case "Ithell": return RuneScape_VoS_Notifier.Properties.Resources.Ithell_Clan;
                case "Hefin": return RuneScape_VoS_Notifier.Properties.Resources.Hefin_Clan;
                case "Amlodd": return RuneScape_VoS_Notifier.Properties.Resources.Amlodd_Clan;
                case "Meilyr": return RuneScape_VoS_Notifier.Properties.Resources.Meilyr_Clan;
                case "Iorwerth": return RuneScape_VoS_Notifier.Properties.Resources.Iorwerth_Clan;
                case "Trahaearn": return RuneScape_VoS_Notifier.Properties.Resources.Trahaearn_Clan;
                case "Cadarn": return RuneScape_VoS_Notifier.Properties.Resources.Cadarn_Clan;
                default: return RuneScape_VoS_Notifier.Properties.Resources.Badge_cancel;
            }
        }

        public void ShowNotification(string clanOne, string clanTwo, bool trahHour, int hour)
        {
            UpdatePastVoS(clanOne, clanTwo, hour);
            this.notifyIcoVOS.BalloonTipText = string.Format("The Voice of Seren is now active in the {0} and {1} districts!", clanOne, clanTwo);
            this.notifyIcoVOS.Text = new StringBuilder().Append("Voice of Seren - ").Append(clanOne).Append(" and ").Append(clanTwo).ToString();
            if (trahHour)
            {
                this.notifyIcoVOS.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
                notifyIcoVOS.ShowBalloonTip(60);
            }
            else
            {
                this.notifyIcoVOS.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                notifyIcoVOS.ShowBalloonTip(10);
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            checker.Quit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checker.Quit();
            this.Close();
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void UpdatePastVoS(string clanOne, string clanTwo, int hour)
        {
            // add the newest to the list
            PastVoS past = new PastVoS();
            past.Display = string.Format("{0}:00 - {1} and {2}", hour.ToString("00"), clanOne, clanTwo);
            pastVoS.Add(past);
            if (pastVoS.Count() > 6)
            {
                pastVoS.RemoveAt(0);
            }
            if (pastVoS.Count() > 1)
                this.tlStripPreviousVoSOne.Text = "#1: " + pastVoS.ElementAt(0).Display;
            if (pastVoS.Count() > 2)
                this.tlStripPreviousVoSTwo.Text = "#2: " + pastVoS.ElementAt(1).Display;
            if (pastVoS.Count() > 3)
                this.tlStripPreviousVoSThree.Text = "#3: " + pastVoS.ElementAt(2).Display;
            if (pastVoS.Count() > 4)
                this.tlStripPreviousVoSFour.Text = "#4: " + pastVoS.ElementAt(3).Display;
            if (pastVoS.Count() > 5)
                this.tlStripPreviousVoSFive.Text = "#5: " + pastVoS.ElementAt(4).Display;
        }
    }
}
