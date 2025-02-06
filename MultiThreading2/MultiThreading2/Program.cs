using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MultiThreading2
{
    internal class Program
    {
        private static Timer autoCloseTimer;

        static void Main()
        {
            autoCloseTimer = new Timer(15000);
            autoCloseTimer.Elapsed += delegate
            {
                Console.WriteLine("Closing the dialog automatically.");
                autoCloseTimer.Stop();
                Environment.Exit(0);
            };
            autoCloseTimer.AutoReset = false;

            Console.WriteLine("Dialog shown to the user.");
            autoCloseTimer.Start();
            Console.WriteLine("Press any key to close the dialog manually.");
            Console.ReadKey();
            Console.WriteLine("Dialog closed manually by the user.");
            autoCloseTimer.Stop();
        }
    }
}


