﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class PrimeFactors
    {
        void primeNumbers(int n)
        {
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            if (n > 2)
                Console.Write(n);
        }
        static void Main(string[] args)
        {
            var pf = new PrimeFactors();

            int n;

            Console.Write("Enter a positive integer: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPrime Factors of " + n + " are: ");
            pf.primeNumbers(n);

            Console.ReadLine();
        }
    }
}