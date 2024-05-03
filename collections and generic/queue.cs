using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a Queue of integers
        Queue<int> numbers = new Queue<int>();

        // Enqueueing elements to the Queue
        numbers.Enqueue(1);
        numbers.Enqueue(2);
        numbers.Enqueue(3);

        // Dequeueing elements from the Queue
        Console.WriteLine("Dequeued elements:");
        while (numbers.Count > 0)
        {
            Console.WriteLine(numbers.Dequeue());
        }
    }
}
