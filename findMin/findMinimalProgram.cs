using System;

namespace lesson2
{
    class findMinimalProgram
    {
        static void Main(string[] args)
        {
            // Киселев Денис
            // Написать метод, возвращающий минимальное из трёх чисел.

            Console.WriteLine("  Здравствуйте! Эта программа находит минимум из 3 чисел. Введите числа.");

            Console.Write("\nПервое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\nВторое число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("\nТретье число: ");
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine($"\nПервое число нименьшее: {a}");

            }
            else if (b < c)
            {
                Console.WriteLine($"\nВторое число нименьшее: {b}");

            }
            else
            {
                Console.WriteLine($"\nТретье число нименьшее: {c}");
            }

            Console.Read();
        }
    }
}
