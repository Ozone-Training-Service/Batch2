using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.hello();
            int y=obj.getARandomNumber();
            Console.WriteLine("Random="+y);

            obj.Sum(10,10);

            Console.WriteLine(obj.Sub(20,10));
        }
    }
}
