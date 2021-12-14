using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz_Kata
{
    public static class ExerciseManagerBuilder
    {
        public static ExerciseManager ScanAssemblyAndBuild()
        {
            var manager = new ExerciseManager();
            var code = 1;

            foreach (var type in FindAllExerciseTypes())
            {
                manager.AddExercise(code++, type);
            }

            return manager;
        }

        private static IEnumerable<Type> FindAllExerciseTypes()
        {
            var allClassesInAssembly = typeof(ExerciseManagerBuilder).Assembly.GetTypes().Where(type => type.IsClass);
            var exerciseTypes = allClassesInAssembly.Where(type => typeof(IExercise).IsAssignableFrom(type));
            return exerciseTypes.ToList();
        }
    }
}
