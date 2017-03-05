using System;

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
        private int[,] matrix;
        private int rows;
        private int columns;
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

        #region PROPERTIES
        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }
        
        public int Columns
        {
            get { return columns; }
            set { columns = value; }
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
            int answerInt;
            Console.WriteLine("Enter ints to initialize the matrix {0} x {1}:", rows, columns);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    while (!Int32.TryParse(Console.ReadLine(), out answerInt)) { }
                    matrix[i, j] = answerInt;
                }
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
            if (min > max)
            {
                min += max;
                max = min - max;
                min -= max;
            }
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
        #endregion

        #region STATIC_METHODS
        public static void Print(ref Matrix obj)
        {
            for (int i = 0; i < obj.rows; i++)
            {
                for (int j = 0; j < obj.columns; j++)
                    Console.Write("{0,5} ", obj.matrix[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Transpose(ref Matrix obj)
        {
            Matrix transposed = new Matrix(obj.columns, obj.rows);
            for (int i = 0; i < transposed.rows; i++)
                for (int j = 0; j < transposed.columns; j++)
                    transposed.matrix[i, j] = obj.matrix[j, i];
            obj = transposed;
        }

        public static void SortByRows(ref Matrix obj)
        {
            int[] sortedRow = new int[obj.columns];
            for (int i = 0; i < obj.rows; i++)
            {
                for (int j = 0; j < obj.columns; j++)
                    sortedRow[j] = obj.matrix[i, j];
                Array.Sort(sortedRow);
                for (int j = 0; j < obj.columns; j++)
                    obj.matrix[i, j] = sortedRow[j];
            }
        }


        public static void SortByColumns(ref Matrix obj)
        {
            int[] sortedColumn = new int[obj.rows]; ;
            for (int i = 0; i < obj.columns; i++)
            {
                for (int j = 0; j < obj.rows; j++)
                    sortedColumn[j] = obj.matrix[j, i];
                Array.Sort(sortedColumn);
                for (int j = 0; j < obj.rows; j++)
                    obj.matrix[j, i] = sortedColumn[j];
            }
        }

        public static void Sort(ref Matrix obj)
        {
            int[] sorted = new int[obj.rows * obj.columns];
            int k = 0;
            for (int i = 0; i < obj.rows; i++)
                for (int j = 0; j < obj.columns; j++)
                    sorted[k++] = obj.matrix[i, j];
            Array.Sort(sorted);
            k = 0;
            for (int i = 0; i < obj.rows; i++)
                for (int j = 0; j < obj.columns; j++)
                    obj.matrix[i, j] = sorted[k++];
        }

        public static Matrix Copy(Matrix obj)
        {
            Matrix Copy = new Matrix(obj.rows, obj.columns);
            for (int i = 0; i < obj.rows; i++)
            {
                for (int j = 0; j < obj.columns; j++)
                {
                    Copy.matrix[i, j] = obj.matrix[i, j];
                }
            }
            return Copy;
        }
        #endregion

        #region OPERATORS

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix3;
            if (matrix1.rows != matrix2.columns)
                throw new ExceptionExit("Matrices can't be composed 'cause rows of first matrix is not equal to columns of second matrix.");
            else
            {
                int length = matrix1.rows;
                matrix3 = new Matrix(length, length);
                for (int i = 0; i < length; i++)
                    for (int j = 0; j < length; j++)
                        for (int k = 0; k < length; k++)
                            matrix3.matrix[i, j] += matrix1.matrix[i, k] * matrix2.matrix[k, j];
            }
            return matrix3;
        }
        #endregion
    }
}

