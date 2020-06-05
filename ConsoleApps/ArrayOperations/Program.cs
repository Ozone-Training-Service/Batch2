using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];//1d
            int[,] b = new int[3, 3];//2d
            //b[0, 0] = 90;


            //a[0] = 10;
            //a[1] = 20;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    // a[i] = i;

            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Output");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}



            //two dimension Array

            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < 3; i++)//row
            {
                for (int j = 0; j < 3; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("output ");


            for (int i = 0; i < 3; i++)//row
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i,j] +"   ");
                }
                Console.WriteLine("\n");

            }



            Console.WriteLine("Hello World!");
        }
    }
}
