using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Main.Utils;
using WindowsInput.Native;
using WindowsInput;

namespace Main
{
    public partial class Main : MetroForm
    {
        public static Config userSettings;

        InputSimulator sim = new InputSimulator();
        public static string ClickingType = "LEFT";
        public static bool _ConfigsLoaded = false;
        public static bool _TriggerbotEnabled = false;
        public static bool _ShottySnipers = false;
        public static bool _AlwaysHitShottySnipers = false;
        public static bool _AntiRecoil = false;
        public static bool _ChromamodeEnabled = false;
        public static bool _Humanized = false;
        public static bool _QuickScope = false;
        public static bool _CrouchAssist = false;
        public static int Humanization = 100;
        public static int AntiRecoilStength = 0;
        public static int ShotDelay = 0;
        public static int HoldMouseDelay = 0;

        public Main()
        {
            InitializeComponent();
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
            var theme = StyleManager.Theme;
            var style = StyleManager.Style;
            Theme = theme;
            Style = style;
            try
            {
                //welcomeLabel.Text = "Welcome " + Login.Auth.user_data.username + " to Sploitgate " + Login.Auth.version + "!";
                //subLabel.Text = "Subscription: " + Login.Auth.user_data.subscriptions[0].subscription + ", Expires " + UnixTimeToDateTime(long.Parse(Login.Auth.user_data.subscriptions[0].expiry));
                //motdLabel.Text = "MOTD: " + Login.Auth.var("MOTD");
                Shown += Main_Shown;
            }
            catch(NullReferenceException)
            {
                Environment.Exit(0);
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(10);
            Transition.ShowSync(logoPictureBox);
            Transition.ShowSync(triggerbotGroupBox);
            Transition.ShowSync(miscGroupBox);
            Transition.ShowSync(triggerbotoptionsGroupBox);
            Transition.ShowSync(welcomeLabel);
            Transition.ShowSync(subLabel);
            Transition.ShowSync(motdLabel);
            Initialization();
        }
        #endregion

        #region Function
        private void Initialization()
        {
            new Thread(() =>
            {
                Function();
            }).Start();
        }

        Point xy = new Point(960, 539);
        Color PixelScan;

        static Color GetPixel(Point position)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }

        private void Function()
        {
            while(true)
            {
                PixelScan = GetPixel(xy);
                if (PixelScan.ToString() == "Color [A=255, R=255, G=0, B=0]")
                {
                    if (_TriggerbotEnabled)
                    {
                        if (_ShottySnipers)
                        {
                            if (_QuickScope)
                            {
                                sim.Mouse.RightButtonDown();
                                sim.Mouse.Sleep(35);
                                sim.Mouse.LeftButtonClick();
                                sim.Mouse.VerticalScroll(1);
                                sim.Mouse.LeftButtonClick();
                                sim.Mouse.RightButtonUp();
                            }
                            else
                            {
                                sim.Mouse.LeftButtonClick();
                                sim.Mouse.VerticalScroll(1);
                                sim.Mouse.LeftButtonClick();
                            }

                            /*if (_AlwaysHitShottySnipers)
                            {
                                sim.Mouse.LeftButtonClick();
                                sim.Mouse.VerticalScroll(1);
                                sim.Mouse.LeftButtonClick();
                                sim.Mouse.Sleep(500);
                            }
                            else
                            {
                                sim.Mouse.LeftButtonClick();
                                sim.Mouse.VerticalScroll(1);
                                sim.Mouse.LeftButtonClick();
                            }*/
                        }
                        else
                        {
                            if (HoldMouseDelay == 0)
                            {
                                if (_AntiRecoil)
                                {
                                    sim.Mouse.Sleep(ShotDelay);
                                    sim.Mouse.MoveMouseBy(0, AntiRecoilStength);
                                    sim.Mouse.LeftButtonDown();
                                    sim.Mouse.Sleep(Humanization);
                                    sim.Mouse.LeftButtonUp();
                                }
                                else
                                {
                                    sim.Mouse.Sleep(ShotDelay);
                                    sim.Mouse.LeftButtonDown();
                                    sim.Mouse.Sleep(Humanization);
                                    sim.Mouse.LeftButtonUp();
                                }
                            }
                            else
                            {
                                if (_AntiRecoil)
                                {
                                    sim.Mouse.Sleep(ShotDelay);
                                    sim.Mouse.MoveMouseBy(0, AntiRecoilStength);
                                    sim.Mouse.LeftButtonDown();
                                    sim.Mouse.Sleep(HoldMouseDelay);
                                    sim.Mouse.LeftButtonUp();
                                }
                                else
                                {
                                    sim.Mouse.Sleep(ShotDelay);
                                    sim.Mouse.LeftButtonDown();
                                    sim.Mouse.Sleep(HoldMouseDelay);
                                    sim.Mouse.LeftButtonUp();
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region TSettings

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

        private void holdmouseTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if(_Humanized)
            {
                MessageBox.Show("Please disable humanization first!");
            }
            else
            {
                holdmouseLabel.Text = "Hold Mouse Delay: " + holdmouseTrackBar.Value + "ms";
                HoldMouseDelay = shotdelayTrackBar.Value;
            }
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
                holdmouseTrackBar.Value = 0;
                HoldMouseDelay = 0;
                _Humanized = true;
                humanizationTimer.Enabled = true;
            }
            else
            {
                _Humanized = false;
                humanizationTimer.Enabled = false;
                Humanization = 100;
                holdmouseTrackBar.Value = 0;
                HoldMouseDelay = 0;
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
                if(_ShottySnipers)
                {
                    _QuickScope = true;
                }
                else
                {
                    quickscopeToggleSwitch.Checked = false;
                    MessageBox.Show("this option only functions with ShottySnipers Enabled!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _QuickScope = false;
            }
        }

        private void crouchassistToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(crouchassistToggleSwitch.Checked)
            {
                _CrouchAssist = true;
            }
            else
            {
                _CrouchAssist = false;
            }
        }

        #endregion

        #region Misc

        private void chromamodeToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (chromamodeToggleSwitch.Checked)
            {
                _ChromamodeEnabled = true;
                ChromamodeTimer.Enabled = true;
            }
            else
            {
                welcomeLabel.ForeColor = Color.White;
                subLabel.ForeColor = Color.White;
                motdLabel.ForeColor = Color.White;

                _ChromamodeEnabled = false;
                ChromamodeTimer.Enabled = false;
            }
        }

        private void ChromamodeTimer_Tick(object sender, EventArgs e)
        {
            ChromaMode.rainbowProg += 0.01f;
            welcomeLabel.ForeColor = ChromaMode.Rainbow(ChromaMode.rainbowProg);
            subLabel.ForeColor = ChromaMode.Rainbow(ChromaMode.rainbowProg);
            motdLabel.ForeColor = ChromaMode.Rainbow(ChromaMode.rainbowProg);
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

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion
    }
}