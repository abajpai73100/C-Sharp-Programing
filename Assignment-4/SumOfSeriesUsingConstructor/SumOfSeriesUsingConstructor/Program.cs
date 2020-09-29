using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSeriesUsingConstructor
{
    class SumOfSeriesUsingConstructor
    {
        static int fact(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return (n * fact(n - 1));
        }
        static SumOfSeriesUsingConstructor()
        {
            double n = 0;
            int x, i = 1;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nSUM = {0}", x, " ");
            for (int j = 3; j <= x; j += 2)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" +(" + x + "^" + j + "/" + fact(j) + ")");
                    n += (Math.Pow(x, j) / fact(j));
                }
                else
                {
                    Console.Write(" -(" + x + "^" + j + "/" + fact(j) + ")");
                    n -= (Math.Pow(x, j) / fact(j));
                }
                i += 1;
            }
            n = x - n;
            Console.Write("\n\n\tSum of series is: " + n);

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
        }
    }
}