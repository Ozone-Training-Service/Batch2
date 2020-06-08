using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine("Ans" + c);
                

            }
            catch (Exception ex)
            {
                // Console.WriteLine("B can't be 0");
                //Console.WriteLine(ex.Message);
                throw new DivideByZeroException();

            }
            finally
            {
                Console.WriteLine("hello hai goodmorning");
            
            }
            
            Console.WriteLine("Hello");
            Console.ReadKey();

        }
    }
}
