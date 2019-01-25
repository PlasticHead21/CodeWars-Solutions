using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerate_string
{
    public static class Kata
    {
        public static string Alphabet_Position(string text)
        {
            string resultStr = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            var arr = alphabet.ToArray();
            if (!string.IsNullOrEmpty(text))
            {
                foreach (char symbol in text)
                {
                    if (char.IsLetter(symbol))
                    {
                        resultStr += Convert.ToString(Array.IndexOf(arr, char.ToLower(symbol)) + 1);
                        resultStr += " ";
                    }
                }
                return text = resultStr.TrimEnd(' ');
            }
           else
            {
                throw new Exception(message: "Null or Empty");
            }
        }
        public static string ExcellentSolution(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
    }
}
