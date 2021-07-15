using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
// Please bear with me i make this in 2 hours :'(
namespace DiscordRPC
{
    public partial class FormMain : Form
    {
        private readonly string CURRENT_WORKING_DIRECTORY = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private readonly string DATA_FILENAME = "conf.json";

        private FormExtra formExtra = new();
        private CustomRPCManager customRPCManager;
        private Thread discordRPC_Thread;
        private Discord.Discord discord_;
        private bool isRunning = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (isFirstLaunch())
            {
				
            }

            CheckDataAvailability();
            customRPCManager = new CustomRPCManager();
        }

        private void btn_set_Click(object sender, EventArgs e)
        { 
            customRPCManager.app_id = dis_app_id.Text;
            customRPCManager.custom_details = dis_custom_details.Text;
            customRPCManager.custom_state = dis_custom_state.Text;

            if (!string.IsNullOrWhiteSpace(dis_timestamp_start.Text))
            {
                customRPCManager.start_timestamp = (ulong)Int64.Parse(dis_timestamp_start.Text);
            } else {
				customRPCManager.start_timestamp = 0;
			}

            if (!string.IsNullOrWhiteSpace(dis_timestamp_start.Text))
            {
                customRPCManager.end_timestamp = (ulong)Int64.Parse(dis_timestamp_end.Text);
			} else {
				customRPCManager.end_timestamp = 0;
			}
            
            customRPCManager.large_image_key = dis_image_large_key.Text;
            customRPCManager.large_image_text = dis_image_large_text.Text;
            customRPCManager.small_image_key = dis_image_small_key.Text;
            customRPCManager.small_image_text = dis_image_small_text.Text;

            displayData();

            if (string.IsNullOrWhiteSpace(customRPCManager.app_id))
            {
                MessageBox.Show("Please enter appid", "App ID not set", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isRunning = true;

            if (discord_ == null)
            {
                discord_ = new Discord.Discord(Int64.Parse(customRPCManager.app_id), (UInt64)Discord.CreateFlags.Default);

                UpdateActivityInternal(discord_);

                discordRPC_Thread = new Thread(new ThreadStart(discordrpc_func));
                discordRPC_Thread.Start();
            }
            else
            {
                UpdateActivityInternal(discord_);
            }
        }

        private void UpdateActivityInternal(Discord.Discord discord)
        {
            var activityManager = discord.GetActivityManager();
            // if (customRPCManager.extra_enabled)
            // {
            //     var lobbyManager = discord.GetLobbyManager();
			// 
            //     var transaction = lobbyManager.GetLobbyCreateTransaction();
            //     transaction.SetCapacity(6);
            //     transaction.SetType(Discord.LobbyType.Public);
            //     transaction.SetMetadata("a", "123");
            //     transaction.SetMetadata("a", "456");
            //     transaction.SetMetadata("b", "111");
            //     transaction.SetMetadata("c", "222");
            // }
            var activity = new Discord.Activity
            {
                State = customRPCManager.custom_state,
                Details = customRPCManager.custom_details,
                Timestamps = { Start = (long)customRPCManager.start_timestamp, End = (long)customRPCManager.end_timestamp, },
                Assets = {
                        LargeImage = customRPCManager.large_image_key,
                        LargeText = customRPCManager.large_image_text,
                        SmallImage = customRPCManager.small_image_key,
                        SmallText = customRPCManager.small_image_text,
                    },
                Instance = true,
            };
            activityManager.UpdateActivity(activity, result => {/*Console.WriteLine("Update Activity {0}", result);*/});
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit Application
            Application.Exit();
        }

        private void saveConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ToDo Add Save
            customRPCManager.app_id = dis_app_id.Text;
            customRPCManager.custom_state = dis_custom_state.Text;
            customRPCManager.custom_details = dis_custom_details.Text;
            if (!string.IsNullOrWhiteSpace(dis_timestamp_start.Text))
            {
                customRPCManager.start_timestamp = (ulong)Int64.Parse(dis_timestamp_start.Text);
            }
            if (!string.IsNullOrWhiteSpace(dis_timestamp_end.Text))
            {
                customRPCManager.end_timestamp = (ulong)Int64.Parse(dis_timestamp_end.Text);
            }
            customRPCManager.large_image_key = dis_image_large_key.Text;
            customRPCManager.large_image_text = dis_image_large_text.Text;
            customRPCManager.small_image_key = dis_image_small_key.Text;
            customRPCManager.small_image_text = dis_image_small_text.Text;
            SaveConfiguration();
        }

        private void loadConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ToDo Add Load
            LoadConfiguration();
        }

        private void extraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormExtra"] as FormExtra) != null)
            {
                return;
            }
            new FormExtra().Show();
            // var extra = new FormExtra { parent = this };
            // extra.Show();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will clear all the input below", "Are You Sure ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // ToDo Stop RPC here
                if (customRPCManager != null)
                {
                    customRPCManager.Clear();
                    displayData();
                }
            }
        }

        private void btn_timenow_1_Click(object sender, EventArgs e)
        {
            dis_timestamp_start.Text = GetCurrentUnixTimestamp().ToString();
        }

        private void btn_timenow_2_Click(object sender, EventArgs e)
        {
            dis_timestamp_end.Text = GetCurrentUnixTimestamp().ToString();
        }

        private void dis_timestamp_start_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = !int.TryParse(Convert.ToString((char)e.KeyData), out int _result) && e.KeyCode != Keys.Back;
        }

        private void dis_timestamp_end_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = !int.TryParse(Convert.ToString((char)e.KeyData), out int _result) && e.KeyCode != Keys.Back;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            if (discordRPC_Thread != null)
            {
                if (discordRPC_Thread.IsAlive)
                {
                    AutoClosingMessageBox.Show("Waiting for thread to close", "This will take a few second", 5000, MessageBoxButtons.OK);
                }
            }
        }

        private void discordDeveloperAppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // https://discord.com/developers/applications
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C start https://discord.com/developers/applications",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };
            Process.Start(psi);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. Open Discord Developer Apps\n" +
                "2. Create Apps/Select One\n" +
                "3. Copy and paste Application ID\n" +
                "4. Paste here and click 'Set'", "How To", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private long GetCurrentUnixTimestamp()
        {
            return DateTimeOffset.Now.ToUnixTimeSeconds();
        }

        private void CheckDataAvailability()
        {
            if (File.Exists($"{CURRENT_WORKING_DIRECTORY}\\{DATA_FILENAME}"))
            {
                DialogResult ret = MessageBox.Show("Do you want to load configuration", "Configuration Found!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    // Load Here
                    LoadConfiguration();
                    displayData();
                }
            }
        }

        private void displayData()
        {
            dis_app_id.Text = customRPCManager.app_id;
            dis_custom_details.Text = customRPCManager.custom_details;
            dis_custom_state.Text = customRPCManager.custom_state;
            dis_timestamp_start.Text = customRPCManager.start_timestamp.ToString();
            dis_timestamp_end.Text = customRPCManager.end_timestamp.ToString();
            dis_image_large_key.Text = customRPCManager.large_image_key;
            dis_image_large_text.Text = customRPCManager.large_image_text;
            dis_image_small_key.Text = customRPCManager.small_image_key;
            dis_image_small_text.Text = customRPCManager.small_image_text;
        }

        private void SaveConfiguration()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize<CustomRPCManager>(customRPCManager, new JsonSerializerOptions { WriteIndented = true, PropertyNameCaseInsensitive = true });
                File.WriteAllText(DATA_FILENAME, jsonString);
                MessageBox.Show($"Saved as {DATA_FILENAME}", "Success");
            }
            catch (Exception)
            {
                DialogResult ret = MessageBox.Show("Looks like something’s not working right!", "Saving Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (ret == DialogResult.Retry)
                {
                    SaveConfiguration();
                }
            }
        }

        private void LoadConfiguration()
        {
            if (!File.Exists($"{CURRENT_WORKING_DIRECTORY}\\{DATA_FILENAME}"))
            {
                return;
            }
            try
            {
                string jsonString = File.ReadAllText($"{CURRENT_WORKING_DIRECTORY}\\{DATA_FILENAME}");
                customRPCManager = JsonSerializer.Deserialize<CustomRPCManager>(jsonString);

                displayData();
            }
            catch (Exception)
            {
                DialogResult ret = MessageBox.Show("Looks like something’s not working right!", "Load Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (ret == DialogResult.Retry)
                {
                    LoadConfiguration();
                }
            }
        }

        private bool isFirstLaunch()
        {
            if (!File.Exists($"{CURRENT_WORKING_DIRECTORY}\\.firstlaunch"))
            {
                using (File.Create($"{CURRENT_WORKING_DIRECTORY}\\.firstlaunch")) { }
                return true;
            }
            return false;
        }

        private void discordrpc_func()
        {
            try
            {
                while (isRunning)
                {
                    discord_.RunCallbacks();
                    // lobbyManager.FlushNetwork();
                    Thread.Sleep(1000 / 60);
                }
            }
            finally
            {
                discord_.Dispose();
            }
        }

        public CustomRPCManager GetRPCManager()
        {
            return this.customRPCManager;
        }

        public void ExtraFunction(CustomRPCManager origin)
        {
            // Unused
        }
    }

    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        DialogResult _result;
        DialogResult _timerResult;
        AutoClosingMessageBox(string text, string caption, int timeout, MessageBoxButtons buttons = MessageBoxButtons.OK, DialogResult timerResult = DialogResult.None)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            _timerResult = timerResult;
            using (_timeoutTimer)
                _result = MessageBox.Show(text, caption, buttons);
        }
        public static DialogResult Show(string text, string caption, int timeout, MessageBoxButtons buttons = MessageBoxButtons.OK, DialogResult timerResult = DialogResult.None)
        {
            return new AutoClosingMessageBox(text, caption, timeout, buttons, timerResult)._result;
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
            _result = _timerResult;
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
}