using System;

namespace ConsoleApp16 
{
    class SumOfDiagonals 
    {
        static void Main(string[]args)
        {
            int MaxRow, MaxCol, sum = 0;
            int[,] matrix;
            Console.WriteLine("\n------SUM OF DIAGONAL OF A MATRIX-------\n");
            Console.Write("\n Enter the number of rows;");
            MaxRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n enter the number of columns:");
            MaxCol = Convert.ToInt32(Console.ReadLine());
            if(MaxRow!=MaxCol)
            {
                Console.WriteLine(" \n the dimensions enterd are not of square matrix:");
                Console.WriteLine("\n Exiting the program:");
                return;
            }
            matrix = new int[MaxRow, MaxCol];
            for(int i=0;i<MaxRow;i++)
            {
                for (int j = 0; j < MaxCol; j++)
                {
                    Console.Write("\nEnter the ({0},{1}) the element of the matrix:",(i+1),(j+1));
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine()); 
                }

            }
            Console.WriteLine("\n The entreed matrix is:");
            for(int i=0;i<MaxRow;i++)
            {
                for(int j=0;j<MaxCol;j++)
                {
                    Console.Write(" " + matrix[i, j]);
                    if(i==j)
                    {
                        sum += matrix[i, j];
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine("\n The sum of Diagonal is " + sum);
        }
    }
}
