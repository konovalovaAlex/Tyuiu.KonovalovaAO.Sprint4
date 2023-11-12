using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint4.Task4.V3.Lib;
namespace Tyuiu.KonovalovaAO.Sprint4.Task4.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила Коновалова А. О. /СМАРТб-23-1 ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                   *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 4 до 9.             *");
            Console.WriteLine("* Найдите сумму нечетных элементов массива.                              *");
            Console.WriteLine("* 7, 9, 7, 8, 6,                                                         *");
            Console.WriteLine("* 4, 4, 4, 8, 6,                                                         *");
            Console.WriteLine("* 7, 9, 6, 7, 6,                                                         *");
            Console.WriteLine("* 7, 5, 4, 9, 8,                                                         *");
            Console.WriteLine("* 9, 6, 4, 9, 8,                                                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] mtrx = new int[rows, columns];
            Console.WriteLine("**************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СУММА НЕЧЕТНЫХ ЭЛЕМЕНТОВ МАССИВА РАВНА:                                 *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
