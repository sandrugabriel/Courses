﻿using Courses.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

          //  ControllerCourses controllerCourses = new ControllerCourses();
         //   MessageBox.Show(controllerCourses.stergere(2));
          //  controllerCourses.deleteCourese(2);
        }
    }
}
