using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_In_Order
{
    public static class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var retList = new List<T>();
            foreach (var element in iterable) if (!element.Equals(retList.LastOrDefault())) retList.Add(element);
            return retList;
        }

        public static IEnumerable<T> UniqueInOrderWithYield<T>(IEnumerable<T> iterable)
        {
            T previous = default(T);
            foreach (T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;
                }
            }
        }

        public static IEnumerable<T>Test<T>(IEnumerable<T> iterable)
        {
            var resultList = new List<T>();
            resultList = iterable.Distinct().ToList();
            return resultList;
        }
    }
}
