using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sploitgate.Utils
{
    class ChromaMode
    {
        public static float rainbowProg = 0f;

        public static Color Rainbow(float progress)
        {
            var div = Math.Abs(progress % 1) * 6;
            var ascending = (int)(div % 1 * 255);
            var descending = 255 - ascending;

            switch ((int)div)
            {
                case 0:
                    return Color.FromArgb(255, 255, ascending, 0);

                case 1:
                    return Color.FromArgb(255, descending, 255, 0);

                case 2:
                    return Color.FromArgb(255, 0, 255, ascending);

                case 3:
                    return Color.FromArgb(255, 0, descending, 255);

                case 4:
                    return Color.FromArgb(255, ascending, 0, 255);

                default:
                    return Color.FromArgb(255, 255, 0, descending);
            }
        }
    }
}
