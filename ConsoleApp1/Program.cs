using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выводим меню с операциями
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            // Получаем ввод пользователя
            int operation = int.Parse(Console.ReadLine());

            // Вводим два числа
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());

            // Выполняем выбранную операцию
            double result;
            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    return;
            }

            // Выводим результат
            if (result != 0)
            {
                Console.WriteLine($"Результат: {result}");
            }
        }
    }
}
