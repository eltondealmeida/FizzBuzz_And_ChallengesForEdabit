using System;

namespace FizzBuzz_Kata
{
    public class ReturTheNextNumberFromTheIntegerPassedExercise : IExercise
    {
        public void Run()
        {
            Console.WriteLine("Return the Next Number from the Integer Passed.\n" +
            "Function that takes a number as an argument, increments the number by +1 and returns the result.\n" +
            "Examples:\n" +
            "Addition(0) = 1\n" +
            "Addition(9) = 10\n" +
            "Addition(-3) = -2" +
            "\n-------------------------------- \n\n");

            Console.Write("Write an integer number: \n>>> ");
            int number = int.Parse(Console.ReadLine());
            int sum = number + 1;
            Console.WriteLine("The number: [" + number + "] + 1 is equal to: " + sum);

            MenuHelper.PrintMenu();
        }
    }
}
