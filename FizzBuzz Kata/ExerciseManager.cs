using System;
using System.Collections.Generic;

namespace FizzBuzz_Kata
{
    public class ExerciseManager
    {
        private readonly Dictionary<int, Type> knownExercises = new();

        public void AddExercise(int code, Type exerciseType)
        {
            knownExercises.Add(code, exerciseType);
        }

        public bool RunExerciseIfCodeIsValid(int code)
        {
            if (!knownExercises.ContainsKey(code))
            {
                return false;
            }

            RunExercise(code);
            return true;
        }

        private void RunExercise(int code)
        {
            var exerciseType = knownExercises[code];
            var instance = Activator.CreateInstance(exerciseType) as IExercise;
            instance.Run();
        }
    }
}
