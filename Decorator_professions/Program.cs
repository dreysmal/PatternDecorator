﻿using System;
using System.Windows.Forms;

namespace Decorator_professions
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Presenter presenter = new Presenter(form1);
            Application.Run(form1);
        }
    }
}
