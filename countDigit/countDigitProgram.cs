using System;

namespace countDigit
{
    class countDigitProgram
    {
        static void Main(string[] args)
        {
            // Киселев Денис
            // Написать метод подсчета количества цифр числа.

            Console.WriteLine("  Здравствуйте! Эта программа находит количество цифр в числе.");

            Console.Write("\nВведите число: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = number; i > 0; count++)
            {                
                i = i / 10;
            }

            Console.WriteLine($"\n\n Количество цифр числе {number} --> {count} ");
        }
    }
}
