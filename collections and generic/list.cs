using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a List of integers
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

        // Accessing elements from the list
        Console.WriteLine("First element: " + numbers[0]); // Accessing elements by index
        Console.WriteLine("Last element: " + numbers[numbers.Count - 1]); // Accessing last element

        // Adding elements to the list
        numbers.Add(6); // Adding a new element to the end of the list
        numbers.Insert(2, 7); // Inserting an element at index 2

        // Iterating through the list
        Console.WriteLine("All elements:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        // Accessing non-existing index
        Console.WriteLine(numbers[10]); // This line will throw an ArgumentOutOfRangeException
    }
}
