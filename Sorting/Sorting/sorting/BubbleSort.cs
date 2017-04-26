using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.sorting
{
    class BubbleSort
    {
        public static List<int> bubbleSort(List<int> unsortedList)
        {
           for (int i = 0; i < unsortedList.Count; i++)
            {
                for (int j = 1; j < (unsortedList.Count-i); j++)
                {
                    if (unsortedList[j-1] > unsortedList[j])
                    {
                        BubbleSort.Swap(unsortedList, j, j-1);
                    }
                }
            }
            return unsortedList;
        }

        private static void Swap(List<int> unsortedList, int firstIndex, int secondIndex)
        {
            int temp = unsortedList[secondIndex];
            unsortedList[secondIndex] = unsortedList[firstIndex];
            unsortedList[firstIndex] = temp;
        }
    }
}
