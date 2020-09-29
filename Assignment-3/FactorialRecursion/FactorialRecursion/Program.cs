﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursion
{
    class FactorialRecursion
    {
        double factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return (factorial(n - 1) * n);
        }
        static void Main(string[] args)
        {
            var fr = new FactorialRecursion();
            int n;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nFactorial is: " + fr.factorial(n));

            Console.ReadLine();
        }
    }
}