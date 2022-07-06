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

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"{firstNumber} is big than {secondNumber} and {thirdNumber}");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"{secondNumber} is big than {firstNumber} and {thirdNumber}");
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine($"{thirdNumber} is big than {firstNumber} and {secondNumber}");
            }
            else
            {
                Console.WriteLine("Something gone wrong!");
            }


            // Will generate the value of the smaller of the given numbers

            Console.Write("a: ");
            double numberOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double numberTwo = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
            double numberThree = Convert.ToDouble(Console.ReadLine());

            if (numberOne < numberTwo && numberOne < numberThree)
            {
                Console.WriteLine($"{numberOne} is small than {numberTwo} and {numberThree}");
            }
            else if (numberTwo < numberOne && numberTwo < numberThree)
            {
                Console.WriteLine($"{numberTwo} is small than {numberOne}  and  {numberThree}");
            }
            else if (numberThree < numberOne && numberThree < numberTwo)
            {
                Console.WriteLine($"{numberThree} is small than {numberOne} and {numberTwo}");
            }
            else
            {
                Console.WriteLine("Something gone wrong!");
            }

            // if at least one of the given numbers is equal to one,
            // it will return true otherwise false

            const double fixNumber = 1;

            Console.Write("a: ");
            double numOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double numTwo = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
            double numThree = Convert.ToDouble(Console.ReadLine());

            if (numOne == fixNumber || numTwo == fixNumber || numThree == fixNumber)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            // if at two of the given numbers is equal to two,
            // it will return true otherwise false

            const double fixTwoNumber = 2;

            Console.Write("a: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("c: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 == fixTwoNumber && n2 == fixTwoNumber && n3 != fixTwoNumber)
            {
                Console.WriteLine(true);
            }
            else if (n1 != fixTwoNumber && n2 == fixTwoNumber && n3 == fixTwoNumber)
            {
                Console.WriteLine(true);
            } else if (n1 == fixTwoNumber && n2 != fixTwoNumber && n3 == fixTwoNumber)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }
        }
    }
}
