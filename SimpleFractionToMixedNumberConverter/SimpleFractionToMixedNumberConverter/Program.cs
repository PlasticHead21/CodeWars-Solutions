using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace SimpleFractionToMixedNumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.MixedFraction("5/0"));
        }
    }

    public class Kata
    {
        public static string MixedFraction(string s)
        {
            int x = int.Parse(s.Split('/')[0]);
            int y = int.Parse(s.Split('/')[1]);
            Console.WriteLine(s);

            if (y == 0 && x == 0)
            {
                try
                {
                    int p = x / y;
                }
                catch (DivideByZeroException ex)
                {
                    throw new System.DivideByZeroException();
                }
            }

            if (x == 0)
            {
                return "0";
            }

            int wholePart = x % y;
            int ceo = (x - wholePart) / y;
            int denominator = GreatestCommonDenominator(x, y);

            if (Math.Abs(wholePart / denominator) < 1)
            {
                return ceo.ToString();
            }

            if (Math.Abs(ceo) < 1)
            {
                string znak = "";
                if (x < 0 && y < 0)
                {

                }
                else if (x < 0 || y < 0)
                {
                    znak = "-";
                }

                return string.Format("{0}{1}/{2}", znak, Math.Abs(wholePart / denominator),
                    Math.Abs(y / denominator));
            }

            return string.Format("{0} {1}/{2}", ceo, Math.Abs(wholePart / denominator), Math.Abs(y / denominator));
        }

        public static int GreatestCommonDenominator(int x, int y)
        {
            return y == 0 ? x : GreatestCommonDenominator(y, x % y);
        }
    }
}
