using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3));
        }
    }

    public class LongestConsecutives
    {
        public static String LongestConsecLinq(string[] s, int k)
        {
            return s.Length == 0 || s.Length < k || k <= 0 ? ""
              : Enumerable.Range(0, s.Length - k + 1)
                          .Select(x => string.Join("", s.Skip(x).Take(k)))
                          .OrderByDescending(x => x.Length)
                          .First();
        }

        public static string LongestConsec(string[] strarr, int k)
        {
            if (k > strarr.Length || strarr.Length == 0 || k <= 0)
            {
                return string.Empty;
            }

            var currentStr = string.Empty;
            for (var i = 0; i < strarr.Length; i++)
            {
                var str = string.Empty;
                for (var j = i; j < k + i && j < strarr.Length; j++)
                {
                    str += strarr[j];
                }

                if (currentStr.Length < str.Length)
                {
                    currentStr = str;
                }
            }

            return currentStr;
        }

    }
}
