using System;

namespace checkPass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Киселев Денис
            //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.На выходе истина, если прошел авторизацию,
            //и ложь, если не прошел(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу:
            //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.

            const string holdedLogin = "root";
            const string holdedPass = "GeekBrains";

            Console.WriteLine("  Здравствуйте! Введите логин и пароль.");


            int count = 0;
            int maxCount = 3;
            string login;
            string pass;

            CheckPass(holdedLogin, holdedPass, count, maxCount, out login, out pass);

        }

        private static void CheckPass(string holdedLogin, string holdedPass, int count, int maxCount, out string login, out string pass)
        {
            do
            {
                Console.Write("\nВведите логин:");
                login = Console.ReadLine();

                Console.Write("\nВведите пароль:");
                pass = Console.ReadLine();

                count++;

                if (login == holdedLogin && pass == holdedPass)
                {
                    Console.WriteLine("\n-----------------\nВы авторизованы!!!");
                    count = 3;
                }
                else
                {
                    Console.WriteLine($"\nНвереная пара логин/пароль\nУ вас осталось {maxCount - count} попыток");
                }
            }
            while (count < maxCount);
        }
    }
}
