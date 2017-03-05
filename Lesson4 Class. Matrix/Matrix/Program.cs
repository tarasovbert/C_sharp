using System;

/*Задание 2 (обязательное). 
Создать класс Matrix, в котором основным полем выступает двумерный массив.Данный класс должен позволять удобно 
и понятно работать с матрицами(двумерными массивами). Класс должен обеспечивать работу как на уровне класса(статические методы) 
так и на уровне объекта.
В классе обязательно должны быть реализованы:
- методы:
методы инициализации матрицы значениями по умолчанию, случайными значениями,  значениями вводимыми пользователем; 
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
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int columns;
            int answerInt1;
            int answerInt2;
            Matrix matrix1 = new Matrix(0);
            Matrix matrix3;
            Matrix matrix2;

            Console.WriteLine("Matrix of integers." + Environment.NewLine + Environment.NewLine
                + "Enter the quantity of rows to initialize the matrix:");
            while (!Int32.TryParse(Console.ReadLine(), out rows)) { }
            Console.WriteLine("Enter the quantity of columns to initialize the matrix:");
            while (!Int32.TryParse(Console.ReadLine(), out columns)) { }
            matrix1 = new Matrix(rows, columns);
            Console.WriteLine("Enter the value to fill all matrix:");
            while (!Int32.TryParse(Console.ReadLine(), out answerInt1)) { }
            matrix1.InitializeByDefault(answerInt1);
            Console.WriteLine("The matrix is:");
            Matrix.Print(ref matrix1);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Enter the quantity of rows and coulumns to initialize the matrix:");
            while (!Int32.TryParse(Console.ReadLine(), out rows)) { }
            while (!Int32.TryParse(Console.ReadLine(), out columns)) { }
            matrix2 = new Matrix(rows, columns);
            Console.WriteLine("Enter lower and higher boarders to initialize the matrix with random values: ");
            while (!Int32.TryParse(Console.ReadLine(), out answerInt1)) { }
            while (!Int32.TryParse(Console.ReadLine(), out answerInt2)) { }
            matrix2.InitializeRandomly(answerInt1, answerInt2);
            Console.WriteLine("The matrix is:");
            Matrix.Print(ref matrix2);

            Console.WriteLine("The transposed matrix is:");
            matrix3 = Matrix.Copy(matrix2);
            Matrix.Transpose(ref matrix3);
            Matrix.Print(ref matrix3);

            Console.WriteLine("Sorted by rows matrix is:");
            matrix3 = Matrix.Copy(matrix2);
            Matrix.SortByRows(ref matrix3);
            Matrix.Print(ref matrix3);

            Console.WriteLine("Sorted by coulumns matrix is:");
            matrix3 = Matrix.Copy(matrix2);
            Matrix.SortByColumns(ref matrix3);
            Matrix.Print(ref matrix3);

            Console.WriteLine("Finally sorted matrix is:");
            Matrix.Sort(ref matrix3);
            Matrix.Print(ref matrix3);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Enter the quantity of rows and coulumns to initialize the square matrix:");
            while (!Int32.TryParse(Console.ReadLine(), out rows)) { }
            matrix2 = new Matrix(rows);
            matrix2.Initialize();
            Matrix.Print(ref matrix2);

            Console.WriteLine(Environment.NewLine + "Now let's swap elements of main and secondary diagonals of the matrix:");
            matrix1 = Matrix.Copy(matrix2);
            matrix1.SwapDiagonalElements();
            Matrix.Print(ref matrix1);

            Console.WriteLine(Environment.NewLine + "Now let's multiplate that two marices. The result matrix is:");
            matrix3 = matrix1 * matrix2;
            Matrix.Print(ref matrix3);
        }
    }
}
