using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrintEvenNumbers();
        }

        static void PrintEvenNumbers()
        {
            int input = 10;
            int i = 1;

            while (i < input) 
            {
                bool result = ((i / 2) == 0);
                if(!result)
                {
                  
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
