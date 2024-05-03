using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a HashSet of strings
        HashSet<string> colors = new HashSet<string>();

        // Adding elements to the HashSet
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");

        // Iterating through the HashSet
        Console.WriteLine("All colors:");
        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

        // Checking for existence
        Console.WriteLine("Contains 'Red': " + colors.Contains("Red"));
        Console.WriteLine("Contains 'Yellow': " + colors.Contains("Yellow"));
    }
}
