using System;

namespace HomeTask_MatrixArray_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность квадратной матрицы: ");
            int Qnum = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Первая матрица: ");
            int[,] matrix1 = GetMatrix(Qnum);
            int[,] matrix2 = GetMatrix(Qnum);
            PrintMatrix(matrix1);
            Console.WriteLine("Вторая матрица: ");
            PrintMatrix(matrix2);
            Console.WriteLine("Сумма матриц: ");
            PrintMatrix(SumMatrix(matrix1, matrix2));
            Console.WriteLine("Произведение матриц: ");
            PrintMatrix(MultiplyMatrix(matrix1, matrix2));
            Console.WriteLine("Первая транспонированная матрица: ");
            PrintMatrix(TransposeMatrix(matrix1));
            Console.WriteLine("Вторая транспонированная матрица: ");
            PrintMatrix(TransposeMatrix(matrix2));
        }
        static int[,] GetMatrix(int Qnum)
        {
            Random random = new Random();
            int[,] array = new int[Qnum, Qnum];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 2);
                }
            }
            return array;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] SumMatrix(int[,] array, int[,] mas)
        {
            int[,] resultSummatrix = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < resultSummatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultSummatrix.GetLength(1); j++)
                {
                    resultSummatrix[i, j] = array[i, j] + mas[i, j];
                }
            }
            return resultSummatrix;
        }
        static int[,] MultiplyMatrix(int[,] array, int[,] mas)
        {
            int[,] resultMulmatrix = new int[array.GetLength(1), mas.GetLength(0)];
            for (int i = 0; i < resultMulmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMulmatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < resultMulmatrix.GetLength(1); k++)
                    {
                        resultMulmatrix[i, j] += array[k, i] * mas[j, k];
                    }
                }
            }
            return resultMulmatrix;
        }
        static int[,] TransposeMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i; j < array.GetLength(1); j++)
                {
                    int temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
            }
            return array;
        }
    }
}
