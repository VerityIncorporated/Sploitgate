using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Main.Utils
{
    public partial class Loading : MetroForm
    {
        public Loading()
        {
            InitializeComponent();
        }

        public static Utils.Resolution userSettings;
        public static int top;
        public static int left;
        public static int bottom;
        public static int right;

        private void Loading_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + @"\Configs\Resolution.json"))
            {
                Shown += Loading_Shown;
            }
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            Hide();
            userSettings = ConfigManager.LoadResolution(Environment.CurrentDirectory + @"\Configs\Resolution.json");
            Form MainForm = new Main();
            MainForm.Show();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (topTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill in All Parameters", "Main", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    top = Convert.ToInt32(topTextBox.Text);
                }

                if (leftTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill in All Parameters", "Main", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    left = Convert.ToInt32(leftTextBox.Text);
                }

                if (bottomTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill in All Parameters", "Main", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    bottom = Convert.ToInt32(bottomTextBox.Text);
                }

                if (rightTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill in All Parameters", "Main", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    right = Convert.ToInt32(rightTextBox.Text);
                }
                Hide();
                ConfigManager.SaveResolution(Environment.CurrentDirectory + @"\Configs\Resolution.json");
                Form MainForm = new Main();
                MainForm.Show();
            }
            catch(FormatException)
            {
                MessageBox.Show("Please Fill in All Parameters with Numbers Only", "Main", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/EMTCslf-FxY");
        }

        private void Loading_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
