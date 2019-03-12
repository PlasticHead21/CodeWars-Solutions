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
            Console.WriteLine(Kata.MixedFraction("1/1"));
        }
    }

    public class Kata
    {
        public static string MixedFraction(string s)
        {
            int numerator, denominator, wholePart;
            string result = "";
            if (!SecurityCheck(s)) return s;
            var digits = ParsingDigits(s).ToArray();
            numerator = digits[0];
            denominator = digits[1];

            if (numerator == denominator) return "1"; 

            if (numerator == 0) return "0";

            if (numerator < 0 & denominator < 0)
            {
                numerator *= (-1);
                denominator *= (-1);
            }

            if (numerator < 0 )
            {
                numerator *= (-1);
                result += "-";
            }

            if (Gcd(numerator, denominator) == 1)
            {
                wholePart = numerator / denominator;
                numerator -= wholePart * denominator;
                if(wholePart == 0) return result += $"{numerator}/{denominator}";

                if (wholePart == 1 && numerator == 1 && denominator == 1)
                {
                    result += $"{wholePart}";
                }

                else
                {
                    return result += $"{wholePart} {numerator}/{denominator}";
                }
                
            }

            else if (Gcd(numerator, denominator) != 1 & numerator < denominator)
            {
                int gcd = Gcd(numerator, denominator);
                numerator /= gcd;
                denominator /= gcd;
                return denominator == 1 ? result += $"{numerator}" : result += $"{numerator}/{denominator}";
            }

            else if (Gcd(numerator, denominator) != 1 & numerator > denominator)
            {
                int gcd = Gcd(numerator, denominator);
                numerator /= gcd;
                denominator /= gcd;
                if (denominator == 1)
                {
                    wholePart = numerator;

                }
                else
                {
                    wholePart = numerator / denominator;
                    numerator -= wholePart * denominator;
                }
                
                return denominator == 1 ? result += $"{wholePart}" : result += $"{wholePart} {numerator}/{denominator}";
            }

            return "0";           
        }

        private static IEnumerable<int> ParsingDigits(string s)
        {
            int[] digits = s.Split(new char[] { '/' }).Select(Int32.Parse).ToArray();
            return digits;
        }

        private static int Gcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    int tmp = a;
                    a = b;
                    b = tmp;
                }
                b = b - a;
            }
            return a;
        }

        private static bool SecurityCheck(string s)
        {
            if (String.IsNullOrEmpty(s)) return false;
            var arr = ParsingDigits(s).ToArray();           
            if (s == "0/0") throw new DivideByZeroException();
            if (arr[1] == 0) throw new DivideByZeroException();
            else return true;
        }
    }
}
