using System;
using System.IO;

namespace Sreams
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../input.txt");
            var students = reader.ReadToEnd();
            Console.WriteLine(students);

            //string firstStudent = reader.ReadLine();
            //Console.WriteLine(firstStudent);

            //string student = reader.ReadLine();
            //while (student != null)
            //{
            //    Console.WriteLine(student);
            //    student = reader.ReadLine();
            //}

            //var student1 = reader.Read(); // chete element po element
            //while (student1 != -1)
            //{
            //    Console.Write((char)student1);
            //    student1 = reader.Read();
            //}

            //reader.Close();
            


            //StreamWriter writer = new StreamWriter("../../../students.txt");
            //writer.Write("First student!!!");
            //writer.WriteLine("Second student!!!");
            //writer.Write("Third student!!!");
            //writer.Close();

            //for (int i = 0; i < 50; i++)
            //{
            //    StreamWriter writer = new StreamWriter($"../../../students-part-{i + 1}.txt");
            //    writer.Write("First student!!!");
            //    writer.WriteLine("Second student!!!");
            //    writer.Write("Third student!!!");
            //    writer.Close();

            //}

        }
    }
}
