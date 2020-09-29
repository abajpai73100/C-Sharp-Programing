using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArray
    {
        static void revArray(int[] arr)
        {
            Array.Reverse(arr);
            Console.WriteLine("\nReversed array is: ");
            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }
        }
        static void Main(string[] args)
        {
            int l;

            Console.Write("Enter array length: ");
            l = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[l];

            for (int i = 0; i < l; i++)
            {
                Console.Write("Enter arr[{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            revArray(arr);
            Console.ReadLine();
        }
    }
}
