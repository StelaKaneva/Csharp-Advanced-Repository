using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\Lenovo\Desktop\SoftUni\ADVANCED\Streams, Files and Directories - Exercise\ZipFileDemo", @"C:\Users\Lenovo\Desktop\SoftUni\ADVANCED\Streams, Files and Directories - Exercise\ZipFileDemoResult\myZipFile.zip");

            ZipFile.ExtractToDirectory(@"C:\Users\Lenovo\Desktop\SoftUni\ADVANCED\Streams, Files and Directories - Exercise\ZipFileDemoResult\myZipFile.zip", @"C:\Users\Lenovo\Desktop\SoftUni\ADVANCED\Streams, Files and Directories - Exercise\ExtractedFail");

        }
    }
}
