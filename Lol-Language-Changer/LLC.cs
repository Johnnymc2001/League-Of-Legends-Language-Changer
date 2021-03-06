using LLCLib;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Lol_Language_Changer
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

        public LLC()
        {
            InitializeComponent();
        }

        private void TimerTick(object source, ElapsedEventArgs e)
        {
            getProcessData();
        }

        private void getProcessData(bool init = false)
        {
            processData = ProcessLib.GetProcessData();

            if (init)
            {
                return;
            }

            if (processData.riotClient == null || processData.leagueClient == null)
            {
                txtClient.Text = "Waiting For Client...";
                return;
            }

            cbLanguage.Items.Clear();
            cbLanguage.Items.AddRange(processData.languages.ToArray());

            txtClient.Text = $"Client Found! [{processData.languages.Count} languages found!]";
            stopPollingForClient();
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
            getProcessData(true);
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
    }
}