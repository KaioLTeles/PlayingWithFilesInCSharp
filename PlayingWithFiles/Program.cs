using System;
using System.IO;

namespace PlayingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\test";
            

            try
            {
                //C# está fazendo a inferncia do tipo da variavel
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                //C# está fazendo a inferncia do tipo da variavel
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + @"\models");
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }



        }
    }
}
