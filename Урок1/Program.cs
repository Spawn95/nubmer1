﻿using System;

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
/*Немного посмотрел в интернете, нашел как в несколько кликов на гитхаб выгружаться. Добавил в VS расширение гитхаба) Надеюсь так можно. 
Так же посмотрел как сделать чтобы выводилась только дата, без времени. 
Многострочные комментарии отделяются от кода последовательностью символом /* в начале и /* в конце комментария. 
у Вас вот ------------------------------------------------------------------------------| тут ,небольшая опечатка в самом уроке ) */
