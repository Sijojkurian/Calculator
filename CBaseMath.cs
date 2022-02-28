using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
     public class CBaseMath
    {
        public double Sum(double value1, double value2)
        {
            //add
            return value1 + value2;
        }

        public double Substract(double value1, double value2)
        {   //substracts
            return value1 - value2;
        }

        public double Multiply(double value1, double value2)
        {
            //multiplies
            return value1 * value2;
        }

        //division calc

        public double Divide(double value1, double value2)
        {
            return value1 / value2;
        }
    }
}
