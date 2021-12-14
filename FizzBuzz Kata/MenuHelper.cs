using System;

namespace FizzBuzz_Kata
{
    public static class MenuHelper
    {
        public static void PrintMenu(ExerciseManager exerciseManager)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------- ");
            Console.WriteLine("|----- Choose a challenge -----|");
            Console.WriteLine("-------------------------------- ");

            foreach (var entry in exerciseManager.KnownExercises)
            {
                Console.WriteLine($"| {entry.Key} - {entry.Value}");
            }

            Console.WriteLine("| ... Or type any other number to exit");
            Console.Write("-------------------------------- \n >>> ");
        }

        public static void ShowReturnToMenuOption()
        {
            Console.WriteLine("\n\nPress enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
