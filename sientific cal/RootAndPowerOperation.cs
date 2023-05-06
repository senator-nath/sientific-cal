using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sientific_cal
{
    
    internal class RootAndPowerOperation
    {
        private readonly Beginning input = new Beginning();
        public void OperationMethodOne()
        {
            operationOne operatee = new operationOne();
           double result;

            string? operation = input.OperationSign;

                //Console.WriteLine("enter number");
                double num1 = double.Parse(Console.ReadLine());

                switch (operation)
                {
                    case "6":
                       result = operatee.CosOfNumbers(num1); break;
                    case "7":
                        result = operatee.SinOfNumbers(num1); break;
                    case "8":
                        result = operatee.TanOfNumbers(num1); break;
                    case "9":
                        result = operatee.SquareOfNumbers(num1); break;
                    case "10":
                        result = operatee.SqrtOfNumbers(num1); break;
                    case "11":
                        result = operatee.cubeOfNumbers(num1); break;
                    case "12":
                        result = operatee.CuberootOfNumbers(num1); break;
                    default:
                        Console.WriteLine("invalid operation"); return;
                }

                Console.WriteLine(result);


            
            
            
        }
    }
}
