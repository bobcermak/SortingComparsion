using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparsion.Algorithms
{
    public class QuickSort<T> where T : IComparable<T>
    {
        public static T[] Sort(T[] arr)
        {
            
            T[] result = new T[arr.Length];
            Array.Copy(arr, result, arr.Length);

            QuickSortAlgorithm(result, 0, result.Length - 1);
            return result;
        }
        private static void QuickSortAlgorithm(T[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSortAlgorithm(arr, low, pivotIndex - 1);
                QuickSortAlgorithm(arr, pivotIndex + 1, high);
            }
        }
        private static int Partition(T[] arr, int low, int high)
        {
            T pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }
        private static void Swap(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}