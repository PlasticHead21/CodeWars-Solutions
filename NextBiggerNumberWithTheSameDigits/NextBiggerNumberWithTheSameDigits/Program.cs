using System;
using System.Linq;
using System.Collections.Generic;

namespace NextBiggerNumberWithTheSameDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.NextBiggerNumberLinq(414));
            Console.WriteLine(Kata.NextBiggerNumberLinq(144));
            Console.WriteLine(Kata.NextBiggerNumberLinq(2017));
            Console.WriteLine(Kata.NextBiggerNumberLinq(513));
        }
    }
    
}
