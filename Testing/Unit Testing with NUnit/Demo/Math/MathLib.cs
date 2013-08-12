using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    public class MathLib
    {
        /// <summary>
        /// a + b
        /// </summary>        
        static public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// a - b
        /// </summary>        
        static public double Sub(double a, double b)
        {
            return (a - b);
        }

        /// <summary>
        /// a * b
        /// </summary>
        static public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// a / b
        /// </summary>
        static public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            else
                return a / b;
        }
    }
}
