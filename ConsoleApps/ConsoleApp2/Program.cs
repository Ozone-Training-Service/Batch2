using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("Sum=" + c);
            Console.WriteLine("Sum=   {0}", c);
            Console.WriteLine("{0}+{1}={2}", a, b, c);

            Console.ReadKey();
        }
    }
}
