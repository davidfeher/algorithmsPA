using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.sorting
{
    class BubbleSort
    {
        public static List<int> quickSort(List<int> unsortedList)
        {
           for (int i = 0; i < unsortedList.Count; i++)
            {
                for (int j = 1; j < (unsortedList.Count-i); j++)
                {
                    int temp;
                    if (unsortedList[j-1] > unsortedList[j])
                    {
                        temp = unsortedList[j-1];
                        unsortedList[j-1] = unsortedList[j];
                        unsortedList[j] = temp;
                    }
                }
            }
            return unsortedList;
        }
    }
}
