using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgram
{
    internal class Program
    {
        static async Task Main()
        {
            var cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Task longRunningTask = LongRunningOperation(token);

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

        static async Task LongRunningOperation(CancellationToken token)
        {
            for (int i = 1; i <= 10; i++)
            {
                token.ThrowIfCancellationRequested(); // Check for cancellation

                Console.WriteLine($"Processing {i}/10...");
                await Task.Delay(1000, token); // Delay supports cancellation
            }

            Console.WriteLine("Operation completed.");
        }
    }
}

