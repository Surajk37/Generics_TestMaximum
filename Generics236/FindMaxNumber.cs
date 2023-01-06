using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics236
{
    class FindMaxNumber
    {
       
        //UC1- Created method for finding Greatest integer value
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
              //UC2- Created method for finding Greatest Float value
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
        //UC3- Created method for finding Greatest String value
        public static string  MaxString(string x, string y, string z)
        {
            if ((x.CompareTo(y) > 0) && (x.CompareTo(z) > 0))
            {
                return x;
            }
            else if ((y.CompareTo(x) > 0) && (y.CompareTo(z) > 0))
            {
                return y;
            }
            else
            {
                return z;
            }
        }
        //[1]- Refactoring  code using generics method to get maximum integer,float and string values
        public static T GenericFindMax<T>(T num1, T num2, T num3) where T : IComparable  //Defines a generalized type-specific comparison method that a value type or class
        {
            Console.WriteLine("num1 = {0} \t num2 = {1} \t num3 = {2}", num1, num2, num3);
            if ((num1.CompareTo(num2) > 0) && (num1.CompareTo(num3) > 0))
            {
                return num1;
            }
            else if ((num2.CompareTo(num1) > 0) && (num2.CompareTo(num3) > 0))
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
    //[2]- Refactoring  code using generics Class to get maximum integer,float and string values
    class FindMaxNumbers<T> where T : IComparable
    {
        public T num1,num2,num3;
        public FindMaxNumbers(T num1, T num2, T num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        public static T getMaximum(T num1, T num2, T num3)
        {
            Console.WriteLine("num1 = {0} \t num2 = {1} \t num3 = {2}", num1, num2, num3);
            if ((num1.CompareTo(num2) > 0) && (num1.CompareTo(num3) > 0))
            {
                return num1;
            }
            else if ((num2.CompareTo(num1) > 0) && (num2.CompareTo(num3) > 0))
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
