using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsDemo
{
    class Student
    {
        //private, internal, protected, public
        private string name;
        //private int age;

        public string Name
        {
            get
            {
                Console.WriteLine("In the getter");
                return name;

                //return "NoName";
            }
            set
            {
                Console.WriteLine("In the setter");
                name = value;
            }

           
    }
    }
}
