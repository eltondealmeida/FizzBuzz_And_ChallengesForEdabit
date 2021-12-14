using System;
using FizzBuzz_Kata;

namespace FizzBuzz_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();

                switch (ReadChoice())
                {
                    case 1:
                        new FizzBuzz().fizzBuzz();
                        break;

                    case 2:
                        new ExercisesWithNumbers().ReturnTheSumOfTwoNumbers();
                        break;

                    case 3:
                        new ExercisesWithNumbers().ConvertMinutesIntoSeconds();
                        break;

                    case 4:
                        new ExercisesWithNumbers().ReturTheNextNumberFromTheIntegerPassed();
                        break;

                    case 5:
                        new ExercisesWithNumbers().CircuitPower();
                        break;

                    default:
                        return;
                }
            }
        }

        private static int ReadChoice()
        {
            while (true)
            {
                var input = Console.ReadLine();
                input = input.Trim();

                if (int.TryParse(input, out var choice))
                {
                    return choice;
                }

                Console.WriteLine("The choice must be a number. Please, try again: ");
            }
        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------- ");
            Console.WriteLine("|---- Choose the challenges ----|");
            Console.WriteLine("-------------------------------- ");
            Console.WriteLine("| 1 - FizzBuzz                  |");
            Console.WriteLine("| 2 - SumOfTwoNumbers           |");
            Console.WriteLine("| 3 - ConvertMinutesintoSeconds |");
            Console.WriteLine("| 4 - NextNumberInteger         |");
            Console.WriteLine("| 5 - CalculatedPower           |");
            Console.WriteLine("| 6 - Exit                      |");
            Console.Write("-------------------------------- \n >>> ");
        }
    }
}
