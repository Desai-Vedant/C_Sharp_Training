using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApp
{
    internal class MultiDelegate
    {
        private delegate void simpleDelegate();

        private static void FirstMethod() {
            Console.WriteLine("Hello");
        }

        private static void SecondMethod()
        {
            Console.WriteLine("Welcome");
        }

        private static simpleDelegate firstdel = FirstMethod;
        private static simpleDelegate seconddel = SecondMethod;
        private static simpleDelegate combinedel = firstdel + seconddel;

        public void performAllOperations() {
            Console.WriteLine("First Delegate : ");
            firstdel();
            Console.WriteLine("Second Delegate :");
            seconddel();
            Console.WriteLine("Combined Delegate : ");
            combinedel();
        }
    }
}
