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
            Console.WriteLine(WeightSort.OrderWeight("103 123 4444 99 2000")); 
            Console.WriteLine(WeightSort.OrderWeight("11 11 2000 10003 22 123 1234000 44444444 9999")); 
        }
    }
    public class WeightSort
    {
        public static string OrderWeight(string str)
        {
            string[] strArr = str.Split(new char[] { ' ' });
            List<int> digits= new List<int>();
            int summ = 0;
            string a = default(string);
            for (int index = 0; index < strArr.Length -1; index++)
            {
                for (int i = 0; i < strArr[index].Length - 1; i++)
                {
                    digits.Add(Int32.Parse(strArr[index][i].ToString()));
                }
                if(summ < digits.Sum())
                {
                    summ = digits.Sum();
                    a += String.Join("", digits);
                }
                digits.Clear();
            }
            return "";
        }
    }
}
