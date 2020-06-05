using System;

namespace FunctionOverloadingAndOverRidding
{
    
    class A
    {
       
        public void hello()
        {
            Console.WriteLine("Hello     ");
        }


    }
    class B : A
    {
        public void hello()
        {
            Console.WriteLine("hai ");
        }
    }
    
    
    class Sample
    {
        // function overloading
       public void Sum(int x, int y)
        {
            Console.WriteLine("Sum="+(x+y));
        }

        public  void Sum(int x, int y, int z)
        {
            Console.WriteLine("Sum="+(x+y+z));
        }

        public void Sum(int x, int y, int z,int zz)
        {
            Console.WriteLine("Sum=" + (x + y + z+zz));
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Sample o = new Sample();
            o.Sum(1, 1);
            o.Sum(1, 2, 3);


            B o1 = new B();
            o1.hello();


            Console.ReadKey();
        }
    }
}
