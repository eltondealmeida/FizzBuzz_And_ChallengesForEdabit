using System;
using FizzBuzz_Kata;

namespace FizzBuzz_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
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

                choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    Console.Clear();
                    fizz.fizzBuzz();
                }
                else if (choose == 2)
                {
                    Console.Clear();
                    exercisesWithNumbers.ReturnTheSumOfTwoNumbers(); 
                }
                else if (choose == 3)
                {
                    Console.Clear();
                    exercisesWithNumbers.ConvertMinutesIntoSeconds();
                }
                else if (choose == 4)
                {
                    Console.Clear();
                    exercisesWithNumbers.ReturTheNextNumberFromTheIntegerPassed();
                }
                else if (choose == 5)
                {
                    Console.Clear();
                    exercisesWithNumbers.CircuitPower();
                }
 
            } while (choose != 6);
        }
    }
}
