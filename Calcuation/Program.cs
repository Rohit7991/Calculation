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
            double diff = Sub(a, b);
            double pro = Mul(a, b);
            double div = Divide(a, b);
            Console.WriteLine("pro(diff ={0}", diff);
            Console.WriteLine("pro ={0}", pro);
            Console.WriteLine("div ={0}", div);

            int power = Pow(2, 3);
            Console.WriteLine("sum ={0}", sum);
            Console.WriteLine("diff ={0}", diff);
            Console.WriteLine("pro ={0}", pro);
            Console.WriteLine("power ={0}", power);

        }
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Sub(double a, double b)
        {
            return a - b;
        }

        static double Mul(double a, double b)
        {
            return (a * b);

        }
        static double Divide(double a, double b)
        {
            return (a / b);
        }
        static int Pow(int a,int b)
        {
            int result = 1;
            for (int i=1;i<=b;i++)
            {
                result *= a;
            }
            return result;


        }
    }
}
