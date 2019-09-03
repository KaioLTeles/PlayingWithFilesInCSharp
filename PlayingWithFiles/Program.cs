using System;
using System.IO;

namespace PlayingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            

           



        }
    }
}
