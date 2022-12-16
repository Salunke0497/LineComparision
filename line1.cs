using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineComparision
{
    internal class line1
    {
        public static void line()
        {
            int x1, x2, y1, y2, x, y;
            double z, a;
            Console.WriteLine("enter point (x1, y1)");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter point (x2, y2)");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            x = (x2 - x1);
            y = (y2 - y1);
            z = Math.Pow(x, 2) + Math.Pow(y, 2);
            a = Math.Sqrt(z);
            Console.WriteLine("length of line = " + a);
        }
    }
}
