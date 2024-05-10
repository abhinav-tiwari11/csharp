using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create a thread and pass parameter to it
        Thread thread = new Thread(new ParameterizedThreadStart(TestMethod));
        thread.Start(5); // Pass parameter 5 to the thread

        Console.WriteLine("Main thread is doing something else...");

        // Wait for the thread to finish
        thread.Join();

        Console.WriteLine("Thread finished.");
    }

    static void TestMethod(object obj)
    {
        int count = (int)obj; // Convert parameter to int
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Thread: " + i);
            Thread.Sleep(1000);
        }
    }
}
