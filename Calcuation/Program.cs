using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcuation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 10;
            double sum = Add(a, b);
            Console.WriteLine("sum = {0}", sum);
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Multiply(double a, double b)
        {
            return (a * b);
        }
    }
}
