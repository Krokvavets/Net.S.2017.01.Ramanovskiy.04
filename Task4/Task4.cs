using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class Task4
    {
        ///<summary>
        /// The method calculate Ninth Root
        ///</summary>
        /// <param name="number">input value</param>
        /// <param name="n">power</param>
        /// <param name="eps">precision</param>
        ///<returns>Ninth Root</returns>
        public static double NewtonianMethod(double number, int n, double eps)
        {
            if (number < 0)
                throw new ArgumentException("invalid value");
            ;
            double x0 = number / n;
            double xn = (1 / (double)n) * ((n - 1) * x0 + number / Math.Pow(x0, n - 1));
            while (Math.Abs(xn - x0) > eps)
            {
                x0 = xn;
                xn = (1 / (double)n) * ((n - 1) * x0 + number / Math.Pow(x0, n - 1));
            }
            return xn;
        }

    }
}
