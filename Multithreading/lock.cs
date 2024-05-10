using System;
using System.Threading;

class Program
{
    static int counter = 0;
    static object lockObject = new object();

    static void Main()
    {
        // Create and start multiple threads
        Thread[] threads = new Thread[5];
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(IncrementCounter);
            threads[i].Start();
        }

        // Wait for all threads to finish
        foreach (var thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("Counter: " + counter);
    }

    static void IncrementCounter()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (lockObject) // Lock to ensure thread-safe access
            {
                counter++;
            }
        }
    }
}
