using Courses.Controllers;
using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses.Panel_uri
{
    internal class pnlSeeCourses:Panel
    {

        Form1 form;

        ControllerCourses controllerCourses;
        ControllerEnrolment controllerEnrolment;
        LinkLabel linkBack;

        private int id;

        List<Course> listmyCourses;
        List<int> listIdCourses;
        public pnlSeeCourses(Form1 form1, int id1)
        {
            form = form1;
            id = id1;
            controllerCourses = new ControllerCourses();
            listmyCourses = new List<Course>();
            listIdCourses = new List<int>();
            controllerEnrolment = new ControllerEnrolment();
            listmyCourses = controllerCourses.getcourses();
            listIdCourses = controllerEnrolment.getMyCoursesId(id);
            this.Size = new System.Drawing.Size(1205, 758);
            this.Location = new System.Drawing.Point(120, 100);
            this.Name = "pnlSeeCourses";

            this.linkBack = new LinkLabel();

            // linkBack
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F, System.Drawing.FontStyle.Regular);
            this.linkBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkBack.ForeColor = System.Drawing.Color.Black;
            this.linkBack.Location = new System.Drawing.Point(1000, 0);
            this.linkBack.Text = "Back";
            this.linkBack.BringToFront();
            this.linkBack.Click += new EventHandler(linkBack_Click);

            createCard(3);

        }

        private void linkBack_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlSeeCourses");
            this.form.Controls.Add(new pnlHome(form, id));


        }

        public void createCard(int nrCollums)
        {

            this.Controls.Clear();

            this.Controls.Add(this.linkBack);

            int x = 10, y = 43, ct = 0;

            foreach (Course course in listmyCourses)
            {
                foreach (int courseID in listIdCourses)
                {
                    if (courseID == course.getid())
                    {
                        ct++;
                        pnlCard pnlcard = new pnlCard(form, course, id);
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


    }
}
