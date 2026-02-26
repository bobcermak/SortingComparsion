using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparsion.Algorithms
{
    public class BubbleSort<T> where T : IComparable<T>
    {
        //Bubble sort
        public static IEnumerable<T> Sort(IEnumerable<T> collection)
        {
            var list = collection.ToList();
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        (list[j], list[j + 1]) = (list[j + 1], list[j]);
                    }
                }
            }
            return list;
        }
    }
}