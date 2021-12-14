using System;

namespace FizzBuzz_Kata
{
    public class ReturnTheSumOfTwoNumbers : IExercise
    {
        public void Run()
        {
            Console.WriteLine("Return the Sum of Two Numbers.\n" +
            "Function that takes two numbers as arguments and return their sum.\n" +
            "Examples:\n" +
            "Sum(3, 2) = 5\n" +
            "Sum(-3, -6) = -9\n" +
            "Sum(7, 3) = 10" +
            "\n-------------------------------- \n\n");

            Console.Write("Write the first number, a space and the second number (ex.: 1 2): \n>>> ");
            string[] aux = Console.ReadLine().Split(' ');
            int a = int.Parse(aux[0]);
            int b = int.Parse(aux[1]);
            int sum = a + b;
            Console.WriteLine("\nSum of the: [" + a + "] and [" + b + "] is equal to: " + sum);

            MenuHelper.PrintMenu();
        }
    }
}
