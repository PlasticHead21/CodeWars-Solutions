using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestScoringWord
{
    public static class Kata
    {
        public static string High(string s)
        {
            string result = " ";
            foreach(string word in s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (word.Sum(x => x - 'a' + 1) > result.Sum(x => x - 'a' + 1))
                {
                    result = word;
                }
            }
            return result;
        }

        public static string HighLinq(string s) => s.Split(' ').OrderBy(w => w.Sum(c => c - 'a' + 1)).Last();
    }
}
