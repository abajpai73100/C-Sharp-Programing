using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter to Frist number :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter to second number :");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Frist number is :" + a);

            Console.WriteLine("Second number is :" + b);

            Console.ReadLine();
        }
    }
}
