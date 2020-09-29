﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleAddition
{
    class DoubleAddition
    {
        double add(double a, double b)
        {
            return (a + b);
        }
        static void Main(string[] args)
        {
            var da = new DoubleAddition();

            double a, b;
            Console.Write("Enter two numbers: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n" + a + " + " + b + " = " + da.add(a, b));

            Console.ReadLine();
        }
    }
}
