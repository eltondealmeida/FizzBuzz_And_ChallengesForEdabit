using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FizzBuzz_Kata
{
    public class ExerciseManager
    {
        private readonly Dictionary<int, Type> knownExercises = new();

        public IReadOnlyDictionary<int, Type> KnownExercises => new ReadOnlyDictionary<int, Type>(knownExercises);

        public void AddExercise(int code, Type exerciseType)
        {
            ThrowIfInvalidType(exerciseType);
            knownExercises.Add(code, exerciseType);
        }

        public void AddExercise<TExercise>(int code)
            where TExercise : IExercise
        {
            knownExercises.Add(code, typeof(TExercise));
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

        private void ThrowIfInvalidType(Type exerciseType)
        {
            if (!exerciseType.IsAssignableTo(typeof(IExercise)))
            {
                throw new InvalidOperationException($"Type {exerciseType.Name} does not implement interface IExercise.");
            }
        }
    }
}
