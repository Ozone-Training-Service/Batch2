using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    public class Employee
    {

        public void hello( ) // without returb type without parameter
        {
            Console.WriteLine("Hello");
        }

        public int getARandomNumber() //with return type without param
        {

            Random rn = new Random();  ///creating a random nummber
            int number = rn.Next(1000);


            return number;
        }



        public void Sum(int x, int y)//without return type with param
        {
            int ans = x + y;
            Console.WriteLine("Sum="+ans);
        }


        public int Sub(int x,int y)// with return type with param
        {
            int ans = x - y;

            return ans;
        }


    }
}
