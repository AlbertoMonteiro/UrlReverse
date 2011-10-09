using System.Windows.Forms;

namespace UrlReverse
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
                notificationIcon.Visible = false;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxNotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxNotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationIcon
            // 
            this.notificationIcon.ContextMenuStrip = this.ctxNotifyMenu;
            this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
            this.notificationIcon.Text = "Url Reverse";
            this.notificationIcon.Visible = true;
            // 
            // ctxNotifyMenu
            // 
            this.ctxNotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem});
            this.ctxNotifyMenu.Name = "ctxNotifyMenu";
            this.ctxNotifyMenu.Size = new System.Drawing.Size(110, 26);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Image = global::UrlReverse.Properties.Resources.Close;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "&Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.FecharToolStripMenuItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1Activated);
            this.ctxNotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon notificationIcon;
        private ContextMenuStrip ctxNotifyMenu;
        private ToolStripMenuItem fecharToolStripMenuItem;
    }
}

