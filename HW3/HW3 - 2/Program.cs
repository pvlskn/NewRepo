using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Дано целое число в диапазоне 20–69, определяющее возраст (в годах). Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.
namespace HW3
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Введите целое число в диапазоне 20–69: ");
            int age = Convert.ToInt16(Console.ReadLine());            
            int ageFirstSign = age / 10;
            int ageSecondSign = age - 10 * ageFirstSign;
            string ageFirstWord = Convert.ToString(0);
                switch (ageFirstSign)
            {
                case 2:
                    {
                        ageFirstWord = "Двадцать";
                        break;
                    }
                case 3:
                    {
                        ageFirstWord = "Тридцать";
                        break;
                    }
                case 4:
                    {
                        ageFirstWord = "Сорок";
                        break;
                    }
                case 5:
                    {
                        ageFirstWord = "Пятьдесят";
                        break;
                    }
                case 6:
                    {
                        ageFirstWord = "Шестьтьдесят";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка. Введёно число вне заданного диапозона.");
                        break;
                    }
            }
            string ageSecondWord = Convert.ToString(0);
            switch(ageSecondSign)
            {
                case 0:
                    {
                        ageSecondWord = "лет";
                        break;
                    }
                case 1:
                    {
                        ageSecondWord = "один год";
                        break;
                    }
                case 2:
                    {
                        ageSecondWord = "два года";
                        break;
                    }
                case 3:
                    {
                        ageSecondWord = "три года";
                        break;
                    }
                case 4:
                    {
                        ageSecondWord = "четыре года";
                        break;
                    }
                case 5:
                    {
                        ageSecondWord = "пять лет";
                        break;
                    }
                case 6:
                    {
                        ageSecondWord = "шесть лет";
                        break;
                    }
                case 7:
                    {
                        ageSecondWord = "семь лет";
                        break;
                    }
                case 8:
                    {
                        ageSecondWord = "восемь лет";
                        break;
                    }
                case 9:
                    {
                        ageSecondWord = "девять лет";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка. Введёно число вне заданного диапозона.");
                        break;
                    }
            }
            if (age > 19 && age < 70)
            {
                Console.WriteLine("{0} - {1} {2}", age, ageFirstWord, ageSecondWord);
                Console.WriteLine("Нажмите любую клавишу для выхода.");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Нажмите любую клавишу для выхода.");
                Console.ReadKey();
            }
        }
    }
}
