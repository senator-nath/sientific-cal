using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sientific_cal
{
    internal class BasicOpeartion
    {

        public double SumOperation(double num1, double num2)
        {
            double result;
            result = num1 + num2;
            return result;
        }
        public double SubtractOperation(double num1, double num2)
        {
            double result;
            result = num1 - num2;
            return result;
        }
        public double MultiplyOperation(double num1, double num2)
        {
            double result;
            result = num1 * num2;
            return result;
        }
        public double DivideOperation(double num1, double num2)
        {
            double result;
            if (num2 == 0)
             {
              throw new DivideByZeroException("division by zero is not allowed");
             }
                result = num1 / num2;
            return result;
        }
        public double RemaindeerOperation(double num1, double num2)
        {
            double result;
            result = num1 % num2;
            return result;
        }
    }
}