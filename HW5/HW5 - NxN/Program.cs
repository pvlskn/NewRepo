using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:

1 0 1 0 1

0 1 0 1 0

1 0 1 0 1

0 1 0 1 0

1 0 1 0 1*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целочисленное значение");
        int N = Convert.ToInt32(Console.ReadLine());
        int[,] NxN = new int[N, N];
        for (int i=0; i < N; i++)
        {
           for (int j = 0; j < N; i++)
            {
                if ((i + j) % 2 == 0) Console.WriteLine("1"); // Для чётной суммы индекса строки и столбца поставить 1, для нечётной - 0
                else Console.WriteLine("0");
            }
            Console.WriteLine();

        }

        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}
