using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    internal class MatrixOperations
    {
        // Method to add two matrix
        public static int[,] MatrixAddition(int[,] matrix1, int[,] matrix2) {
            if (matrix1 == null || matrix2 == null || matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1)) return null;
            int[,] SolutionMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(0)];
            for (int i = 0;i<matrix1.GetLength(0); i++)
            {
                for (int j = 0;j<matrix2.GetLength(1); j++)
                {
                    SolutionMatrix[i, j] = matrix1[i,j]+ matrix2[i,j];
                }
            }
            return SolutionMatrix;
        }

        // Method to substract two matrix
        public static int[,] MatrixSubstraction(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1 == null || matrix2 == null || matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1)) return null;
            int[,] SolutionMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(0)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    SolutionMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return SolutionMatrix;
        }

        // Method to multiply two matrix
        public static int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0)) return null;
            int[,] Solution = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Solution[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        Solution[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return Solution;
        }

        // Method to get Transpose of a Matrix
        public static int[,] MatrixTranspose(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows != cols) return null;
            int[,] Solution = new int[rows, cols];
            for(int i = 0; i< rows; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if(i == j)
                    {
                        Solution[i,j] = matrix[i,j];
                    }
                    else
                    {
                        Solution[i, j] = matrix[j, i];
                        Solution[j, i] = matrix[i, j];
                    }
                }
            }
            return Solution;
        }
    }
}
