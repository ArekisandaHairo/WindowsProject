﻿using System;
using System.Collections.Generic;

namespace WindowSoul
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Авторизация
            List<View> windows = new List<View>();

            // AvtoReg avtoReg = new AvtoReg(0, 0, Console.WindowWidth - 1, Console.WindowHeight - 1);
            // avtoReg.draw();
            // avtoReg.Rabota();
            // Console.ReadKey();

            Console.Title = "Hairo";
            // windows.Add(new Window(0, 0, 10, 10, "Okno0", true));
            // windows.Add(new Window(20, 10, 40, 15, "Okno1", true));
            windows.Add(new Window(30, 5, 45, 15, "Okno2", true));
            Work work = new Work(windows, 0);
            work.PrintWin();
            work.Window_Comands();
            work.Exit();

            
            /*
             *  Почему-то когда задаю позицию для текста, он работает не корректно,
             * и на каждой итерации остаётся на одной позиции (пошло всё нах#й оно работает)
             * 
             *  Список Вьюшек в контейнере( для отрисовок )
             *  Реализовать нажатие кнопки
             *  Метод пак
             *  Сделать увеличение окна до полного экрана допилить
             *  Сделать скрытие окна ( отрисовка только хэдера )
             *  Отруб окна полностью
             *  Password, mail, phone, text - тип текстов
             * users.txt  -> ( id, mail, password(hash), FIO )
             * shedule.txt -> ( id, user_id, pacient_id, date )
             * pacient.txt -> ( id, FIO, time, time )
            */
        }
    }
}