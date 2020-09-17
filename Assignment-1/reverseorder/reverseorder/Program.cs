using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseorder
{
    class Reverse

    {
        int numRev(int num)
        {
            int r =0;
            while(num>0)
            {
                r = r * 10 + (num % 10);
                num /= 10;
            }

            return r;
        }
       
        static void Main(string[] args)
        {
            int num;
         
            Console.Write("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());

            Reverse rev = new Reverse();
            Console.Write("Reverse is :" + rev.numRev(num));
            Console.Read();

        }
    }
}
