using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

   public  class Calc
    {
        public int x, y, z;

        public   void input()
        {
            Console.WriteLine("Enter 1st num");
            x= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd num");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public void Add()
        {
            z = x + y;

        }


        public void Display()
        {
            Console.WriteLine("Sum={0}",z);
        }
    }


    class Sum
    {
        static void Main(string[] args)
        {


            Calc ob = new Calc();
            ob.input();
            ob.Add();
            ob.Display();

            
            
            //int a, b, c;
            //Console.WriteLine("Enter 1st num");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter 2st num");
            //b = Convert.ToInt32(Console.ReadLine());
            //c = a + b;
            //Console.WriteLine("Ans={0}",c);


           

            Console.ReadKey();
        }
    }
}
