using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Average
{
    class OOP_Average
    {
        static float avg(float[] n)
        {
            float c = 0;
            foreach(float i in n)
            {
                c += i;
            }
            return (c / 5);
        }
        static void Main(string[] args)
        {
            float[] n = new float[5];

            Console.WriteLine("Enter 5 real numbers.\n");
            for(int i=0; i<5; i++)
            {
                Console.Write("\tEnter number[{0}]: ",i);
                n[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("\nAverage is: " + avg(n));
            Console.ReadLine();
        }
    }
}
