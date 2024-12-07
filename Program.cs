/*
//1(take num and print)
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
*/
/*
//2(convert string to int)

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input); // Attempt to convert string to integer
            Console.WriteLine($"The converted number is: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: The string contains non-numeric characters and cannot be converted to an integer.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Error: No input was provided. Please enter a valid number.");
        }
    }
}
*/
//3(Opration)
/*
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        string num1 = Console.ReadLine();
        float.TryParse(num1, out float number1);

        Console.WriteLine("Enter the second number: ");
        string num2 = Console.ReadLine();
        float.TryParse(num2, out float number2);

        float result = number1 + number2;
        Console.WriteLine($"The Result of Addtion = {result}");

        result = number1 - number2;
        Console.WriteLine($"The Result of Sub = {result}");

        result = number1 * number2;
        Console.WriteLine($"The Result of Multplication = {result}");

        result = number1 / number2;
        Console.WriteLine($"The Result of Mode = {result}");


    }
}
*/
//4(substring from string)
/*
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string you want to substring:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter number of sub: ");
        string num = Console.ReadLine();
        int.TryParse(num, out int N);
        if (text.Length >= N)
        {
            string result = text.Substring(N); 
            Console.WriteLine($"Substring result: {result}");
        }
        else
        {
            Console.WriteLine($"The string is too short to perform a substring starting at index {N}.");
        }
    }
}
*/
//5(assign variable)
/*
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1: ");
        string a = Console.ReadLine();
        int.TryParse(a, out int A);
        Console.WriteLine("Enter number 2: ");
        string b=Console.ReadLine();
        int.TryParse(b, out int B);
        B = A;
        Console.WriteLine($"value of frist Number: {A}");
        Console.WriteLine($"value of second Number : {B}");
        B = 20;
        Console.WriteLine($"value of second Number After modify : {B}");

    }
}
*/
//6
/*
using System;

class Program
{
    class Person
    {
        public string Name { get; set; }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter name of frist person: ");
        string n1=Console.ReadLine();
        Person p1 = new Person { Name =n1 };
        Console.WriteLine($"Name in person1: {p1.Name}");

        Person p2 = p1;
        Console.WriteLine($"Name in person2 : {p2.Name}");

        p2.Name = "Sabry";
        Console.WriteLine($"Modified Name in person2: {p2.Name}");

        Console.WriteLine($"Name in person1 after modifying person2: {p1.Name}");
    }
}
*/
//7(Full name)
/*
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name: ");
        string Fname = Console.ReadLine();

        Console.WriteLine("Enter your last name: ");
        string Lname = Console.ReadLine();

        string Full_Name = Fname + " " + Lname;

        Console.WriteLine($"The full name is: {Full_Name}");
    }
}
*/
/*
//8
using System;

class Program
{
    public static void Main(string[] args)
    {
        int d;
        d = Convert.ToInt32(!(30<20));
        Console.WriteLine(d);
    }
}
//A value 1 will be assigned to d.
*/

//9
/*
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(13 / 2 + " " + 13 % 2);
    }
}

//Print 6 1
*/
//10
/*
using System;

class Program
{
    public static void Main(string[] args)
    {
        int num = 1, z = 5;


        if (!(num <= 0))
            Console.WriteLine(++num + z++ + " " + ++z);
        else
            Console.WriteLine(--num + z-- + " " + --z);

    }
}
//Print 7 7
*/