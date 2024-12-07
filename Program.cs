using System;

class Person
{
    public string Name { get; set; }
}

class Program
{
    public static void Main(string[] args)
    {
        
        #region Q1: Write a program that allows the user to enter a number then print it.       
        Console.WriteLine("Enter the number: ");
        string? input = Console.ReadLine(); // Allow nullable input
        if (int.TryParse(input, out int num))
        {
            Console.WriteLine($"The number is {num}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        #endregion
        
        #region Q2:converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
        Console.Write("Enter a string: ");
        string input1 = Console.ReadLine();

        try
        {
            int number = int.Parse(input1); // Attempt to convert string to integer
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
        #endregion
        
        #region Q3:Perform a simple arithmetic operation with floating-point numbers And mention what will happen
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
        #endregion
        
        #region Q4:Extract a substring from a given string.
        Console.WriteLine("Enter the string you want to substring:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter number of sub: ");
        string nu = Console.ReadLine();
        int.TryParse(nu, out int N);
        if (text.Length >= N)
        {
            string Result = text.Substring(N);
            Console.WriteLine($"Substring result: {Result}");
        }
        else
        {
            Console.WriteLine($"The string is too short to perform a substring starting at index {N}.");
        }
        #endregion

        #region Q5:Assigning one value type variable to another and modifying the value of one variable and mention what will happen
        Console.WriteLine("Enter number 1: ");
        string a = Console.ReadLine();
        int.TryParse(a, out int A);
        Console.WriteLine("Enter number 2: ");
        string b = Console.ReadLine();
        int.TryParse(b, out int B);
        B = A;
        Console.WriteLine($"value of frist Number: {A}");
        Console.WriteLine($"value of second Number : {B}");
        B = 20;
        Console.WriteLine($"value of second Number After modify : {B}");
        #endregion

        #region Q6:Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
        Console.WriteLine("Enter name of frist person: ");
        string n1 = Console.ReadLine();
        Person p1 = new Person { Name = n1 };
        Console.WriteLine($"Name in person1: {p1.Name}");

        Person p2 = p1;
        Console.WriteLine($"Name in person2 : {p2.Name}");

        p2.Name = "Sabry";
        Console.WriteLine($"Modified Name in person2: {p2.Name}");

        Console.WriteLine($"Name in person1 after modifying person2: {p1.Name}");
        #endregion

        #region Q7:take two string variables and print them as one variable
        Console.WriteLine("Enter your first name: ");
        string Fname = Console.ReadLine();

        Console.WriteLine("Enter your last name: ");
        string Lname = Console.ReadLine();

        string Full_Name = Fname + " " + Lname;

        Console.WriteLine($"The full name is: {Full_Name}");
        #endregion

        //Q8
        //A value 1 will be assigned to d.

        //Q9
        //Print 6 1

        //Q10
        //Print 7 7

    }
}
