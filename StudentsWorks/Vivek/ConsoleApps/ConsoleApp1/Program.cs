using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("entered number is even");
            }
            else {
                Console.WriteLine("entered number is odd");
            }
            
        }
    }
}
