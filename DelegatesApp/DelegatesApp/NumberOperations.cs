using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApp
{
    internal class NumberOperations
    {
        // Addition and Substraction delegates
        private delegate void performOperation(int x, int y);

        // Addition Method
        private static void addMethod(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        // Substraction Method
        private static void substractionMethod(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        // Create Addition, Substraction, MultiCast Delegates
        private static performOperation addDelegate = addMethod;
        private static performOperation subDelegate = substractionMethod;
        private static  performOperation combineDelegate = subDelegate + addDelegate;


        public void performAllOperations() {
            // Perform Operations using Delegates (Addition and Substraction)
            Console.WriteLine("Add Delegate : ");
            addDelegate(10, 5);
            Console.WriteLine("Substract Delegate : ");
            subDelegate(10, 5);

            // Perform Operations using Multi Cast Delegate
            Console.WriteLine("Multi Cast Delegate");
            combineDelegate(10, 5);
        }
    }
}
