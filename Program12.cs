using System;
using System.IO;
namespace ConsoleApp18
{
    class FileRead
    {
        public static void Main()
        {
            string file1;
            string file2;
            Console.Write("enter the first file path:");
            file1 = Console.ReadLine();
            Console.Write("enter the second file path:");
            file2 = Console.ReadLine();
            if (!File.Exists(file1))
            {
                Console.WriteLine("first file does not exists");
            }
            else
                if (!File.Exists(file2))
            {
                Console.WriteLine("second file does not exist!");
            }
            else
               if (File.ReadAllText(file1) == File.ReadAllText(file2))
            {
                Console.WriteLine("both files contain the same content");
            }

            else
            {
                Console.WriteLine("contents of files are not same");    
            }
        }
    }
} 
