using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromInt32ToIPv4
{
    public static class IntToIPv4Converter
    {
        public static string UInt32ToIP(uint ip)
        {
            byte[] binary = BitConverter.GetBytes(ip);            
            return String.Join(".", binary.Reverse());
        }

        public static string UInt32ToIPLinq(uint ip)
          => string.Join(".", (new int[] { 24, 16, 8, 0 }).Select(e => ip >> e & 255));
    }
}
