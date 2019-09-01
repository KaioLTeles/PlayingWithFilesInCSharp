using System;
using System.IO;

namespace PlayingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {
                //Creating object fileInfor
                FileInfo fileInfo = new FileInfo(sourcePath);
                //Coppy a file in temp directory
                fileInfo.CopyTo(targetPath);
                //Creating a array that recive the content of the file1 arquive.
                string[] lines = File.ReadAllLines(sourcePath);
                //Printing in console the file content
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
