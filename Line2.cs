using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineComparision
{
    internal class Line2
    {
        public static void linecomparison()
        {
            int x1, x2, y1, y2, x3, y3;
            double A, B, C, D, x, y, a, b;
            Console.WriteLine("enter co-ordinates for Line 1 & LINE 2");
            Console.WriteLine("enter point (x1, y1)");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter point (x2, y2)");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter point (x3, y3)");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();

            //for line 1
            A = (x2 - x1);
            B = (y2 - y1);
            x = Math.Pow(A, 2) + Math.Pow(B, 2);
            a = Math.Sqrt(x);
            Console.WriteLine("length of line = " + a);

            // for line 2
            C = (x3 - x2);
            D = (y3 - y2);
            y = Math.Pow(C, 2) + Math.Pow(D, 2);
            b = Math.Sqrt(y);
            Console.WriteLine("length of line = " + b);

            //equals to method
            string s1 = "a";
            string s2 = "b";

            // Equals() method return true as both string objects are equal
            Console.WriteLine("line 1 is eual to line 2");
            Console.WriteLine(s1.Equals(s2));
        }
    }
}
