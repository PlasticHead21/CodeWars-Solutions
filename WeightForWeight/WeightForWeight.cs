using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightForWeight
{
    class WeightForWeight
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeightSort.OrderWeight("103 123 4444 99 2000 180"));
            Console.WriteLine(WeightSort.OrderWeight("11 11 2000 10003 22 123 1234000 44444444 9999"));
            Console.WriteLine(WeightSort.OrderWeight("11 2 3 111 1111 4 22"));
        }
    }
    public class WeightSort
    {   
        public static string OrderWeight(string str)
        {
            return string.Join(" ", str.Split(' ')
            .OrderBy(n => n.ToCharArray()
            .Select(c => (int)char.GetNumericValue(c)).Sum())
            .ThenBy(n => n));
        }
    }
}
