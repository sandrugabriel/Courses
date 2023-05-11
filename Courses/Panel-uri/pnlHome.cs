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

        LinkLabel linkSeeCourses;
        LinkLabel linkMyBooks;

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

            this.linkSeeCourses = new LinkLabel();
            this.linkMyBooks = new LinkLabel();

            // linkSee
            this.linkSeeCourses.AutoSize = true;
            this.linkSeeCourses.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15, System.Drawing.FontStyle.Regular);
            this.linkSeeCourses.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSeeCourses.ForeColor = System.Drawing.Color.Black;
            this.linkSeeCourses.Location = new System.Drawing.Point(1000, 0);
            this.linkSeeCourses.Text = "Enrolled courses";
            this.linkSeeCourses.BringToFront();
            this.linkSeeCourses.Click += new EventHandler(linkSeeCourses_Click);

            //linkMyBooks
            this.linkMyBooks.AutoSize = true;
            this.linkMyBooks.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15, FontStyle.Regular);
            this.linkMyBooks.LinkBehavior = LinkBehavior.NeverUnderline;
            this.linkMyBooks.Location = new Point(870, 0);
            this.linkMyBooks.Text = "My books";
            this.linkMyBooks.Click += new EventHandler(linkMyBooks_Click);

            courses = controllerCourses.getcourses();

            createCard(3);
            this.linkSeeCourses.BringToFront();
        }

        private void linkMyBooks_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlHome");
            this.form.removepnl("pnlSignUp");
            this.form.removepnl("pnlSignIn");
            this.form.removepnl("pnlView");
            this.form.removepnl("pnlAddCourse");
            this.linkMyBooks.Visible = false;
           

        }


        private void linkSeeCourses_Click(object sender, EventArgs e)
        {
            this.linkSeeCourses.Visible = false;

            this.form.removepnl("pnlHome");
            this.form.removepnl("pnlSignUp");
            this.form.removepnl("pnlSignIn");
            this.form.removepnl("pnlView");
            this.form.removepnl("pnlAddCourse");
            this.form.Controls.Add(new pnlSeeCourses(form, id));

        }

        public void createCard(int nrCollums)
        {

              this.Controls.Clear();

            this.Controls.Add(this.linkSeeCourses);
            this.Controls.Add(this.linkMyBooks);
            int x = 10, y = 43, ct = 0;

            foreach (Course course in courses)
            {
                ct++;
                pnlCard pnlcard = new pnlCard(form,course,id);
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
