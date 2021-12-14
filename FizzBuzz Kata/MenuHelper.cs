using System;

namespace FizzBuzz_Kata
{
    public static class MenuHelper
    {
        public static void PrintMenu()
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

        public static void ShowReturnToMenuOption()
        {
            Console.WriteLine("\n\nPress enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
