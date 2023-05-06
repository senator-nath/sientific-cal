using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sientific_cal
{ 
    //+,-,*,/,%, log, sin, cos, tan, square, sqrt, cube, cuberoot, nthroot, nthpower) :")
    internal class baseOperation
    {
        public double LogOfNumbers(double num1, double num2)
        {
            double result;
            result= Math.Log(num1, num2);
            return result;
        }
        public double NthPowerOfNumbers(double num1, double num2)
        {
            double result;
            result= Math.Pow(num1, num2);
            return result;
        }
        public double NthRootOfNumbers(double num1, double num2)
        {
            double result;
            result= Math.Pow(num1,1.0/ num2);
            return result;
        }
    }
}
