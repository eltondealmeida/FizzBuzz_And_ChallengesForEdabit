using System;

namespace FizzBuzz_Kata
{
    class Program
    {
        static void Main()
        {
            var manager = new ExerciseManager();
            manager.AddExercise(1, typeof(FizzBuzzExercise));
            manager.AddExercise(2, typeof(ReturnTheSumOfTwoNumbersExercise));
            manager.AddExercise(3, typeof(ConvertMinutesIntoSecondsExercise));
            manager.AddExercise(4, typeof(ReturTheNextNumberFromTheIntegerPassedExercise));
            manager.AddExercise(5, typeof(CircuitPowerExercise));

            while (true)
            {
                MenuHelper.PrintMenu(manager);

                var choice = ReadChoice();
                var couldRunExercise = manager.RunExerciseIfCodeIsValid(choice);

                if (!couldRunExercise)
                {
                    break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
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
    }
}
