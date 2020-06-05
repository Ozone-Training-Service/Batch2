using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class A
    {
        public A()// degfault constructor
        {
            Console.WriteLine("Hi from A's Constructer");
        }

        public A(int x,int y)//pare
        {
            Console.WriteLine(x+y);
        }
       public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }


    class B:A
    {

        public B()
        {
            Console.WriteLine("B's constructor");
        }
        public void hai()
        {
            Console.WriteLine("Hai");
        }
    }






    class SingleInheritance
    {
        static void Main(string[] args)
        {
            B o = new B();
            o.Hello();
            o.hai();



            //A o = new A(10, 10);
            //A o2 = new A();
            //o.Hello();
            Console.ReadKey();
        }
    }
}
