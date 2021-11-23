using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину окружности в сантиметрах: ");
            double lenght = Convert.ToDouble(Console.ReadLine());
            double radius = lenght / (2 * Math.PI);
            double square = radius * radius * Math.PI / 10000;
            Console.Write("Радиус окружности равен {0}", Math.Round(radius, 1));
            Console.WriteLine(" сантиметров.");
            Console.Write("Площадь круга равна {0}", Math.Round(square, 2));
            Console.WriteLine(" кв.метров.");
            Console.Write("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}