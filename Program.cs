using System;
/*
Exercises C# Methods
Date: 27/10/2020
*/
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program to print largest of two numbers
            Console.WriteLine("Program to print largest of two numbers");
            Console.WriteLine("Enter the first number ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int secondnumber = int.Parse(Console.ReadLine());
            int max = GetMax(firstnumber, secondnumber);
            Console.WriteLine("Max number is: " + max);
        }

        public static int GetMax(int x,int y )
        {
            if (x > y)
                return x;
            else
                return y;
        }

    }
}
