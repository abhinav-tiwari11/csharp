using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create two threads
        Thread thread1 = new Thread(new ThreadStart(Thread1Method));
        Thread thread2 = new Thread(new ThreadStart(Thread2Method));

        // Start the threads
        thread1.Start();
        thread2.Start();

        // Wait for the threads to finish
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Both threads have completed.");
    }

    static void Thread1Method()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thread 1: " + i);
            // Simulate some work
            Thread.Sleep(1000);
        }
    }

    static void Thread2Method()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thread 2: " + i);
            // Simulate some work
            Thread.Sleep(1000);
        }
    }
}
