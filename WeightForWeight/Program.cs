using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightForWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeightSort.OrderWeight("103 123 4444 99 2000 180"));
            Console.WriteLine(WeightSort.OrderWeight("11 11 2000 10003 22 123 1234000 44444444 9999"));
        }
    }
    public class WeightSort
    {   
        public static string OrderWeight(string str)
        {            
            string[] strArr = str.Split(new char[] { ' ' });
            List<int> digits = new List<int>();
            List<Weight> weightList = new List<Weight>();
            string res = default(string);
            for (int index = 0; index < strArr.Length; index++)
            {
                for (int i = 0; i < strArr[index].Length; i++)
                {
                    digits.Add(Int32.Parse(strArr[index][i].ToString()));
                }
                
                weightList.Add(new Weight { Digit = digits.Sum(), Svalue = String.Join("", digits) });
                digits.Clear();
            }
            weightList = weightList.OrderBy(x => x.Digit).ToList();
            foreach (var item in weightList)
            {
                res += item.Svalue + " ";
            }
            return res.Trim(new char[] { ' ' });
        }
    }
}
