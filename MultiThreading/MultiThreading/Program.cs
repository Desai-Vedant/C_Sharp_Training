using System;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace MultiThreading
{
    internal class Program
    {
        private static System.Timers.Timer autoCloseTimer;

        static async Task LongRunningOperation(CancellationToken token, int timeout)
        {
            for (int i = 1; i <= timeout; i++)
            {
                token.ThrowIfCancellationRequested(); // Check for cancellation

                await Task.Delay(1000, token); // Delay supports cancellation
                Console.WriteLine($"In Progress...");
            }

            Console.WriteLine("Operation completed.");
        }

        static async Task Main()
        {
            var cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            autoCloseTimer = new System.Timers.Timer(5000);
            autoCloseTimer.Elapsed += delegate
            {
                Console.WriteLine("Cancelling the Operation Because it's taking too long to Complete.");
                cts.Cancel(); // Request cancellation
            };
            autoCloseTimer.AutoReset = false;


            Random randomgen = new Random();

            Task longRunningTask = LongRunningOperation(token, randomgen.Next(1,10));
            autoCloseTimer.Start();

            Console.WriteLine("Press any key to cancel...");
            Console.ReadKey();
            cts.Cancel(); // Request cancellation

            try
            {
                await longRunningTask;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation was canceled.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}
