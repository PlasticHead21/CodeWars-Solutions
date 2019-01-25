using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreTheySame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 144, 121, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };           
            Console.WriteLine(AreTheySame.RightSolution(a, b));
            AreTheySame.AggregateTest();
        }
    }

    class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            if(a.Length == 0 || b.Length == 0 || a == null || b == null) { return false; }
            var B = b.Select(x => Math.Sqrt(x)).ToArray();
            var A = a.Select(x => (double)x).ToArray();
            if(A.Except(B).ToArray().Length == 0) { return true; }
            return false;
        }

        public static bool RightSolution(int[] a, int[] b)
        {
            return a == null || b == null ? false : a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
        }
        public static void AggregateTest()
        {
            Console.WriteLine(Enumerable.Range(1, 3).Aggregate(0, (x, y)=> x + y));
        }
    }
}
