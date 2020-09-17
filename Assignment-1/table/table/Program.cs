using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    class Program
    {
        void table(int num,int limit)
        {
            for(int i=1;i<=limit;i++)
            {
                Console.WriteLine(num + "*" + i + " = "+num *i);

            }
            Console.WriteLine("Press any key and exit:");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int num, limit;

            Console.Title = "Table";
            Console.Write("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a limit");
            limit = Convert.ToInt32(Console.ReadLine());

            Program pr = new Program();
            
            pr.table(num, limit);

        }
    }
}
