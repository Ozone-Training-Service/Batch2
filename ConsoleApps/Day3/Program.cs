using System;

namespace Day3
{
  

    class Program
    {
        static void Main(string[] args)
        {
            // Calculater o = new Calculater();
            // o.input();


            //    Example2 o = new Example2();
            // o.Calulations();



            Student s1 = new Student();
            Student s2 = new Student();


            Console.WriteLine("Enter the Name of First Student");
            s1.Name = Console.ReadLine();
            Console.WriteLine("Enter the M1 of 1st student");
            s1.M1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the M2 of 1st student");
            s1.M2 = Convert.ToInt32(Console.ReadLine());
            s1.CalculateTotalMark();


            Console.WriteLine("Enter the Name of 2 Student");
            s2.Name = Console.ReadLine();
            Console.WriteLine("Enter the M1 of 1st student");
            s2.M1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the M2 of 1st student");
            s2.M2 = Convert.ToInt32(Console.ReadLine());
            s2.CalculateTotalMark();



            Console.WriteLine("output");
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("Name              M1                  M2            Total");
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine(s1.Name+"\t\t\t\t"+s1.M1+""+s1.M2+"             "+s1.TotalMark);
            Console.WriteLine(s2.Name + "\t\t\t\t" + s2.M1 + "" + s2.M2 + "             " + s2.TotalMark);




            Console.ReadKey();
        }
    }
}
