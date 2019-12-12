using System;
using System.Linq;

namespace PersonalMathsCalculator
{ 
        class Program
        {
            static void Main(string[] args)
            {
                bool homePage = true;

                while (homePage)
                {
                    homePage = MathematicsTools();
                }
            }

            public static bool MathematicsTools()
            {
                Console.WriteLine("This is a maths calculator, it has many fuctions as shown below. " +
                    "\nEnter the number of the function that you would like to use. " +
                    "\nClick enter to continue \n\n");
                Console.ReadKey();

                Console.WriteLine("1) To use +, -, * and / calculations ");
                Console.WriteLine("2) To use Square root ");
                Console.WriteLine("3) To use power calculation ");
                Console.WriteLine("4) To use Max and Min");
                string result = Console.ReadLine();

                if (result == "1")
                {
                    AddSubMultDiv();
                    return true;
                }

                else if (result == "2")
                {
                    SquareRoot();
                    return true;
                }

                else if (result == "3")
                {
                    PowerCalcualtor();
                    return true;
                }
                else if (result == "4")
                {
                    MaxAndMin();
                    return true;
                }
                else
                {
                    return true;

                }
            }

            public static void AddSubMultDiv()
            {
                string opp = "";

                int num1, num2;

                Console.WriteLine("\n This program will help you calculate any arithmetic calculation using the 4 operations +, -, * & /" +
                    "Press Enter to continue");
                Console.ReadKey();

                Console.WriteLine("\n Enter two numbers that you would like to do an operation on: ");

                Console.Write("First number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Now enter the opertation you would like to use and once you do this, " +
                    "your solution will be printed on the next page: ");
                opp = Console.ReadLine();

                switch (opp)
                {
                    case "+": Console.WriteLine(num1 + num2); break;
                    case "-": Console.WriteLine(num1 - num2); break;
                    case "*": Console.WriteLine(num1 * num2); break;
                    case "/": Console.WriteLine(num1 / num2); break;
                    default: Console.WriteLine("You entered an invalid operation, please try again: "); break;
                }
            }


            public static void SquareRoot()
            {
                int num1;
                Console.WriteLine("\n Enter a number you would like to square root");
                num1 = Convert.ToInt32(Console.ReadLine());
                double result = Math.Sqrt(num1);
                Console.WriteLine(result);
            }

            public static void PowerCalcualtor()
            {

                int num1, num2, result = 1;

                Console.WriteLine("\n Enter a base number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What power number would you like to raise this number to: ");
                num2 = Convert.ToInt32(Console.ReadLine());



                for (int i = 1; i <= num2; i++)
                {
                    result = result * num1;
                }

                Console.WriteLine(result);
            }


            public static void MaxAndMin()
            {
                string input;
                double num1, num2, result;
                Console.WriteLine("\n Would you like to work out which number is bigger? ");
                input = Console.ReadLine();

                if (input == "Max")
                {
                    Console.WriteLine("Enter a value for the first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter a second number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(result = Math.Max(num1, num2));
                }

                else if (input == "Min")
                {
                    Console.WriteLine("Enter a value for the first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter a second number: \n\n");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(result = Math.Min(num1, num2));
                }
                else
                {
                    Console.WriteLine("You have entered an invalid type");
                }
            }

            public static void Average()
            {
                int numberOfElements;
                double[] values = new double[1000];
                double sum = 0, average;

                Console.Write("How many numbers would you like to find the average of? ");
                numberOfElements = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the values you would like to find the average of: \n");

                for (int i = 1; i <= numberOfElements; i++)
                {
                    Console.Write($"Number {i}: ");
                    values[i] = Convert.ToDouble(Console.ReadLine());
                }

                foreach (double i in values)
                {
                    sum += i;
                }

                average = sum / numberOfElements;

                Console.WriteLine("The average is {0} ", average);


            }


        }
}


