using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NextBiggerNumberWithTheSameDigits
{

    public class Kata
    {
        public static long NextBiggerNumber(long n)
        {
            string left = n.ToString();
            string right;
            char piv = '\0';
            int pivIndex = -1;
            char big = '\0';
            int bigIndex = -1;
            for (int i = left.Length - 1; i > 0; i--)
            {
                if (left[i] > left[i - 1])
                {
                    pivIndex = i - 1;
                    piv = left[i - 1];
                    break;
                }
            }
            if (pivIndex == -1) { return pivIndex; }
            right = left.Substring(pivIndex);
            right = right.Remove(0, 1);
            for (int i = 0; i < right.Length; i++)
            {
                if (right[i] > piv)
                {
                    if (big == '\0' || right[i] < big)
                    {
                        bigIndex = i;
                        big = right[i];
                    }
                }
            }
            if (bigIndex == -1) { return bigIndex; }
            right = String.Join("", (right.Remove(bigIndex, 1) + piv).OrderBy(x => x).ToArray());
            left = left.Remove(pivIndex);
            string res = left + big + right;
            return Int64.Parse(res) == n ? -1 : Int64.Parse(res);
        }
        /// <summary>
        /// This method is too clever=)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long NextBiggerNumberBetter(long n)
        {
            String str = GetNumbers(n);
            for (long i = n + 1; i <= long.Parse(str); i++)
            {
                if (GetNumbers(n) == GetNumbers(i))
                {
                    return i;
                }
            }
            return -1;
        }
        public static string GetNumbers(long number)
        {
            return string.Join("", number.ToString().ToCharArray().OrderByDescending(x => x));
        }
        /// <summary>
        /// This method is clever and contain LINQ)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long NextBiggerNumberLinq(long n)
        {
            if (n < 10) return -1;
            string s = n + "";
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (s.Substring(i) != string.Concat(s.Substring(i).OrderByDescending(x => x)))
                {
                    var t = string.Concat(s.Substring(i).OrderBy(x => x));
                    var c = t.First(x => x > s[i]);
                    return long.Parse(s.Substring(0, i) + c + string.Concat(t.Where((x, y) => y != t.IndexOf(c))));
                }
            }
            return -1;
        }
    }  
}
