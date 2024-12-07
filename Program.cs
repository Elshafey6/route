
using System;

class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the number:- ");
        string x = Console.ReadLine();
        if (int.TryParse(x, out int num))
        {
            Console.WriteLine($"The number is {num}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }


    }
}