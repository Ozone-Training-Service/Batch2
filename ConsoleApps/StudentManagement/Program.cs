using Day3;
using System;
using System.IO;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {

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


            StreamWriter ob = new StreamWriter(@"D:\ALL\Ozone Traing\App\Result.txt", true);
            ob.WriteLine("Name    "+s1.Name);
            ob.WriteLine("M1     " + s1.M1);
            ob.Close();

            Console.WriteLine("Done");
            Console.ReadKey() ;

        }
    }
}
