using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string arg_Name, string arg_Major, double arg_GPA)
        {
            name = arg_Name;
            major = arg_Major;
            gpa = arg_GPA;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
