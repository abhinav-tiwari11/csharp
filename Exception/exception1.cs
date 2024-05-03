using System;

class Program
{
    static void Main()
    {
        try
        {
            
            int result = Divide(10, 0);
            Console.WriteLine("Result: " + result); // This line won't execute if an exception occurs
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("This block always executes, regardless of whether an exception occurred or not.");
        }
    }

    static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }
}
