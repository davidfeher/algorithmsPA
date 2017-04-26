using Algorithms.sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfNumbers = 100;
            Random rand = new Random();
            List<int> myList = new List<int>();

            for (int i = 0; i < amountOfNumbers; i++)
            {
                myList.Add(rand.Next(1, 100));
            }

            BubbleSort.bubbleSort(myList);

            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }

            binary.BinarySearch search = new binary.BinarySearch();
            Console.WriteLine(search.Search(myList, 70));

            List<int> unsortedList = new List<int> { 4, 6, 1, 2, 9, 25, 3 };

            BubbleSort.bubbleSort(unsortedList);
            unsortedList.ForEach(Console.WriteLine);

            unsortedList = new List<int> { 4, 6, 1, 2, 9, 25, 3 };
            SelectionSort.selectionSort(unsortedList);
            unsortedList.ForEach(Console.WriteLine);

        }
    }
}
