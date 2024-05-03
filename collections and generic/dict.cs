using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a Dictionary with string keys and int values
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // Adding key-value pairs to the Dictionary
        ages["abhinav"] = 30;
        ages["manan"] = 25;
        ages["Charlie"] = 35;

        // Iterating through the Dictionary
        Console.WriteLine("All ages:");
        foreach (var pair in ages)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }

        // Accessing values by key
        Console.WriteLine("Age of Abhinav: " + ages["abhinav"]);
        Console.WriteLine("Age of Dave: " + ages.GetValueOrDefault("Dave", -1)); // Using GetValueOrDefault to handle missing keys
    }
}
