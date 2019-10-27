using System;

namespace SumOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Intervals.SumIntervals(new (int, int)[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) });
            res = Intervals.SumIntervals(new (int, int)[] { (1, 2), (6, 10), (11, 15) });
            Console.WriteLine(res);
        }
    }
}
