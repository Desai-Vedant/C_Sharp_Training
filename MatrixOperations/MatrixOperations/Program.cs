using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MatrixOperations
{
    internal class Program
    {
        // Initialize Random
        static Random randNum = new Random();

        // Method to initialize array with random values in range (0,10)
        static int[,] MatrixGenerator(int rows, int columns) {

            //Creating 2d Array
            int[,] twoDimensionalArray = new int[rows, columns];

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    twoDimensionalArray[x, y] = randNum.Next(0, 10);
                }
            }

            return twoDimensionalArray;
        }

        // Method to Print array
        static void MatrixPrinter(int[,] matrix) {
            if (matrix==null) { Console.WriteLine("No Matrix Found!"); return; };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + "  ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] testMatrix1 = MatrixGenerator(4,4);
            int[,] testMatrix2 = MatrixGenerator(4,4);
            Console.WriteLine("Matrix 1 : ");
            MatrixPrinter(testMatrix1);
            Console.WriteLine("\nMatrix 2 : ");
            MatrixPrinter(testMatrix2);
            Console.WriteLine("\nAddition is : ");
            MatrixPrinter(MatrixOperations.MatrixAddition(testMatrix1, testMatrix2));
            Console.WriteLine("\nSubstraction is : ");
            MatrixPrinter(MatrixOperations.MatrixSubstraction(testMatrix1, testMatrix2));
            Console.WriteLine("\nMultiplication is : ");
            MatrixPrinter(MatrixOperations.MatrixMultiplication(testMatrix1, testMatrix2));
            Console.WriteLine("\nTranspose of Matrix 1 :");
            MatrixPrinter(MatrixOperations.MatrixTranspose(testMatrix1));
        }
    }
}
