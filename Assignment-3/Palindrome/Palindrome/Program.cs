using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        int rev(int n)
        {
            int r = 0;
            while (n != 0)
            {
                r = r * 10 + n % 10;
                n /= 10;
            }
            return r;
        }
        static void Main(string[] args)
        {
            var pl = new Palindrome();

            int n;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == pl.rev(n))
                Console.Write("\n\tPalindrome");
            else
                Console.Write("\n\tNot palindome");

            Console.ReadLine();
        }
    }
}