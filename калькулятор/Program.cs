using System;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Сложить 2 числа\r\n" + "2. Вычесть первое из второго\r\n" + "3. Перемножить два числа\r\n" +"4. Разделить первое на второе\r\n" +"5. Возвести в степень N первое число\r\n" +"6. Найти квадратный корень из числа\r\n" + "7. Найти 1 процент от числа\r\n" +"8. Найти факториал из числа\r\n" +"9. Выйти из программы");
                Console.WriteLine("Выберите действие над числами");
                int g = Convert.ToInt32(Console.ReadLine());
                if (g == 9)
                {
                    break;
                }
                int b = 0;
                Console.WriteLine("Введите первое число");
                int a = Convert.ToInt32(Console.ReadLine());
                if (g <= 5)
                {
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                double d = 0;
                if (g == 1)
                {
                    d = a + b;
                }
                if (g == 2)
                {
                    d = b - a;
                }
                if (g == 3)
                {
                    d = b * a;
                }
                if (g == 4)
                {
                    d = a / b;
                }
                if (g == 5)
                {
                    d = (Math.Pow(a, b));
                }
                if (g == 6)
                {
                    d = (Math.Sqrt(a));
                }
                if (g == 7)
                {
                    d = a / 100;
                }
                if (g == 8)
                {
                    int l = 1;
                    int i = 1;
                    for (; i <= a; ++i)
                    {
                        l = l * i;
                        d = l;
                    }                                   
                }
                
                Console.WriteLine(d);
                Console.WriteLine("Для продолжения работы нажмите Enter");
                string p = Console.ReadLine();
                Console.Clear();
               
            }
             
        }
    }
}