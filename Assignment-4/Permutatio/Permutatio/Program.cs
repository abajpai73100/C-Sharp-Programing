using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutatio
{
    class Permutation
    {
        static List<int> db = new List<int>();
        static int c = 0;
        private static void permute(String str, int l, int r) //permute
        {
            if (l == r)
            {
                if (!db.Any())
                {
                    db.Add(Int32.Parse(str));
                    c += 1;
                }
                else
                {
                    if (!db.Contains(Int32.Parse(str)))
                    {
                        db.Add(Int32.Parse(str));
                        c += 1;
                    }
                }
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = permute(l, str, i);
                    permute(str, l + 1, r);
                    str = permute(l, str, i);
                }
            }
        }
        public static String permute(int i, String a, int j) //swap
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        static void Main(string[] args)
        {
            string str;

            Console.Write("Enter an integer: ");
            str = Console.ReadLine();

            permute(str, 0, str.Length - 1);

            Console.WriteLine("\nTotal permutations: " + c);
            Console.Write("\n");
            int x = 1;
            foreach (int i in db)
            {
                Console.WriteLine(x + ":" + "\t" + i);
                x++;
            }

            Console.ReadLine();
        }
    }
}
