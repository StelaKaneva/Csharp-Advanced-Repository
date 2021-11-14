using System;

namespace StudentsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Goshko";
            Console.WriteLine(student.Name);

            JavaProperty prop = new JavaProperty();
            prop.SetName("pesho");
            Console.WriteLine(prop.GetName());

            Dog dog = new Dog();
            dog.FullName = "Dog Dogov";
            Console.WriteLine(dog.FullName);

            dog.Age = 55;
            //dog.Age = 101;
            dog.BitenPerson();
            dog.BitenPerson();
            Console.WriteLine(dog.IsBadDog);
        }
    }
}
