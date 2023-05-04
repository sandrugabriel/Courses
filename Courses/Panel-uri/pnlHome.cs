using Courses.Controllers;
using Courses.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Courses.Panel_uri
{
    internal class pnlHome:Panel
    {

        Form1 form;

        private List<Course> courses;

        ControllerCourses controllerCourses;

        private int id;

        public pnlHome(Form1 form1, int id1)
        {

            form = form1;
            id = id1;
            courses = new List<Course>();
            controllerCourses = new ControllerCourses();
            this.form.MinimumSize = new Size(1700,1000);
            this.form.MaximumSize = new Size(1700,1000);
            this.Size = new System.Drawing.Size(1205, 758);
            this.Location = new System.Drawing.Point(120, 100);
            this.Name = "pnlHome";

            courses = controllerCourses.getcourses();

            createCard(3);
        }

        public void createCard(int nrCollums)
        {

            this.Controls.Clear();

            int x = 10, y = 43, ct = 0;

            foreach (Course course in courses)
            {
                ct++;
                pnlCard pnlcard = new pnlCard(form,course);
                pnlcard.Location = new System.Drawing.Point(x, y);
                this.Controls.Add(pnlcard);

                x += 400;

                if (ct % nrCollums == 0)
                {
                    x = 10;
                    y += 210;
                }
                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }
            }


        }






    }
}
