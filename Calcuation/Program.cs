﻿using System;
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
            Console.WriteLine("sum ={0}", sum);
            Console.WriteLine("diff ={0}", diff);

        }

        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Sub(double a, double b)
        {
            return a - b;
        }
    }
}
