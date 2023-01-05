using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics236
{
    class FindMaxNumber
    {
        public static void MaxInt(int a,int b,int c)
        {
            if ((a.CompareTo(b) > 0) && (a.CompareTo(c) > 0))
            {
                Console.WriteLine("\nThe maximum Integer number is:" + a);
            }
            else if ((b.CompareTo(a) > 0) && (b.CompareTo(c) > 0))
            {
                Console.WriteLine("\nThe maximum Integer number is: " + b);
            }
            else
            {
                Console.WriteLine("\nThe maximum Integer number is : " + c);
            }
        }
        public static double MaxFloat(double p, double q, double r)
        {
            if ((p.CompareTo(q) > 0) && (p.CompareTo(r) > 0))
            {
                return p;
            }
            else if ((q.CompareTo(p) > 0) && (q.CompareTo(r) > 0))
            {
                return q;
            }
            else
            {
                return r;
            }
        }

    }
}
