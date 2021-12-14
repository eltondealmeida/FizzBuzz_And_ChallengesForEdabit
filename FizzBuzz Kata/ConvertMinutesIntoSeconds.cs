using System;

namespace FizzBuzz_Kata
{
    public class ConvertMinutesIntoSeconds : IExercise
    {
        public void Run()
        {
            Console.WriteLine("Convert Minutes into Seconds.\n" +
            "Function that takes an integer minutes and converts it to seconds.\n" +
            "Examples:\n" +
            "convert(5) = 300\n" +
            "convert(3) = 180\n" +
            "convert(2) = 120\n" +
            "\n-------------------------------- \n\n");

            Console.Write("Write an integer to represent the minutes: \n>>> ");
            int minutes = int.Parse(Console.ReadLine());
            int seconds = minutes * 60;
            Console.WriteLine("\nThe minute(s): [" + minutes + "] is (are) equal to: [" + seconds + "] Seconds.");

            MenuHelper.PrintMenu();
        }
    }
}
