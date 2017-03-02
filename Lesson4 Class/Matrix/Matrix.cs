using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Задание 2 (обязательное). 
Создать класс Matrix, в котором основным полем выступает двумерный массив.Данный класс должен позволять удобно 
и понятно работать с матрицами(двумерными массивами). Класс должен обеспечивать работу как на уровне класса(статические методы) 
так и на уровне объекта.
В классе обязательно должны быть реализованы:
- методы:
методы инициализации матрицы значениями по умолчанию, случайными значениями, значениями вводимыми пользователем; 
метод, позволяющий поменять местами элементы главной диагонали матрицы на элементы противоположенной диагонали матрицы;
методы перемножения матриц;
метод транспонирования матрицы; 
метод сортировки матрицы(от элемента (0,0) до(M-1, N-1) по столбцам или строкам)).
- свойства, позволяющие получать минимальный/максимальный элементы матрицы, свойства – количество строк/столбцов, 
а также другие свойства, которые отсутствуют в библиотеке.NET (при работе с двумерным массивом).   
Проверить работоспособность созданного класса в методе Main().

Основные требования: 
- проектирование типа(сделать его наиболее функциональным и удобным в применении);
- правильно оформить тип в соответствии с требованиями.*/

namespace Matrix
{
    internal class Matrix
    {
        #region FIELDS
        int[,] matrix;
        int rows;
        int columns;
        #endregion

        #region CTORS
        /// <summary>
        /// Constructor of non-square matrix
        /// </summary>
        /// <param name="M_">Quantity of rows</param>
        /// <param name="N_">Quantity of columns</param>
        public Matrix(int M_, int N_)
        {
            rows = M_;
            columns = N_;
            matrix = new int[rows, columns];
        }

        /// <summary>
        /// Constructor of square matrix
        /// </summary>
        /// <param name="M_">Quantity of rows & columns</param>
        public Matrix(int M_)
        {
            rows = M_;
            columns = rows;
            matrix = new int[rows, columns];
        }
        #endregion

        #region METHODS
        public void InitializeByDefault(int def)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = def;
        }

        public void Initialize()
        {
            Console.WriteLine("Enter ints to initialize the matrix {0} x {1}:", rows, columns);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j <columns; j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
        }

        public void InitializeRandomly()
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = rnd.Next();
        }

        public void InitializeRandomly(int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = rnd.Next(min, max);
        }

        /// <summary>
        /// Swaps elements of main and secondary diagonals
        /// </summary>
        /// <returns>false if it isn't a square matrix
        /// and true if it is</returns>
        public bool SwapDiagonalElements()
        {
            if (rows != columns)
                return false;
            int i = 0, k = rows - 1;
            int swapBuf;
            for (int j = 0; j < rows; j++)
            {
                swapBuf = matrix[i, j];
                matrix[i++, j] = matrix[k, j];
                matrix[k--, j] = swapBuf;
            }
            return true;
        }

        //public bool Composition(ref Matrix matrix1, ref Matrix matrix2)
        //{
        //    if (matrix1.rows != matrix2.columns)
        //        return false;
        //    for(int i = 0;)
        //    return true;
        //}
        #endregion

        #region STATIC_METHODS
        static public void Print(ref Matrix obj)
        {
            for (int i = 0; i < obj.rows; i++)
            {
                for (int j = 0; j < obj.columns; j++)
                    Console.Write("{0,4} ", obj.matrix[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
#endregion
    }
}
