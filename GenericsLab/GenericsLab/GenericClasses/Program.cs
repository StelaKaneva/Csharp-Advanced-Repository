using System;

namespace GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //object myObject = new object();
            //myObject = new Student();

            //ObjectList list = new ObjectList();
            //list.Add(5);
            //list.Add(6);
            //list.Add("Pesho");

            GenericList<int> list = new GenericList<int>();
            list.Add(5);
            list.Add(6);

            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("Pesho");
        }

        class Student
        {
            public int Age { get; set; }
        }
    }
}
