using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistent_Bugger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Persist.Persistence(39)}");
            Console.WriteLine($"{Persist.Persistence(4)}");
            Console.WriteLine($"{Persist.Persistence(25)}");
            Console.WriteLine($"{Persist.Persistence(999)}");
        }
    }
    public class Persist
    {
        public static int Persistence(long n)
        {
            if(n < 10) { return 0; }
            int counter = 0;
            int x = 1;
            int temp = (int)n;
            while (true)
            {
                x *= temp % 10;
                temp /= 10;
                if (temp == 0 & x >= 10)
                {
                    temp = x;
                    x = 1;
                    counter++;
                }
                else if (temp == 0 & x < 10)
                {
                    counter++;
                    break;
                }
            }
            return counter;          
        }
        public int PersistenceLINQ(long n)
        {
            int count = 0;
            while (n > 9)
            {
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            }
            return count;
        }
    }
}
