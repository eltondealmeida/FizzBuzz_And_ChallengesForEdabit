using System;

namespace FizzBuzz_Kata
{
    public class FizzBuzzExercise : IExercise
    {
        public void Run()
        {
            Console.WriteLine("Method that prints the numbers from 1 to 100, separated by newlines.\n" +
             "Instead of numbers divisible by 3, the method returns 'Fizz'.\n" +
             "Instead of numbers divisible by 5, the method returns 'Buzz'.\n" +
             "Instead of numbers divisible by 3 and 5, the method returns 'FizzBuzz'." +
             "\n\n-------------------------------- \n");

            for (int i = 1; i <= 100; i++)
            {
                string result = "";
                if (i % 3 == 0)
                {
                    result = "Fizz";
                }
                if (i % 5 == 0)
                {
                    result = "Buzz";
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result = "FizzBuzz";
                }
                if (result.Length == 0)
                {
                    result = i.ToString();
                }
                Console.WriteLine(result);
            }
        }
    }
}
