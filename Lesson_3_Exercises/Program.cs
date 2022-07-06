using System;

namespace Lesson_3_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Different numbers a, b, c are given. Make a block diagram and a program which are

            // Will generate the value of the larger of the given numbers

            Console.Write("a: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());

            if (firstNumber > secondNumber || firstNumber > thirdNumber)
            {
                Console.WriteLine($"{firstNumber} is big than {secondNumber} and {thirdNumber}");
            }
            else if (secondNumber > firstNumber || secondNumber > thirdNumber)
            {
                Console.WriteLine($"{secondNumber} is big than {firstNumber} and {thirdNumber}");
            }
            else if (thirdNumber > firstNumber || thirdNumber > secondNumber)
            {
                Console.WriteLine($"{thirdNumber} is big than {firstNumber} and {secondNumber}");
            }

        }
    }
}
