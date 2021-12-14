using System;

namespace FizzBuzz_Kata
{
    public class CircuitPowerExercise : IExercise
    {
        public void Run()
        {
            Console.WriteLine("Power Calculator.\n" +
            "Function that takes voltage and current and returns the calculated power.\n" +
            "Examples:\n" +
            "CircuitPower(230, 10) = 2300\n" +
            "CircuitPower(110, 3) = 330\n" +
            "CircuitPower(480, 20) = 9600" +
            "\n-------------------------------- \n\n");

            Console.Write("Write the voltage, a space and the current (ex.: 230 10): \n>>> ");
            string[] aux = Console.ReadLine().Split(' ');
            int voltage = int.Parse(aux[0]);
            int current = int.Parse(aux[1]);
            int multiply = voltage * current;
            Console.WriteLine("\nCalculated power of the voltage: [" + voltage + "] and current: [" + current + "] is equal to: " + multiply);

            MenuHelper.PrintMenu();
        }
    }
}
