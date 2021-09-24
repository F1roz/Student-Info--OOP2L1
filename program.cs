using System;
using MyLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            /*System.Console.Write("Enter your name: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Enter your ID: ");
            string id = System.Console.ReadLine();

            System.Console.Write("Enter your semester: ");
            int semester = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter your CGPA: ");
            float Cgpa = System.Convert.ToSingle(System.Console.ReadLine());
            System.Console.WriteLine("================");
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("ID: " + id);
            System.Console.WriteLine("Semester: " + semester);
            System.Console.WriteLine("CGPA: " + Cgpa);
            //easy output by using placeholder or index
            //System.Console.WriteLine("Name: {0}\n") watch video*/
            //MyLibrary.Student student = new MyLibrary.Student();
            
            Student student = new Student("Firoz Fahim", "18-38504-2",3.42f);
            student.PrintStudent();

        }
    }
}
