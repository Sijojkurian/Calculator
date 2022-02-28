using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    //create this as public and derive it from CBaseMath
    public class CAdvancedMath:CBaseMath
    {
        //create a function that creates factorial of a given number
        //factorial(5)= 5 X 4 X 3 X 2 X 1 = 120

        public double Factorial(double n)
        {
            double iLoop;
            //iLopp-- same as iLoop=iLoop-1
            double finalValue =1;//will contain the value of the factorial
            for (iLoop = n; iLoop > 0; iLoop = iLoop - 1)
                finalValue = iLoop * finalValue;
            return finalValue;

        }

        public double Square(double a)
        {
            //calculates square
            return a * a;
        }

        public double SqRoot(double a)
        {
            //calculates squreroot
            return Math.Sqrt(a);
        }

        public double Percent(double a)
        {
            //perentage of the given number
            return a * .01;
        }

        public double Inverse(double a)
        {
            //this is the factorial part
            return 1 / a;
        }
    }
}
