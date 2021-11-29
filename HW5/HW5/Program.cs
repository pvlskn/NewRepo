using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Сформировать одномерный массив из 7 элементов. Заполнить массив числами, 
вводимыми с клавиатуры, определить среднее арифметическое элементов.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите семь чисел (через Enter)");
        int Average = 0;
        int[] array = new int[7];
        array[0] = Convert.ToInt32(Console.ReadLine());
        array[1] = Convert.ToInt32(Console.ReadLine());
        array[2] = Convert.ToInt32(Console.ReadLine());
        array[3] = Convert.ToInt32(Console.ReadLine());
        array[4] = Convert.ToInt32(Console.ReadLine());
        array[5] = Convert.ToInt32(Console.ReadLine());
        array[6] = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 7; i++)
            {
            Average += array[i];
            }
        Console.WriteLine("Среднее арифмитическое равно {0}.", Average / 7);
        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}
