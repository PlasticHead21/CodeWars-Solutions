using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasya_Clerk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Line.Tickets(new int[] { 25, 100 }));
        }

        public static class Line
        {
            public static string Tickets(int[] peopleInLine)
            {
                const int PRICE = 25;
                int change = 0;
                foreach(int cash in peopleInLine)
                {
                    if (cash == PRICE)
                    {
                        change += cash;
                    }
                    else if (change - cash >= 0)
                    {
                        change += PRICE;
                        change -= (cash - PRICE);
                    }
                    else
                    {
                        change -= cash;
                        break;
                    } 
                }
                return change >= 0 ? "YES" : "NO"; 
            }
        }
    }
}
