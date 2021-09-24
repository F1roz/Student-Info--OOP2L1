using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Student
    { 
        //field 
        string name, id;
        float cgpa;
        //Constructor 
        public Student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            //Console.WriteLine("Student Created...");

        }
        //method
        public void PrintStudent()
        {
            Console.WriteLine("Name:{0}\nId:{1}\nCgpa:{2}", this.name, this.id, this.cgpa);
        }
    }
}
