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

            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Name = "pnlCourse";
            this.Size = new System.Drawing.Size(370, 142);

            this.lblname = new Label();
            this.lblCourse = new Label();

            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblname);

            // lblname
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblname.Location = new System.Drawing.Point(11, 63);
            this.lblname.Text = course.getName();
             
            // lblCourse
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.lblCourse.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCourse.Location = new System.Drawing.Point(13, 14);
            this.lblCourse.Text = "Course";


        }

            



    }
}
