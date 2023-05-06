using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sientific_cal
{
    internal class operationOne
    {
        public double CosOfNumbers(double num1) 
        {
            // ("press6 for cos 7forsin 8fortan 9for square 10 for sqrt 11for cube 12 for cuberoot ");
            double result;
            result = Math.Cos(num1);
            return result;
        }
        public double SinOfNumbers(double num1)
        {
            double result;
            result = Math.Sin(num1);
            return result;
        }
        public double TanOfNumbers(double num1)
        {
            double result;
            result = Math.Tan(num1);
            return result;
        }
        public double SquareOfNumbers(double num1)
        {
            double result;
            result = Math.Pow(num1,2);
            return result;
        }
        public double SqrtOfNumbers(double num1)
        {
            double result;
            result = Math.Sqrt(num1);
            return result;
        }
        public double cubeOfNumbers(double num1)
        {
            double result;
            result = Math.Pow(num1,3);
            return result;
        }
        public double CuberootOfNumbers(double num1)
        {
            double result;
            result = Math.Pow(num1,1.0/3);
            return result;
        }
    }
}
