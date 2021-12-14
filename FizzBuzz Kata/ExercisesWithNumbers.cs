using System;

namespace FizzBuzz_Kata
{
    public class ExercisesWithNumbers
    {
        public void ReturnTheSumOfTwoNumbers()
        {
        }

        public void ConvertMinutesIntoSeconds()
        {
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
