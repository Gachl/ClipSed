using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipEdit
{
    public partial class ClipSed : Form
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        private string find, replace, tone;

        public ClipSed()
        {
            InitializeComponent();
            SetClipboardViewer(this.Handle);
            this.threadSafePersist();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0308)
                this.doClipboardUpdate();
            else
                base.WndProc(ref m);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) => this.Show();
        private void txt_TextChanged(object sender, EventArgs e) => this.threadSafePersist();
        private void cbTone_SelectedIndexChanged(object sender, EventArgs e) => this.threadSafePersist();

        private void ClipSed_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void threadSafePersist()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => this.threadSafePersist()));
                return;
            }

            this.find = txtFind.Text;
            this.replace = txtReplace.Text;
            this.tone = cbTone.SelectedItem as string;
        }

        private void doClipboardUpdate()
        {
            // Caught clipboard event before completion of initialisation.
            if (this.find == null || this.replace == null)
                return;

            string clip = Clipboard.GetText();
            string newClip = Regex.Replace(clip, this.find, this.replace);
            if (clip != newClip)
            {
                Clipboard.SetText(newClip);
                this.doTone();
            }
        }

        private void doTone()
        {
            switch (this.tone)
            {
                case "Beep":
                    System.Media.SystemSounds.Beep.Play();
                    break;
                case "Asterisk":
                    System.Media.SystemSounds.Asterisk.Play();
                    break;
                case "Exclamation":
                    System.Media.SystemSounds.Exclamation.Play();
                    break;
                case "Hand":
                    System.Media.SystemSounds.Hand.Play();
                    break;
                case "Question":
                    System.Media.SystemSounds.Question.Play();
                    break;
            }
        }
    }
}
