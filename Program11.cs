using System;
using System.IO;
namespace ConsoleApp20 
{
    class FileRead
    {
        public static void main()
        {
            String fileName;
            while (true)
            {
                Console.WriteLine("\n-----------MENU---------------\n");
                Console.WriteLine(" \n 1.create a file");
                Console.WriteLine("\n2.existence of the file");
                Console.WriteLine("\n 3.read the contents of the file");
                Console.WriteLine("\n 4. exit");
                Console.WriteLine("\n enter your choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("\n enter the file name to create:");
                        fileName = Console.ReadLine();
                        Console.WriteLine("\n Write the contents to the file:\n");
                        String r = Console.ReadLine();
                        using (StreamWriter fileStr = File.CreateText(fileName))

                            fileStr.WriteLine(r);

                        Console.WriteLine("file is created....");
                        break;
                    case 2:
                        Console.Write("\n Enter the file name:");
                        fileName = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            Console.WriteLine(" file exists....");
                        }
                        else
                        {
                            Console.WriteLine(" file does not exist in the current directory!");
                        }
                        break;
                    case 3:
                        Console.Write("Enter the file name to read the contents:\n");
                        fileName = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            using (StreamReader sr = File.OpenText(fileName))
                            {
                                string s = " ";
                                Console.WriteLine("Here is the content of the file:");
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine("");
                            }

                        }
                        else
                        {
                            Console.WriteLine("File does not exists");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n Existing....");
                        return;
                    default:
                        Console.WriteLine("\n Invalid Choice");
                        break;
                }
            }

        }


    }
}
