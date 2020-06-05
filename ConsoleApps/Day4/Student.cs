using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    public  class Student
    {
        
        private string name;
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }


        public string Address { get; set; }// properties
        public int RollNo { get; set; }
        public int M1 { get; set; }
        public int M2 { get; set; }

        public void hello()
        {
            Console.WriteLine("Hello");
        }
        
    }
}
