using LLCLib;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Timers;
using Timer = System.Timers.Timer;

namespace LLCGUI
{
    public partial class LLC : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        Timer checkTimer = new Timer();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        ProcessData processData = null;
        string languageFolder = null;

        string version = "v1.1";

        public LLC()
        {
            InitializeComponent();
        }

        private void TimerTick(object? source, ElapsedEventArgs e)
        {
            getProcessData();
            Trace.WriteLine("AA");
        }

        private void getProcessData()
        {
            processData = ProcessLib.GetProcessData();

            if (languageFolder == null && processData.languageFolder != null)
            {
                languageFolder = processData.languageFolder;
                llLanguageFolder.Enabled = true;
            };

            try
            {
                if (processData.riotClient == null || processData.leagueClient == null)
                {
                    txtClient.Text = "Waiting For Client...";
                    return;
                }

                txtCommandLine.Text = processData.riotClientCmd;

                cbLanguage.Items.Clear();
                cbLanguage.Items.AddRange(processData.languages.ToArray());
                if (processData.languages.Count > 0) cbLanguage.SelectedIndex = 0;

                //if (processData.leagueClient.StartTime.AddMinutes(5) < DateTime.Now)
                //{
                //    txtClient.Text = $"Current LOL Client had been opened for more than 5 minutes, the program may not work, please restart LOL Client ";

                //}
                //else
                //{
                txtClient.Text = $"Current: [{processData.currentLanguage}]! [{processData.languages.Count} languages found!]";
                //}
                stopPollingForClient();
            }
            catch
            {

            }

        }

        private void pollingForClient()
        {
            btnChange.Enabled = false;
            btnRefreshClient.Enabled = false;
            checkTimer.Start();
        }

        private void stopPollingForClient()
        {
            btnChange.Enabled = true;
            btnRefreshClient.Enabled = true;
            checkTimer.Stop();
        }

        // ==========================================================================================================
        private void LLC_Load(object sender, EventArgs e)
        {
            checkTimer.Elapsed += new ElapsedEventHandler(TimerTick);
            checkTimer.Interval = 5000;
            checkTimer.Start();

            lblCurrentVersion.Text = version;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            processData = ProcessLib.GetProcessData();
            processData.RunGame(cbLanguage.Text);

            pollingForClient();
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            getProcessData();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nyanpasu~~ :3");
        }

        private void llLanguageFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = processData.languageFolder,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbThinh_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "https://www.facebook.com/thinh.thui.58",
                UseShellExecute = true,
            });
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(processData.riotClientCmd);
        }

        private void btnRefreshClient_Click(object sender, EventArgs e)
        {
            pollingForClient();
        }

        private void LLC_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}