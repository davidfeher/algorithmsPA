using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.binary
{
    class BinarySearch
    {

        public int Search(List<int> sortedList, int numberNeeded) 
        {
            int min = 0;
            int max = sortedList.Count - 1;
            
            while (min <= max)
            {
                int average = (min + max) / 2; ;
                int guess = sortedList[average];

                if (guess == numberNeeded)
                {
                    Console.WriteLine("We have found your number at index {0}", average);
                    return guess;
                }

                if (guess < numberNeeded)
                {
                    min = average + 1;
                }

                else 
                {
                    max = average - 1;
                }
            }

            return -1;
            
        }
        
    }
}
