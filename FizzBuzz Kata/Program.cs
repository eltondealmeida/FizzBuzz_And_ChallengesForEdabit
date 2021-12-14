﻿using System;

namespace FizzBuzz_Kata
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                MenuHelper.PrintMenu();

                switch (ReadChoice())
                {
                    case 1:
                        new FizzBuzz().Run();
                        break;

                    case 2:
                        new ReturnTheSumOfTwoNumbers().Run();
                        break;

                    case 3:
                        new ConvertMinutesIntoSeconds().Run();
                        break;

                    case 4:
                        new ReturTheNextNumberFromTheIntegerPassed().Run();
                        break;

                    case 5:
                        new CircuitPower().Run();
                        break;

                    default:
                        return;
                }
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
