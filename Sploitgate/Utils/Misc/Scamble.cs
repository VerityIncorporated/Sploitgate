using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sploitgate.Utils
{
    class Scamble
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static bool MainWindowName = false;

        public static void Title()
        {
            if (MainWindowName != true)
            {
                var thisis = Process.GetCurrentProcess();
                File.Move(thisis.ProcessName + ".exe", RandomString(50) + ".exe");
                MainWindowName = true;
            }
        }
    }
}
