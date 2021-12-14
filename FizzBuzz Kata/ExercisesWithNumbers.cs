using System;

namespace FizzBuzz_Kata
{
    public class ExercisesWithNumbers
    {
        public void ReturnTheSumOfTwoNumbers()
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

        public void ConvertMinutesIntoSeconds()
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

        public void ReturTheNextNumberFromTheIntegerPassed()
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

        public void CircuitPower()
        {
            Console.WriteLine("Power Calculator.\n" +
            "Function that takes voltage and current and returns the calculated power.\n" +
            "Examples:\n" +
            "CircuitPower(230, 10) = 2300\n" +
            "CircuitPower(110, 3) = 330\n" +
            "CircuitPower(480, 20) = 9600" +
            "\n-------------------------------- \n\n");

            Console.Write("Write the voltage, a space and the current (ex.: 230 10): \n>>> ");
            string[] aux = Console.ReadLine().Split(' ');
            int voltage = int.Parse(aux[0]);
            int current = int.Parse(aux[1]);
            int multiply = voltage * current;
            Console.WriteLine("\nCalculated power of the voltage: [" + voltage + "] and current: [" + current + "] is equal to: " + multiply);

            MenuHelper.PrintMenu();
        }
    }
}
