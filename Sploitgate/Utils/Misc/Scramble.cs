using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Main.Utils
{
    class Scramble
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
                var thisis = System.Reflection.Assembly.GetExecutingAssembly().Location;
                File.Move(thisis, RandomString(5) + ".exe");
                MainWindowName = true;
            }
        }

        public static void ChangeGUID()
        {
            //CodeRemovedBecauseFuckYou
        }
    }
}
