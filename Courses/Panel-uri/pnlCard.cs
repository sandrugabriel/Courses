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
    internal class pnlCard:Panel
    {
        Course course;
        Form1 form;

        Label lblCourse;
        Label lblname;

        ControllerCourses controllerCourses;

        public pnlCard(Form1 form1, Course course1)
        {
            form = form1;
            this.course = course1;
            controllerCourses = new ControllerCourses();

            this.Name = "pnlCourse";
            this.Size = new System.Drawing.Size(350, 142);
            this.Click += new EventHandler(lbls_Click);

            this.lblname = new Label();
            this.lblCourse = new Label();

            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblname);

            if (course.getid() == 2)
            {
                this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                this.lblname.ForeColor = System.Drawing.Color.Black ;
                this.lblCourse.ForeColor = System.Drawing.Color.Black;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F, System.Drawing.FontStyle.Regular);
            }
            else
            {
                this.BackColor = System.Drawing.Color.SkyBlue;
                this.lblname.ForeColor = System.Drawing.SystemColors.Control;
                this.lblCourse.ForeColor = System.Drawing.SystemColors.Control;
                this.lblname.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold);
            }

            // lblname
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(11, 63);
            this.lblname.Text = course.getName();
            this.lblname.Click += new EventHandler(lbls_Click);
             
            // lblCourse
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.lblCourse.Location = new System.Drawing.Point(13, 14);
            this.lblCourse.Text = "Course";
            this.lblCourse.Click += new EventHandler(lbls_Click);

        }

        private void lbls_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlHome");
            if (course.getid() == 2)
            {
               //
            }
            else
            {
                
            }
            this.form.Controls.Add(new pnlView(course, form));


        }



    }
}
