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
                var exerciseName = GetExerciseName(entry.Value);
                Console.WriteLine($"| {entry.Key} - {exerciseName}");
            }

            Console.WriteLine("| ... Or type any other number to exit");
            Console.Write("-------------------------------- \n >>> ");
        }

        public static void ShowReturnToMenuOption()
        {
            Console.WriteLine("\n\nPress enter to return to the menu.");
            Console.ReadLine();
        }

        private static string GetExerciseName(Type exerciseType)
        {
            const string suffix = "Exercise";
            var name = exerciseType.Name;

            if (name.EndsWith(suffix))
            {
                name = name[0..^suffix.Length];
            }

            return name;
        }
    }
}
