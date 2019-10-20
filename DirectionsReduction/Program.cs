using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectionsReduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] c = new string[] { "NORTH" };
            string[] e = { "EAST", "EAST", "WEST", "NORTH", "WEST", "EAST", "EAST", "SOUTH", "NORTH", "WEST" };
            string[] d = { "NORTH", "EAST", "NORTH", "EAST", "WEST", "WEST", "EAST", "EAST", "WEST", "SOUTH" };


            Array.ForEach(DirReduction.Reduction(d), (element) => Console.WriteLine(element));
        } 
    }
}
