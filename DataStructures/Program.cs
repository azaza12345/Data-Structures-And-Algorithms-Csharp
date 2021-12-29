using System;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = DoWorkAsync();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Task");
            }
        }

        static async Task DoWorkAsync()
        {
            await Task.Run(DoTask);
            Console.WriteLine("And Async");
        }
        private static void DoTask()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Async Task");
            }
        }
    }
}