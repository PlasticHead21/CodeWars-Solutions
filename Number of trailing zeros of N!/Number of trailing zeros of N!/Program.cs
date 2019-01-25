using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_trailing_zeros_of_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.TrailingZeros(25));
        }
    }

    public static class Kata
    {
        public static int TrailingZeros(int n)
        {
            int traillingNums = 0;
            while(n >= 5)
            {
                n /= 5;
                traillingNums += n; 
            }
            return traillingNums;
        }
    }
}
