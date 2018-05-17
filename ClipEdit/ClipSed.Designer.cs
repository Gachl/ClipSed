namespace ClipEdit
{
    partial class ClipSed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipSed));
            this.lblS = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lblSlash = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lblParams = new System.Windows.Forms.Label();
            this.cbTone = new System.Windows.Forms.ComboBox();
            this.lblTone = new System.Windows.Forms.Label();
            this.niMinimized = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotificationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNotificationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(12, 9);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(12, 13);
            this.lblS.TabIndex = 0;
            this.lblS.Text = "s";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(30, 6);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(246, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Location = new System.Drawing.Point(282, 9);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(12, 13);
            this.lblSlash.TabIndex = 2;
            this.lblSlash.Text = "/";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(300, 6);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(243, 20);
            this.txtReplace.TabIndex = 3;
            this.txtReplace.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblParams
            // 
            this.lblParams.AutoSize = true;
            this.lblParams.Location = new System.Drawing.Point(549, 9);
            this.lblParams.Name = "lblParams";
            this.lblParams.Size = new System.Drawing.Size(18, 13);
            this.lblParams.TabIndex = 4;
            this.lblParams.Text = "/g";
            // 
            // cbTone
            // 
            this.cbTone.FormattingEnabled = true;
            this.cbTone.Items.AddRange(new object[] {
            "Asterisk",
            "Beep",
            "Exclamation",
            "Hand",
            "Question"});
            this.cbTone.Location = new System.Drawing.Point(53, 35);
            this.cbTone.Name = "cbTone";
            this.cbTone.Size = new System.Drawing.Size(223, 21);
            this.cbTone.TabIndex = 5;
            this.cbTone.Text = "Beep";
            this.cbTone.SelectedIndexChanged += new System.EventHandler(this.cbTone_SelectedIndexChanged);
            // 
            // lblTone
            // 
            this.lblTone.AutoSize = true;
            this.lblTone.Location = new System.Drawing.Point(12, 38);
            this.lblTone.Name = "lblTone";
            this.lblTone.Size = new System.Drawing.Size(35, 13);
            this.lblTone.TabIndex = 6;
            this.lblTone.Text = "Tone:";
            // 
            // niMinimized
            // 
            this.niMinimized.ContextMenuStrip = this.cmsNotificationMenu;
            this.niMinimized.Icon = ((System.Drawing.Icon)(resources.GetObject("niMinimized.Icon")));
            this.niMinimized.Text = "Clipboard Streaming Editor";
            this.niMinimized.Visible = true;
            this.niMinimized.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cmsNotificationMenu
            // 
            this.cmsNotificationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.cmsNotificationMenu.Name = "cmsNotificationMenu";
            this.cmsNotificationMenu.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ClipSed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 68);
            this.Controls.Add(this.lblTone);
            this.Controls.Add(this.cbTone);
            this.Controls.Add(this.lblParams);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.lblSlash);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClipSed";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Clipboard Streaming Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClipSed_FormClosing);
            this.cmsNotificationMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label lblParams;
        private System.Windows.Forms.ComboBox cbTone;
        private System.Windows.Forms.Label lblTone;
        private System.Windows.Forms.NotifyIcon niMinimized;
        private System.Windows.Forms.ContextMenuStrip cmsNotificationMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

