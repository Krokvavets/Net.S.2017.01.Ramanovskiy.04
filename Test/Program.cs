using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task4.Task4.NewtonianMethod(double.MinValue, 2,0.00000001));
            Console.WriteLine(Math.Pow(25,(double)1/2));
            Console.ReadKey();
        }
    }
}
