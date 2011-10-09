using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UrlReverse
{
    public partial class Form1 : Form
    {
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x030D;

        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        IntPtr nextClipboardViewer;

        public Form1()
        {
            InitializeComponent();
            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)Handle);
            notificationIcon.Visible = true;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    DisplayClipboardData();
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void DisplayClipboardData()
        {
            var iData = Clipboard.GetText();
            if (!string.IsNullOrEmpty(iData))
            {
                var regex = new Regex(@"(?'url'[\w\.\/\?\=\-\&]+//:ptth)$");
                var match = regex.Match(iData);
                if (match.Success)
                {
                    var url = match.Groups["url"].Value.Inverter();
                    Clipboard.SetText(url);
                    notificationIcon.ShowBalloonTip(1000, "Inversor de Url", "Url revertida", ToolTipIcon.Info); 
                }
            }
        }

        private void Form1Activated(object sender, EventArgs e)
        {
            Hide();
        }

        private void FecharToolStripMenuItemClick(object sender, EventArgs e)
        {
            notificationIcon.Visible = false;
            Close();
        }
    }
}
