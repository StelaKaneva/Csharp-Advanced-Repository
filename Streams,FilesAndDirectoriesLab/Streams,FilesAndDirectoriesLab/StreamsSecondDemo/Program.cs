using System;
using System.IO;

namespace StreamsSecondDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream("../../../input.txt", FileMode.OpenOrCreate))
            {
                Console.WriteLine(stream.Length);
                FileInfo fileInfo = new FileInfo("../../../input.txt");

                byte[] buffer = new byte[3];//chetem navednuj po tri
                stream.Position = 3;
                while (stream.Position < stream.Length)
                {
                    stream.Read(buffer, 0, buffer.Length);
                    Console.WriteLine($"Piece read: pos {stream.Position}");
                    //for (int i = 0; i < buffer.Length; i++)
                    //{
                    //    Console.Write((char)buffer[i]);
                    //}
                    //Console.WriteLine();
                }
            }
        }
    }
}
