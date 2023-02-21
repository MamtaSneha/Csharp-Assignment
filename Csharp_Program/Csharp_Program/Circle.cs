using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Program
{
    class Circle
    {
        public static void Main()
        {
            decimal pi = 3.14m;
            int r = 0;
            decimal area = 0m;
            decimal circumference = 0m;
            Console.WriteLine("Area of Circle");
            Console.WriteLine("----------------");
            Console.WriteLine("Enter Radius of Circle");
            r = Convert.ToInt32(Console.ReadLine());
            area = pi * r * r;
            Circle.area(ref area);
            Console.WriteLine("Circumference of circle");
            Console.WriteLine("----------------");
            Console.WriteLine("Enter Radius of Circle");
            r = Convert.ToInt32(Console.ReadLine());
            circumference = 2 * pi * r;
            Circle.circumference(ref circumference);
        }
        public static void area(ref decimal a)
        {
            Console.WriteLine("area of circle={0}", a);
        }
        public static void circumference(ref decimal c)
        {
            Console.WriteLine("circumference of circle={0}", c);
        }
    }
}
