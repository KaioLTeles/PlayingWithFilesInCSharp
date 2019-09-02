using System;
using System.IO;

namespace PlayingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";
            StreamReader sr = null;

            try
            {                
                sr = new StreamReader( new FileStream(path, FileMode.Open)); // Instaciando dentro do StreamReader o FileStream
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                
            }
        }
    }
}
