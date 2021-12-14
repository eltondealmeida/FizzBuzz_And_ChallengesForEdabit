using System;
using FizzBuzz_Kata;

namespace FizzBuzz_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            FizzBuzz fizz = new FizzBuzz();
            ExercisesWithNumbers exercisesWithNumbers = new ExercisesWithNumbers();
        
            do
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

                choice = int.Parse(Console.ReadLine());
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
    }
}
