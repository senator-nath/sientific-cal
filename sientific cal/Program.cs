using System;

namespace oop_calculator_task

{
    class Program
    {
        static void Main(string[] args)
        {
            calculator cal = new calculator();
            while (true)
            {
                Console.WriteLine("select operation (+,-,*,/,%, log, sin, cos, tan, square, sqrt, cube, cuberoot, nthroot, nthpower) :");
                string operation = Console.ReadLine();
                if (operation == "exit")
                {
                    break;
                }
                try
                {
                    Console.WriteLine("enter first number:");
                    double num1 = double.Parse(Console.ReadLine());
                    if (operation != "square" && operation != "sqrt" && operation != "cube" && operation != "cuberoot")
                    {
                        Console.WriteLine("enter second number:");
                        double num2 = double.Parse(Console.ReadLine());

                        double result = cal.PerformOperation(operation, num1, num2);
                        Console.WriteLine("result is : {0}", result);
                    }

                    else
                    {
                        double result = cal.PerformOperation(operation, num1);
                        Console.WriteLine("result is :{0} ", result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }
    }

    class calculator
    {
        public double PerformOperation(string operation, double num1, double num2)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-": return num1 - num2;
                case "*": return num1 * num2;
                case "/":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("division by zero is not allowed");
                    }
                    return num1 / num2;
                case "%": return num1 % num2;
                case "log": return Math.Log(num1, num2);
                case "cos": return Math.Cos(num1);
                case "sin": return Math.Sin(num1);
                case "tan": return Math.Tan(num1);
                case "nthroot":
                    return Math.Pow(num1, 1.0 / num2);
                case "nthpower":
                    return Math.Pow(num1, num2);
                default: throw new ArgumentException("invalid operation");


            }
        }
        public double PerformOperation(string operation, double num1)
        {
            switch (operation)
            {
                case "square": return Math.Pow(num1, 2);
                case "sqrt": return Math.Sqrt(num1);
                case "cube": return Math.Pow(num1, 3);
                case "cuberoot": return Math.Pow(num1, 1.0 / 3);
                default: throw new ArgumentException("invalid operation");
            }

        }
    }
}