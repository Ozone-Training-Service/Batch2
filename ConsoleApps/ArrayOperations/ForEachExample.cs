using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    class ForEachExample
    {

        static void Main(string[] args)
        {

            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }

            Console.WriteLine("output");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("output");

            foreach (var  i in a)
            {
                Console.WriteLine(i);
            }

        }
    }
}
