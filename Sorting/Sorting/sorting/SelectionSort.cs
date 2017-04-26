using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.sorting
{
    class SelectionSort
    {
        public static void selectionSort(List<int> array)
        {
            int minimum;
            for (var i = 0; i < array.Count; i++)
            {
                minimum = indexOfMinimum(array, i);
                Swap(array, i, minimum);
            }
        }

        private static void Swap(List<int> array, int firstIndex, int secondIndex)
        {
            var temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

        private static int indexOfMinimum(List<int> array, int startIndex)
        {
            int minValue = array[startIndex];
            int minIndex = startIndex;
            
            for (int i = minIndex+1; i < array.Count; i++)
            {
                if (array[i] < minValue)
                {
                    minIndex = i;
                    minValue = array[i];
                }
            }
            return minIndex;
        }
    }
}
