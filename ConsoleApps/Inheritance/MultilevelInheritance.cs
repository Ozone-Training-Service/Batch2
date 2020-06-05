using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class P
    {
       
       public  void hello()
        {
            Console.WriteLine("Hello from P");
        }

    }
    class Q:P
    {
       public  void Sum()
        {
            Console.WriteLine("Hello  from Q" );
        }

    }
    class R:Q
    {
        public void Sub()
        {
            Console.WriteLine("Hello from sub");
        }
    }





    public class MultilevelInheritance
    {
        static void Main(string[] args)
        {

            R o = new R();
            o.hello();
            o.Sub();
            o.Sum();

            Console.ReadKey();
        }
    }
}
