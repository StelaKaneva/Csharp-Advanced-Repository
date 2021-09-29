using System;
using System.IO;

namespace StreamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (FileStream stream = new FileStream("../../../test.txt", FileMode.OpenOrCreate))
            //{
            //    byte[] buffer = new byte[3]; //{1, 2, 3};
            //    //stream.Write(buffer, 0, buffer.Length);

            //    stream.Read(buffer, 0, 3);
            //    Console.WriteLine(String.Join(" ", buffer));
            //}

            byte[] buffer = new byte[10];

            //for (byte i = 0; i < 100; i++)
            //{
            //    buffer[i] = i;
            //}

            using (FileStream stream = new FileStream("../../../test.txt", FileMode.OpenOrCreate))
            {
                Console.WriteLine($"Fole length: {stream.Length}");
                Console.WriteLine($"Stream position: {stream.Position}");
                stream.Read(buffer, 0, 3);
                Console.WriteLine($"Stream position: {stream.Position}");
                stream.Read(buffer, 3, 3);
                Console.WriteLine($"Stream position: {stream.Position}");
                stream.Read(buffer, 6, 3);
                Console.WriteLine($"Stream position: {stream.Position}");

                Console.WriteLine(String.Join(" ", buffer));
            }
        }
    }
}
