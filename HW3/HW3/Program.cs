using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        //Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. Найти координаты его четвертой вершины.
        static void Main(string[] args)
        {
            Console.Write("Введите координату X первой вершины прямоугольника: ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y первой вершины: ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату X второй вершины: ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y второй вершины: ");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату X третей вершины: ");
            int X3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y третей вершины: ");
            int Y3 = Convert.ToInt32(Console.ReadLine());
            int X4;
            int Y4;
            if (X1 == X2 && X1 != X3)
            {
                int X4 = X3;
            }
            else if (X1 == X3 && X1 != X2)
            {
                int X4 = X2;
            }
            else
            {
                Console.WriteLine("Нельзя получить прямоугольник со сторонами, параллельными координатным осям.");
            }
            if (Y1 == Y2 && Y1 != Y3)
            {
                int Y4 = Y3;
            }
            else if (Y1 == Y3 && Y1 != Y2)
            {
                int Y4 = Y2;
            }
            else
            {
                Console.WriteLine("Нельзя получить прямоугольник со сторонами, параллельными координатным осям.");
            }
            Console.WriteLine("Координаты четвёртой вершины прямоугольника параллельного координатным осям  ({0},{1})", X4, Y4);
            Console.Write("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
