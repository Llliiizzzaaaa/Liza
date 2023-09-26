using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Шанаурина Елизавета Григорьевна, ИУ5Ц-54Б"); //ФИО Разработчкика
            double a, b, c, y1, y2, x1, x2, x3, x4, d;
            bool an, bn, cn;
            Console.WriteLine("Начальное значение ax^4+bx^2+c=0");
            Console.WriteLine("Введите a, должна быть не равна нулю");
            do
            {
                an = Double.TryParse(Console.ReadLine(), out a);
                if (!(an))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод");
                    Console.ResetColor();
                }
            }
            while (!(an));
            Console.WriteLine("Введите b");
            do
            {
                bn = Double.TryParse(Console.ReadLine(), out b);
                if (!(bn))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод");
                    Console.ResetColor();
                }

            }
            while (!(bn));
            Console.WriteLine("Введите c");
            do
            {
                cn = Double.TryParse(Console.ReadLine(), out c);
                if (!(cn))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод");
                    Console.ResetColor();
                }

            }
            while (!(cn));
            Console.WriteLine("{0}x^4+{1}x^2+{2}=0", a, b, c);
            d = (b * b) - 4 * a * c;
            y1 = ((-1 * b - Math.Sqrt(d)) / (2 * a));
            y2 = ((-1 * b + Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("Ответ:");// если дискриминант = 0 то один корень только ( один у, два х)- добавить условие 
            if (y1 > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                x1 = -Math.Sqrt(y1);
                x2 = Math.Sqrt(y1);
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
                Console.ResetColor(); // сбрасываем в стандартный
            }
            if (y1 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                x1 = -Math.Sqrt(y1);
                x2 = Math.Sqrt(y1);
                Console.WriteLine("x1={0}", x1);
                Console.ResetColor(); // сбрасываем в стандартный
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                x1 = -Math.Sqrt(y1);
                x2 = Math.Sqrt(y1);
                Console.WriteLine("корней нет");

                Console.ResetColor(); // сбрасываем в стандартный
            }
            if (y2 != y1)
            {
                if (y2 > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                    x3 = -Math.Sqrt(y2);
                    x4 = Math.Sqrt(y2);
                    Console.WriteLine("x3={0}, x4={1}", x3, x4);
                    Console.ResetColor(); // сбрасываем в стандартный
                }
                if (y2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                    x1 = -Math.Sqrt(y1);
                    x2 = Math.Sqrt(y1);
                    Console.WriteLine("x1={0}", x1);
                    Console.ResetColor(); // сбрасываем в стандартный
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                    x3 = -Math.Sqrt(y2);
                    x4 = Math.Sqrt(y2);
                    Console.WriteLine("корней нет");
                    Console.ResetColor(); // сбрасываем в стандартный
                }
            }
            Console.WriteLine("y1={0}, y2={1}", y1, y2);
            Console.ReadLine();
        }
    }

//Для формальности я внесла изменения