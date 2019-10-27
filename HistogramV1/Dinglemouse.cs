using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Histogram
{
    public class Dinglemouse
    {
        public static string CreateHistogram(int[] results)
        {
            string hist = "-----------\n1 2 3 4 5 6\n";
            if (results.Max() == 0) return hist;

            for (int i = 0; i <= results.Max(); i++)
            {
                string line = "";
                for (int j = 0; j < results.Length; j++)
                {
                    if (i < results[j]) line += "# ";
                    else if (i == results[j] && i != 0) line += string.Format("{0,-2}", results[j]);
                    else line += "  ";
                }
                hist = line.TrimEnd() + "\n" + hist;
            }

            return hist;
        }
    }
}
