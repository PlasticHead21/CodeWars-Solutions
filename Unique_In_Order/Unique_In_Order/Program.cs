using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_In_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.UniqueInOrder("aaaaaccccDDDbbbBv"));
            foreach (var element in Kata.UniqueInOrderWithYield("aaaaaccccDDDbbbBv"))
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(Kata.Test("aaaaaccccDDDbbbBv"));
        }
    }
}
