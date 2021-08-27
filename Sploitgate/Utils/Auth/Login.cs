﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;
using MetroFramework;
using MetroFramework.Forms;

namespace Sploitgate.Utils
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        static Account configUser;
        public static string configUsername;
        public static string configPassword;
        public static string configSubscription;

        static string name = "Sploitgate";
        static string ownerid = "TQ4uoezGrZ";
        static string secret = "8341fbc982b29898cbeb384fc9848b7e36d7551c9075563bc03ce0f03be7f1c5";
        static string version = "1.0";
        static bool Register = false;

        public static api Auth = new api(name, ownerid, secret, version);

        private void Login_Load(object sender, EventArgs e)
        {
            SetDNS("1.1.1.1");
            if (!File.Exists(Environment.CurrentDirectory + @"\Configs\"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Configs\");
            }

            if (!File.Exists(Environment.CurrentDirectory + @"\Configs\Account\"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Configs\Account\");
            }

            if (File.Exists(Environment.CurrentDirectory + @"\Configs\Account\AccountInformation.json"))
            {
                Shown += Login_Shown;
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            Hide();
            configUser = ConfigManager.LoadAccount(Environment.CurrentDirectory + @"\Configs\Account\AccountInformation.json");
            configUsername = Encryption.Decrypt(configUser.Username, WindowsIdentity.GetCurrent().User.Value);
            configPassword = Encryption.Decrypt(configUser.Password, WindowsIdentity.GetCurrent().User.Value);
            Auth.init();
            if (Auth.login(configUsername, configPassword))
            {
                Auth.log("Logged in");
                Loading main = new Loading();
                main.Show();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnsetDNS();
            Environment.Exit(0);
        }

        private void registerToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(registerToggleSwitch.Checked)
            {
                Register = true;
                continueButton.Location = new Point(117, 219);
                inviteTextBox.Visible = true;
                continueButton.Text = "Register";
            }
            else
            {
                Register = false;
                continueButton.Location = new Point(118, 186);
                inviteTextBox.Visible = false;
                continueButton.Text = "Login";
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if(!Register)
            {
                Auth.init();
                if (Auth.login(usernameTextBox.Text, passwordTextBox.Text))
                {
                    Hide();
                    CreateAutoLogin();
                    Auth.log("Logged in");
                    Loading main = new Loading();
                    main.Show();
                }
            }
            else
            {
                Auth.init();
                if (Auth.register(usernameTextBox.Text, passwordTextBox.Text, inviteTextBox.Text))
                {
                    Hide();
                    CreateAutoLogin();
                    Auth.log("Registered");
                    Form Load = new Loading();
                    Load.Show();
                }
            }
        }

        private void CreateAutoLogin()
        {
            if(!File.Exists(Environment.CurrentDirectory + @"\Configs\Account\AccountInformation.json"))
            {
                configUsername = Encryption.Encrypt(usernameTextBox.Text, WindowsIdentity.GetCurrent().User.Value);
                configPassword = Encryption.Encrypt(passwordTextBox.Text, WindowsIdentity.GetCurrent().User.Value);
                ConfigManager.SaveAccount(Environment.CurrentDirectory + @"\Configs\Account\AccountInformation.json");
            }
        }

        public static NetworkInterface GetActiveEthernetOrWifiNetworkInterface()
        {
            var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
                a => a.OperationalStatus == OperationalStatus.Up &&
                (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
                a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork"));

            return Nic;
        }

        public static void SetDNS(string DnsString)
        {
            string[] Dns = { DnsString };
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Description"].ToString().Equals(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = Dns;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }

        public static void UnsetDNS()
        {
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Description"].ToString().Equals(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = null;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }
    }
}
