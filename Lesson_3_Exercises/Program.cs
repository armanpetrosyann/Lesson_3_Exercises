using System;

namespace Lesson_3_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Different numbers a, b, c are given. Make a block diagram and a program which are
            // 21.Will generate the value of the larger of the given numbers

            //Console.Write("a: ");
            //double firstNumber = Convert.ToDouble(Console.ReadLine());

            //Console.Write("b: ");
            //double secondNumber = Convert.ToDouble(Console.ReadLine());

            //Console.Write("c: ");
            //double thirdNumber = Convert.ToDouble(Console.ReadLine());

            //if (firstNumber > secondNumber && firstNumber > thirdNumber)
            //{
            //    Console.WriteLine($"{firstNumber} is big than {secondNumber} and {thirdNumber}");
            //}
            //else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            //{
            //    Console.WriteLine($"{secondNumber} is big than {firstNumber} and {thirdNumber}");
            //}
            //else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            //{
            //    Console.WriteLine($"{thirdNumber} is big than {firstNumber} and {secondNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Something gone wrong!");
            //}


            // 22.Will generate the value of the smaller of the given numbers

            //Console.Write("a: ");
            //double numberOne = Convert.ToDouble(Console.ReadLine());

            //Console.Write("b: ");
            //double numberTwo = Convert.ToDouble(Console.ReadLine());

            //Console.Write("c: ");
            //double numberThree = Convert.ToDouble(Console.ReadLine());

            //if (numberOne < numberTwo && numberOne < numberThree)
            //{
            //    Console.WriteLine($"{numberOne} is small than {numberTwo} and {numberThree}");
            //}
            //else if (numberTwo < numberOne && numberTwo < numberThree)
            //{
            //    Console.WriteLine($"{numberTwo} is small than {numberOne}  and  {numberThree}");
            //}
            //else if (numberThree < numberOne && numberThree < numberTwo)
            //{
            //    Console.WriteLine($"{numberThree} is small than {numberOne} and {numberTwo}");
            //}
            //else
            //{
            //    Console.WriteLine("Something gone wrong!");
            //}

            // if at least one of the given numbers is equal to one,
            // 23.it will return true otherwise false

            //const double fixNumber = 1;

            //Console.Write("a: ");
            //double numOne = Convert.ToDouble(Console.ReadLine());

            //Console.Write("b: ");
            //double numTwo = Convert.ToDouble(Console.ReadLine());

            //Console.Write("c: ");
            //double numThree = Convert.ToDouble(Console.ReadLine());

            //if (numOne == fixNumber || numTwo == fixNumber || numThree == fixNumber)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}


            // if at two of the given numbers is equal to two,
            // 24.it will return true otherwise false

            //const double fixTwoNumber = 2;

            //Console.Write("a: ");
            //double n1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("b: ");
            //double n2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("c: ");
            //double n3 = Convert.ToDouble(Console.ReadLine());

            //if (n1 == fixTwoNumber && n2 == fixTwoNumber && n3 != fixTwoNumber)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (n1 != fixTwoNumber && n2 == fixTwoNumber && n3 == fixTwoNumber)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (n1 == fixTwoNumber && n2 != fixTwoNumber && n3 == fixTwoNumber)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            // 25.if it is possible to construct a triangle with segments of
            // such length, then 'y=1' will be drawn, otherwise 'y=2'

            //Console.Write("a: ");
            //double sideA = Convert.ToDouble(Console.ReadLine());

            //Console.Write("b: ");
            //double sideB = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("c: ");
            //double sideC = Convert.ToDouble(Console.ReadLine());

            //if (sideA > 3 && sideB > 3 && sideC < 3)
            //{
            //    Console.WriteLine("'y=1'");
            //}
            //else if (sideA < 3 && sideB > 3 && sideC > 3)
            //{
            //    Console.WriteLine("'y=1'");
            //}
            //else if (sideA > 3 && sideB < 3 && sideC > 3)
            //{
            //    Console.WriteLine("'y=1'");
            //}
            //else
            //{
            //    Console.WriteLine("'y=2'");
            //}

            // 26.Will produce one if at least one of
            // the given numbers is even, otherwise 

            //Console.Write("a: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("b: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("c: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());

            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine(1);
            //}
            //else if (num2 % 2 == 0)
            //{
            //    Console.WriteLine(1);
            //}
            //else if (num3 % 2 == 0)
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    Console.WriteLine(2);
            //}

            // 27. ??
            // 28. ??

            // 29.The given numbers will be displayed in ascending order

            // Doesn't work correct

            int i;
            int[] a = new int[30];
            Console.Write("Enter the numbers of values to be Sort: ");

            int n = Convert.ToInt16(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the No " + i + ":");
                a[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (i = 1; i <= n; i++)
            {
                for (int j = 0; j <= n - 1; i++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.Write("Ascending Sort: ");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
    }
}
