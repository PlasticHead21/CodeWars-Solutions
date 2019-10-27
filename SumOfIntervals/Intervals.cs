using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfIntervals
{
    internal class Intervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            List<int> resultArr = new List<int>();
            foreach (var interval in intervals)
            {
                for (int i = interval.Item1; i < interval.Item2; i++)
                {
                    resultArr.Add(i);
                }
            }
            return resultArr.Distinct().Count();
        }
    }
}
