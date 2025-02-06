using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApp
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Operations on Numbers : \n");
            NumberOperations numOps = new NumberOperations();
            numOps.performAllOperations();

            Console.WriteLine("\n\nOperations on Printing : \n");
            PrintOperations printOps = new PrintOperations();
            printOps.perofrmAllOperations();

            Console.WriteLine("\n\nSimple Multi Delegate Example : \n");
            MultiDelegate multiDelegate = new MultiDelegate();
            multiDelegate.performAllOperations();
        }
    }
}
