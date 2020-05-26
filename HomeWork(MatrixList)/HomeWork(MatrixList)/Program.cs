using System;

namespace HomeWork_MatrixList_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность квадратной матрицы: ");
            int Qnum = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            MatrixList<MatrixList<int>> matrixlist1 = GetMassiveList(Qnum);
            MatrixList<MatrixList<int>> matrixlist2 = GetMassiveList(Qnum);
            Console.WriteLine("Первая матрица: ");
            PrintMatrix(matrixlist1, Qnum);
            Console.WriteLine("Вторая матрица: ");
            PrintMatrix(matrixlist2, Qnum);
            Console.WriteLine("Сумма матриц: ");
            MatrixList<MatrixList<int>> sum = SumMatrix(matrixlist1, matrixlist2, Qnum);
            PrintMatrix(sum, Qnum);
            Console.WriteLine("Произведение матриц: ");
            MatrixList<MatrixList<int>> multiply = MultiplyMatrix(matrixlist1, matrixlist2, Qnum);
            PrintMatrix(multiply, Qnum);
            MatrixList<MatrixList<int>> transposeMatrix1 = TransposeMatrix(matrixlist1, Qnum);
            Console.WriteLine("Первая транспонированная матрица: ");
            PrintMatrix(transposeMatrix1, Qnum);
            MatrixList<MatrixList<int>> transposeMatrix2 = TransposeMatrix(matrixlist2, Qnum);
            Console.WriteLine("Вторая транспонированная матрица: ");
            PrintMatrix(transposeMatrix2, Qnum);
        }
        static MatrixList<MatrixList<int>> TransposeMatrix(MatrixList<MatrixList<int>> matrixlist, int Qnum)
        {
            MatrixList<MatrixList<int>> transpose = new MatrixList<MatrixList<int>>();
            for (int i = 0; i < Qnum; i++)
            {
                MatrixList<int> act = new MatrixList<int>();
                for (int j = 0; j < Qnum; j++)
                {
                    act.ElemAdd(matrixlist.Prepare(j).data.GetNumber(i));
                }
                transpose.ElemAdd(act);
            }
            return transpose;
        }
        static MatrixList<MatrixList<int>> MultiplyMatrix(MatrixList<MatrixList<int>> matrixlist1, MatrixList<MatrixList<int>> matrixlist2, int Qnum)
        {
            MatrixList<MatrixList<int>> multiply = new MatrixList<MatrixList<int>>();
            int elem = 0;
            for (int i = 0; i < Qnum; i++)
            {
                MatrixList<int> act = new MatrixList<int>();
                for (int j = 0; j < Qnum; j++)
                {
                    for (int k = 0; k < Qnum; k++)
                    {
                        elem += matrixlist1.Prepare(i).data.GetNumber(k) * matrixlist2.Prepare(k).data.GetNumber(j);
                    }
                    act.ElemAdd(elem);
                    elem = 0;
                }
                multiply.ElemAdd(act);
            }
            return multiply;
        }
        static MatrixList<MatrixList<int>> SumMatrix(MatrixList<MatrixList<int>> matrixlist1, MatrixList<MatrixList<int>> matrixlist2, int Qnum)
        {
            MatrixList<MatrixList<int>> sum = new MatrixList<MatrixList<int>>();
            for (int i = 0; i < Qnum; i++)
            {
                MatrixList<int> act1 = matrixlist1.Prepare(i).data;
                MatrixList<int> act2 = matrixlist2.Prepare(i).data;
                MatrixList<int> Act = new MatrixList<int>();
                for (int j = 0; j < Qnum; j++)
                {
                    Act.ElemAdd(act1.GetNumber(j) + act2.GetNumber(j));
                }
                sum.ElemAdd(Act);
            }
            return sum;
        }
        static MatrixList<MatrixList<int>> GetMassiveList(int Qnum)
        {
            Random random = new Random();
            MatrixList<MatrixList<int>> matrixlist = new MatrixList<MatrixList<int>>();
            for (int i = 0; i < Qnum; i++)
            {
                MatrixList<int> act = new MatrixList<int>();
                for (int j = 0; j < Qnum; j++)
                {
                    act.ElemAdd(random.Next(0, 2));
                }
                matrixlist.ElemAdd(act);
            }
            return matrixlist;
        }
        static void PrintMatrix(MatrixList<MatrixList<int>> matrixlist, int Qnum)
        {
            for (int i = 0; i < Qnum; i++)
            {
                MatrixList<int> act = matrixlist.Prepare(i).data;
                act.PrintMatrix();
                Console.WriteLine();
            }
        }
    }
}
