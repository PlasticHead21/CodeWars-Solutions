using System;
using System.Linq;
using System.Collections.Generic;
namespace TripleTrouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.TripleDouble(1112, 122));

            Console.WriteLine(Kata.TripleDouble(451999277, 41177722899));
        }
    }
    public class Kata
    {
        public static int TripleDouble(long num1, long num2)
        {            
            string numberOne = num1.ToString();
            string numberTwo = num2.ToString();
            string mask = "000";
            for (int i = 0; i < 10; i++)
            {
                if (numberOne.Contains(mask) & numberTwo.Contains((Int32.Parse(mask) / 10).ToString())) { return 1; }
                mask = (Int32.Parse(mask) + 111).ToString();
            }
            return 0;
        }

        public static int TripleDoubleLinq(long num1, long num2)
        {
            return "0123456789".Count(number => num1.ToString().Contains(new string(number, 3)) && num2.ToString().Contains(new string(number, 2)));
        }

    }
}
