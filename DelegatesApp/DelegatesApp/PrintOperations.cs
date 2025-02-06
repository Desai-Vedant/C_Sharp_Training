using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApp
{
    internal class PrintOperations
    {
        private delegate void printOperations(string data);

        private static void consolePrint(string data)
        {
            Console.WriteLine(data);
        }

        private static void filePrint(string data)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "data.txt");
            File.WriteAllText(filePath, data);
            Console.WriteLine(filePath);
        }

        private static printOperations consoleDelegate = consolePrint;
        private static printOperations fileDelegate = filePrint;
        private static printOperations combinedDelegate = consoleDelegate + fileDelegate;

        public void perofrmAllOperations()
        {
            Console.WriteLine("Console Print Delegate : ");
            consoleDelegate("This is Sample Data");
            Console.WriteLine("File Print Delegate : ");
            fileDelegate("This is Sample Data");
            Console.WriteLine("Combined Print Delegate : ");
            combinedDelegate("This is Sample Data");
        }
    }
}
