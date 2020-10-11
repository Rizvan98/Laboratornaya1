using System;

namespace Laboratornaya1
{
    class Program
    {
        static void Main(string[] args)
        {
            double f, a, b, y, x;

            Console.Write("Введите a > ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите b > ");
            b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите y > ");
            y = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите x > ");
            x = Convert.ToSingle(Console.ReadLine());

            f = a*1 + Math.Sin(b) - a * (x + y * 5);

            Console.WriteLine("\n\n");

            Console.WriteLine("Денежный формат {0:C} \n", f);
            Console.WriteLine("Экспоменциальный формат {0:E} \n", f);
            Console.WriteLine("Формат с фиксированной запятой {0:F3, 7} \n", f);
            Console.WriteLine("Общий формат {0:G} \n", f);
            Console.WriteLine("Числовой формат {0:N} \n", f);
            Console.WriteLine("Процентный формат {0:P} \n", f);

        }
    }
}
