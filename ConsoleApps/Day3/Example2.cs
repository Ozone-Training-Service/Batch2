using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    public class Example2
    {
        public void Calulations()
        {
            int n, a, b, ans;

            Console.WriteLine("\t\t\t\t Calculater");
            Console.WriteLine("\t\t\t\t_________");

            Console.WriteLine("(1) Sum    (2) Differnce");
            Console.WriteLine("(3)Product   (4) Division");

            Console.WriteLine("Select an option?");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Enter 2 num");
                a= Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                ans = a + b;
                Console.WriteLine("Sum={0}",ans);
            }
            else if (n == 2)
            {
                Console.WriteLine("Enter 2 num");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                ans = a - b;
                Console.WriteLine("sub={0}", ans);

            }
            else if(n==3)
            {
                Console.WriteLine("Enter 2 num");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                ans = a * b;
                Console.WriteLine("product={0}", ans);

            }
            else if (n == 4)
            {
                Console.WriteLine("Enter 2 num");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                ans = a * b;
                Console.WriteLine("product={0}", ans);
            }
            else
            {
                Console.WriteLine("not valid");

            }







        }

        
    }
}
