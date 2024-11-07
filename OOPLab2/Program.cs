using System;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування для коректної роботи з десятковими числами
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            // Налаштування для коректного відображення тексту
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Виведення інформації про лабораторну роботу
            Console.WriteLine("Лабораторна робота №2");
            Console.WriteLine("Виконав: Матящук Р.В., СТ-21");
            Console.WriteLine("Варіант №5");
            Console.WriteLine("Завдання 2");

            // Оголошення змінних
            double x, y, z, s;
            int t = 0;

            // Введення даних з перевіркою коректності
            do
            {
                do
                {
                    Console.Write("Введіть значення x: ");
                    if (Double.TryParse(Console.ReadLine(), out x))
                    {
                        t = 0;
                    }
                    else
                    {
                        Console.WriteLine("Некоректне значення, спробуйте знову.");
                        t = 1;
                    }
                } while (t != 0);

                do
                {
                    Console.Write("Введіть значення y: ");
                    if (Double.TryParse(Console.ReadLine(), out y))
                    {
                        t = 0;
                    }
                    else
                    {
                        Console.WriteLine("Некоректне значення, спробуйте знову.");
                        t = 1;
                    }
                } while (t != 0);

                do
                {
                    Console.Write("Введіть значення z: ");
                    if (Double.TryParse(Console.ReadLine(), out z))
                    {
                        t = 0;
                    }
                    else
                    {
                        Console.WriteLine("Некоректне значення, спробуйте знову.");
                        t = 1;
                    }
                } while (t != 0);

                // Обчислення значення s за формулою
                double numerator = 3.3 + Math.Tan(x) * (y / 2);
                double denominator = Math.Pow(x, 2) + Math.Pow(z, 3) + 4;
                s = numerator / denominator;

                // Виведення результату з точністю до трьох знаків після коми
                Console.WriteLine($"Результат s = {s:F3}\n");

            } while (s != 0); // Повтор до тих пір, поки s не стане рівним 0
        }
    }
}


