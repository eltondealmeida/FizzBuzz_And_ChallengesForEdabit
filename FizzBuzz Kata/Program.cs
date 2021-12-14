using System;
using FizzBuzz_Kata;

namespace FizzBuzz_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            var fizz = new FizzBuzz();
            var exercisesWithNumbers = new ExercisesWithNumbers();
        
            do
            {
                PrintMenu();

                choice = ReadChoice();

                if (choice == 1)
                {
                    Console.Clear();
                    fizz.fizzBuzz();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    exercisesWithNumbers.ReturnTheSumOfTwoNumbers();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    exercisesWithNumbers.ConvertMinutesIntoSeconds();
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    exercisesWithNumbers.ReturTheNextNumberFromTheIntegerPassed();
                }
                else if (choice == 5)
                {
                    Console.Clear();
                    exercisesWithNumbers.CircuitPower();
                }

            } while (choice != 6);
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
