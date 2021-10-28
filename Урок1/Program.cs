using System;

namespace Урок1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написание простой программы
            Console.WriteLine("Напиши мне своё имя"); // Запрос имени
            string userName = Console.ReadLine(); // Считывание параметра
            var Date = DateTime.Now; // Значение даты
            Console.WriteLine($"Привет, {userName}, сегодня {Date:d} !"); // Ответ на запрос
        }
    }
}
