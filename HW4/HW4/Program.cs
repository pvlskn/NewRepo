using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).
namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число ");
            int n = Convert.ToInt32(Console.ReadLine());
            int n2 = n*n;
            Console.Write("{0} x {0} = ", n);
            int i=1;
            while ( i != 2*n+1) 
            {
                if (i != 1)
                {
                    Console.Write("+ {0} ", i);
                }
                else
                { 
                    Console.Write("{0} ", i);
                }
                i = i + 2;
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
