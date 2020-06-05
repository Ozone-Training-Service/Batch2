using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    public class Student
    {
        public int RollNo;
        public string Name;
        public int M1;
        public int M2;
        public int TotalMark;
        public void CalculateTotalMark()
        {
            TotalMark = M1 + M2;


        }
    }
}
