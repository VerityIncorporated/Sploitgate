using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;
using MetroFramework.Forms;
using Sploitgate.Utils;

namespace Sploitgate
{
    public partial class SploitGate : MetroForm
    {
        public static Utils.Config userSettings;

        AutoItX3 AutoIt = new AutoItX3();
        public static string ClickingType = "LEFT";
        public static bool _ConfigsLoaded = false;
        public static bool _TriggerbotEnabled = false;
        public static bool _ShottySnipers = false;
        public static bool _AntiRecoil = false;
        public static bool _ChromamodeEnabled = false;
        public static bool _Humanized = false;
        public static bool _QuickScope = false;
        public static int Humanization = 100;
        public static int AntiRecoilStength = 0;
        public static int ShotDelay = 0;

        int topscan;
        int leftscan;
        int bottomscan;
        int rightscan;


        public SploitGate(int top, int left, int bottom, int right)
        {

            InitializeComponent();
            topscan = top;
            leftscan = left;
            bottomscan = bottom;
            rightscan = right;
        }

        #region ThemeShit

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.CurrentDirectory + @"\Configs\"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Configs\");
            }
            Utils.Scamble.Title();
            var theme = StyleManager.Theme;
            var style = StyleManager.Style;
            Theme = theme;
            Style = style;
            try
            {
                welcomeLabel.Text = "Welcome " + Login.Auth.user_data.username + ", to Sploitgate.";
                subLabel.Text = "Subscription: " + Login.Auth.user_data.subscriptions[0].subscription + ", Expires " + UnixTimeToDateTime(long.Parse(Login.Auth.user_data.subscriptions[0].expiry));
                motdLabel.Text = "MOTD: " + Login.Auth.var("MOTD");
                Shown += SploitGate_Shown;
            }
            catch(NullReferenceException)
            {
                Environment.Exit(0);
            }
        }

        private void SploitGate_Shown(object sender, EventArgs e)
        {
            Transition.ShowSync(triggerbotGroupBox);
            Transition.ShowSync(triggerbotoptionsGroupBox);
            Transition.ShowSync(miscGroupBox);
            Transition.ShowSync(welcomeLabel);
            Transition.ShowSync(subLabel);
            Transition.ShowSync(motdLabel);
            SploitgateInitialization();
        }
        #endregion

        #region TriggerbotFunction
        private void SploitgateInitialization()
        {
            new Thread(() =>
            {
                TriggerbotFunction();
            }).Start();
        }

        private void TriggerbotFunction()
        {
            while (true)
            {
                if (_TriggerbotEnabled)
                {
                    try
                    {
                        object pix = AutoIt.PixelSearch(topscan, leftscan, bottomscan, rightscan, 0xFF0000);
                        if (pix.ToString() != "1")
                        {
                            object[] pixCoord = (object[])pix;
                            if (_ShottySnipers)
                            {
                                if(_QuickScope)
                                {
                                    AutoIt.Sleep(ShotDelay);
                                    AutoIt.MouseDown("RIGHT");
                                    AutoIt.MouseClick(ClickingType);
                                    AutoIt.MouseWheel("DOWN", 1);
                                    AutoIt.MouseUp("RIGHT");
                                }
                                else
                                {
                                    AutoIt.Sleep(ShotDelay);
                                    AutoIt.MouseClick(ClickingType);
                                    AutoIt.MouseWheel("DOWN", 1);
                                }
                            }
                            else if (_AntiRecoil)
                            {
                                AutoIt.Sleep(ShotDelay);
                                var x = Cursor.Position.X;
                                var y = Cursor.Position.Y;
                                AutoIt.MouseDown(ClickingType);
                                AutoIt.MouseMove(x, y + AntiRecoilStength);
                                AutoIt.Sleep(Humanization);
                                AutoIt.MouseUp(ClickingType);
                                Cursor.Position = new Point(x, y);
                            }
                            else
                            {
                                AutoIt.Sleep(ShotDelay);
                                AutoIt.MouseDown(ClickingType);
                                AutoIt.Sleep(Humanization);
                                AutoIt.MouseUp(ClickingType);
                            }
                        }
                    }
                    catch
                    {
                        { }
                    }
                }
                Thread.Sleep(10);
            }
        }

        #endregion

        #region TriggerbotSettings

        private void triggerbotToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotToggleSwitch.Checked)
            {
                _TriggerbotEnabled = true;
            }
            else
            {
                _TriggerbotEnabled = false;
            }
        }

        private void shottysnipersToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (_AntiRecoil)
            {
                _AntiRecoil = false;
                antirecoilToggleSwitch.Checked = false;
            }

            if (shottysnipersToggleSwitch.Checked)
            {
                _ShottySnipers = true;
            }
            else
            {
                _ShottySnipers = false;
            }
        }

        private void shotdelayTrackBar_ValueChanged(object sender, EventArgs e)
        {
            delayLabel.Text = "Shot Delay: " + shotdelayTrackBar.Value + "ms";
            ShotDelay = shotdelayTrackBar.Value;
        }

        private void antirecoilToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (_ShottySnipers)
            {
                _ShottySnipers = false;
                shottysnipersToggleSwitch.Checked = false;
            }

            if (antirecoilToggleSwitch.Checked)
            {
                _AntiRecoil = true;
            }
            else
            {
                _AntiRecoil = false;
            }
        }

        private void antirecoilstrengthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            antirecoilstrengthLabel.Text = "Anti-Recoil Strength: " + antirecoilstrengthTrackBar.Value;
            AntiRecoilStength = antirecoilstrengthTrackBar.Value;
        }

        private void humanizeToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (humanizeToggleSwitch.Checked)
            {
                _Humanized = true;
                humanizationTimer.Enabled = true;
            }
            else
            {
                _Humanized = false;
                humanizationTimer.Enabled = false;
                Humanization = 100;
            }
        }

        private void humanizationTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int RandomDelay = rnd.Next(600);
            Humanization = RandomDelay;
        }

        private void quickscopeToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (quickscopeToggleSwitch.Checked)
            {
                MessageBox.Show("this option only functions with ShottySnipers Enabled!", "Sploitgate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _QuickScope = true;
            }
            else
            {
                _QuickScope = false;
            }
        }
        #endregion

        #region Misc

        private void lightmodeToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Process[] xD = Process.GetProcesses();
            foreach (Process Funny in xD)
            {
                if (Funny.ProcessName != Process.GetCurrentProcess().ProcessName)
                {
                    try
                    {
                        Funny.Kill();
                    }
                    catch
                    {
                        { }
                    }
                }
            }
            Process.GetCurrentProcess().Kill();
        }

        private void chromamodeToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (chromamodeToggleSwitch.Checked)
            {
                _ChromamodeEnabled = true;
                ChromamodeTimer.Enabled = true;
            }
            else
            {
                _ChromamodeEnabled = false;
                ChromamodeTimer.Enabled = false;
                chromamodeToggleSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
                shottysnipersToggleSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
                triggerbotToggleSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
                antirecoilToggleSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
                shotdelayTrackBar.ThumbColor = Color.BlueViolet;
                antirecoilstrengthTrackBar.ThumbColor = Color.BlueViolet;
                triggerbotGroupBox.CustomBorderColor = Color.BlueViolet;
                miscGroupBox.CustomBorderColor = Color.BlueViolet;
                triggerbotoptionsGroupBox.CustomBorderColor = Color.BlueViolet;
                loadconfigsComboBox.FillColor = Color.DarkSlateBlue;
                configsaveButton.FillColor = Color.DarkSlateBlue;
                loadconfigsComboBox.ForeColor = Color.White;
                configsaveButton.ForeColor = Color.White;
                welcomeLabel.ForeColor = Color.White;
                triggerbotGroupBox.ForeColor = Color.White;
                triggerbotoptionsGroupBox.ForeColor = Color.White;
                miscGroupBox.ForeColor = Color.White;
            }
        }

        private void ChromamodeTimer_Tick(object sender, EventArgs e)
        {
            Utils.ChromaMode.rainbowProg += 0.01f;
            chromamodeToggleSwitch.CheckedState.FillColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            shottysnipersToggleSwitch.CheckedState.FillColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            triggerbotToggleSwitch.CheckedState.FillColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            antirecoilToggleSwitch.CheckedState.FillColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            shotdelayTrackBar.ThumbColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            antirecoilstrengthTrackBar.ThumbColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            triggerbotGroupBox.CustomBorderColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            miscGroupBox.CustomBorderColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            triggerbotoptionsGroupBox.CustomBorderColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            loadconfigsComboBox.FillColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            configsaveButton.FillColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            welcomeLabel.ForeColor = Utils.ChromaMode.Rainbow(Utils.ChromaMode.rainbowProg);
            configsaveButton.ForeColor = Color.Gray;
            loadconfigsComboBox.ForeColor = Color.Gray;
            triggerbotGroupBox.ForeColor = Color.Gray;
            triggerbotoptionsGroupBox.ForeColor = Color.Gray;
            miscGroupBox.ForeColor = Color.Gray;
        }


        private void loadconfigsComboBox_Click(object sender, EventArgs e)
        {
            loadconfigsComboBox.Items.Clear();
            var currentDirectory = Environment.CurrentDirectory;
            var files = Directory.GetFiles(currentDirectory + @"\Configs\");
            loadconfigsComboBox.Items.Add("Load Configs");
            foreach (var filePath in files)
            {
                if (filePath.ToUpper().Contains(".JSON"))
                {
                    if(!filePath.ToUpper().Contains("RESOLUTION.JSON"))
                    {
                        loadconfigsComboBox.Items.Add(Path.GetFileName(filePath));
                    }
                }
            }
        }

        private void loadconfigsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadconfigsComboBox.Text != @"Load Configs")
            {
                if(loadconfigsComboBox.Text != @"Resolution.json")
                {
                    triggerbotToggleSwitch.Checked = false;
                    _TriggerbotEnabled = false;
                    shottysnipersToggleSwitch.Checked = false;
                    _ShottySnipers = false;
                    chromamodeToggleSwitch.Checked = false;
                    _ChromamodeEnabled = false;
                    antirecoilToggleSwitch.Checked = false;
                    _AntiRecoil = false;
                    rightclickToggleSwitch.Checked = false;
                    ClickingType = null;
                    _Humanized = false;
                    Humanization = 100;
                    humanizeToggleSwitch.Checked = false;
                    humanizationTimer.Enabled = false;
                    AntiRecoilStength = 0;
                    antirecoilstrengthTrackBar.Value = 0;
                    shotdelayTrackBar.Value = 0;
                    ShotDelay = 0;
                    _QuickScope = false;
                    quickscopeToggleSwitch.Checked = false;

                    var currentDirectory = Environment.CurrentDirectory;
                    userSettings = Utils.ConfigManager.LoadSettings(currentDirectory + @"\Configs\" + loadconfigsComboBox.Text);

                    _TriggerbotEnabled = userSettings.Triggerbot;
                    _ShottySnipers = userSettings.ShottySnipers;
                    _ChromamodeEnabled = userSettings.Chromamode;
                    _AntiRecoil = userSettings.AntiRecoil;
                    AntiRecoilStength = userSettings.AntiRecoilStrength;
                    antirecoilstrengthTrackBar.Value = userSettings.AntiRecoilStrength;
                    _Humanized = userSettings.Humanization;
                    shotdelayTrackBar.Value = userSettings.ShotDelay;
                    ShotDelay = userSettings.ShotDelay;
                    ClickingType = userSettings.Clicking;
                    _QuickScope = userSettings.Quickscope;

                    if (_TriggerbotEnabled)
                    {
                        triggerbotToggleSwitch.Checked = true;
                    }

                    if (_ShottySnipers)
                    {
                        shottysnipersToggleSwitch.Checked = true;
                    }

                    if (_ChromamodeEnabled)
                    {
                        chromamodeToggleSwitch.Checked = true;
                    }

                    if (_AntiRecoil)
                    {
                        if (_ShottySnipers)
                        {
                            _AntiRecoil = false;
                            antirecoilToggleSwitch.Checked = false;
                        }
                        else
                        {
                            antirecoilToggleSwitch.Checked = true;
                            _AntiRecoil = true;
                        }
                    }

                    if (_Humanized == true)
                    {
                        humanizeToggleSwitch.Checked = true;
                        humanizationTimer.Enabled = true;
                    }

                    if (ClickingType == "RIGHT")
                    {
                        rightclickToggleSwitch.Checked = true;
                    }

                    if(_QuickScope)
                    {
                        quickscopeToggleSwitch.Checked = true;
                    }
                }
            }
        }

        private void configsaveButton_Click(object sender, EventArgs e)
        {
            var currentDirectory = Environment.CurrentDirectory;
            var fCount = Directory.GetFiles(currentDirectory + @"\Configs\", "*", SearchOption.TopDirectoryOnly).Length;
            Utils.ConfigManager.SaveSettings(currentDirectory + @"\Configs\Config" + fCount++ + ".json");
        }

        private void rightclickToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (rightclickToggleSwitch.Checked)
            {
                ClickingType = "RIGHT";
            }
            else
            {
                ClickingType = "LEFT";
            }
        }

        private void SploitGate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion
    }
}