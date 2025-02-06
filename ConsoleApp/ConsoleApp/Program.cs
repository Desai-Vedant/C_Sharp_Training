using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static string[] getData()
        {
            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Favourite Saying : ");
            string saying = Console.ReadLine();
            string[] data = new string[2];
            data[0] = name;
            data[1] = saying;
            return data;
        }

        static void printData(string[] data)
        {
            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("<>", 20)));
            Console.WriteLine("Name : " + data[0]);
            Console.WriteLine("Favourite Saying : " + data[1]);
            Console.WriteLine(string.Concat(Enumerable.Repeat("<>", 20)));
            return;
        }
        static void Main(string[] args)
        {
            string[] person1 = getData();
            string[] person2 = getData();

            printData(person1);
            printData(person2);
        }
    }
}
