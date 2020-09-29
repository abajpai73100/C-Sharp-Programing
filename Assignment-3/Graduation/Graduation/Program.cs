using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Graduation
    {
        Boolean calc(float mm, float gp, float ip, float hp)
        {
            if (mm < 55 && gp < 65)
                return false;
            else if ((mm >= 55 || gp >= 65) && (ip >= 60) && (gp >= 60))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            var grd = new Graduation();

            float mm, gp, ip, hp;

            Console.Write("Enter marks in mathematics (graduation): ");
            mm = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter percentage in graduation: ");
            gp = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter percentage in intermediate: ");
            ip = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter percentage in highschool: ");
            hp = Convert.ToSingle(Console.ReadLine());

            if (grd.calc(mm, gp, ip, hp))
                Console.Write("\n\tEligibility criteria met.");
            else
                Console.Write("\n\tEligibility criteria not met.");

            Console.ReadLine();
        }
    }
}