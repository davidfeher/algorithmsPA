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

            myList.Sort();

            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }

            binary.BinarySearch search = new binary.BinarySearch();
            Console.WriteLine(search.Search(myList, 70));
            
        }
    }
}
