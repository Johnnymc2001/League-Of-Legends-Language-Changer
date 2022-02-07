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

                cbLanguage.Items.Clear();
                cbLanguage.Items.AddRange(processData.languages.ToArray());

                txtClient.Text = $"Current: [{processData.currentLanguage}]! [{processData.languages.Count} languages found!]";
                stopPollingForClient();
            }
            catch
            {

            }

        }

        private void pollingForClient()
        {
            btnChange.Enabled = false;
            checkTimer.Start();
        }

        private void stopPollingForClient()
        {
            btnChange.Enabled = true;
            checkTimer.Stop();
        }

        // ==========================================================================================================
        private void LLC_Load(object sender, EventArgs e)
        {
            checkTimer.Elapsed += new ElapsedEventHandler(TimerTick);
            checkTimer.Interval = 5000;
            checkTimer.Start();
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
            MessageBox.Show("Miao :3 ?");
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
    }
}