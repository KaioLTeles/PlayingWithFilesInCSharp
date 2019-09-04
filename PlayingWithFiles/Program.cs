using System;
using System.IO;
using Entities;

namespace PlayingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter the file full path: ");
                string sourcePath = Console.ReadLine();

                string[] lines = File.ReadAllLines(sourcePath); //Reading all lines in the file and put on array lines

                string sourceFolderPath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using(StreamWriter sw = File.AppendText(targetFilePath)) //Instance the using for close my disposable content
                {
                    foreach(string line in lines)
                    {
                        string[] fields = line.Split(',');

                        string name = fields[0];
                        double price = double.Parse(fields[1]);
                        int qnt = int.Parse(fields[2]);

                        Product p = new Product(name, price, qnt);

                        sw.WriteLine(p.ToString());

                    }
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("An unexpected error occurred!");
                Console.WriteLine(e.Message);
            }

        }
    }
}
