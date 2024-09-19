using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Program_104
{
    internal class Properties
    {
        student a = new student("Mariel", "Hubahib", 12, 'A');

    }

    class student
    {
        private string firstname, lastname, course;
        private int grade;
        private char section;

        public string Name { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public char Section { get { return section; } set { section = value; } }



        public student (string Firstname, string Lastname, int Grade, char Section)
        {
            firstname = Firstname;
            lastname = Lastname;
            grade = Grade;
            section = Section;



            Console.WriteLine("Student  Informatioin:");
            Console.WriteLine(Firstname + " " + Lastname);
            Console.WriteLine(Grade + " - " + Section);

        }

    }

}
