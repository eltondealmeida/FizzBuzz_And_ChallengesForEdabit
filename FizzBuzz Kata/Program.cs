using System;

namespace FizzBuzz_Kata
{
    class Program
    {
        static void Main()
        {
            var manager = new ExerciseManager();
            manager.AddExercise<FizzBuzzExercise>(1);
            manager.AddExercise<ReturnTheSumOfTwoNumbersExercise>(2);
            manager.AddExercise<ConvertMinutesIntoSecondsExercise>(3);
            manager.AddExercise<ReturTheNextNumberFromTheIntegerPassedExercise>(4);
            manager.AddExercise<CircuitPowerExercise>(5);

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
