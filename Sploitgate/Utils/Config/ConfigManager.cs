using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Utils
{
    class ConfigManager
    {
        public static Config LoadSettings(string filePath)
        {
            var contents = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Config>(contents);
        }

        public static void SaveSettings(string filePath)
        {
            var Settings = new Config
            {
                Triggerbot = Main._TriggerbotEnabled,
                ShottySnipers = Main._ShottySnipers,
                AntiRecoil = Main._AntiRecoil,
                Humanization = Main._Humanized,
                AntiRecoilStrength = Main.AntiRecoilStength,
                ShotDelay = Main.ShotDelay,
                Chromamode = Main._ChromamodeEnabled,
                Clicking = Main.ClickingType,
                Quickscope = Main._QuickScope,
            };
            File.WriteAllText(filePath, JsonConvert.SerializeObject(Settings, Formatting.Indented));
        }

        public static Resolution LoadResolution(string filePath)
        {
            var contents = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Resolution>(contents);
        }

        public static void SaveResolution(string filePath)
        {
            var Resolution = new Resolution
            {
                Top = Loading.top,
                Left = Loading.left,
                Bottom = Loading.bottom,
                Right = Loading.right,
            };
            File.WriteAllText(filePath, JsonConvert.SerializeObject(Resolution, Formatting.Indented));
        }

        public static Account LoadAccount(string filePath)
        {
            var contents = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Account>(contents);
        }

        public static void SaveAccount(string filePath)
        {
            var Account = new Account
            {
                Username = Login.configUsername,
                Password = Login.configPassword,
            };
            File.WriteAllText(filePath, JsonConvert.SerializeObject(Account, Formatting.Indented));
        }
    }
}
