using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{




    class Sum
    {
        static void Main(string[] args)
        {
           
             int a, b, c;
            Console.WriteLine("Enter 1st num");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2st num");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Ans={0}",c);

            Console.ReadKey();
        }
    }
}
