using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Program
{
    class ArrayInt
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n;
            Console.Write("No of elements :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input elements in the array :\n", n);
            static int arrSum(int[] a, int n)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    sum += a[i];
                }

                return sum;
            }

            Console.Write("Sum:" + arrSum(a, n));
        }
    }
}
