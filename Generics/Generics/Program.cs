using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        private static void printArray<T>(T[] inputArray)
        {
            foreach (T elem in inputArray)
            {
                Console.WriteLine(elem);
            }
        }

        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            string[] stringArray = {"Rohit", "Virat", "Jasprit", "Hardik" };

            printArray(numArray);
            printArray(stringArray);
        }
    }
}
