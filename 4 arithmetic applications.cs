using System;

public class Math
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Sub(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multi(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Div(int num1, int num2)
    {
        return num1 / num2;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Math math = new Math();
        int num1, num2;

        Console.WriteLine("Please enter 1st number = ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter 2nd number = ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum is = " + math.Add(num1, num2));
        Console.WriteLine("Difference is = " + math.Sub(num1, num2));
        Console.WriteLine("Product is = " + math.Multi(num1, num2));
        Console.WriteLine("Quotient is = " + math.Div(num1, num2));
    }
}