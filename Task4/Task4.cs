using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class Task4
    {
        public static double NewtonianMethod(double A, int n, double eps)
        {
            if(A < 0)
                throw new ArgumentException("invalid value");
            double pow = (double)n;
            double x0 = A/n;
            double xn = (1/pow)*((n-1)*x0+A/Math.Pow(x0,n-1));
            while (Math.Abs(xn - x0) > eps)
            {
                x0 = xn;
                xn = (1 / pow) * ((n - 1) * x0 + A / Math.Pow(x0, n - 1));
            }
            return xn;
        }
       
    }
}
