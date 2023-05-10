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
        Button btnAdd;
        Button btnDelete;

        ControllerCourses controllerCourses;

        pnlLogin pnlLogin;
        ControllerEnrolment controllerEnrolment;

        private int id;

        public pnlCard(Form1 form1, Course course1, int id1)
        {
            form = form1;
            id = id1;

            this.course = course1;
            controllerCourses = new ControllerCourses();
            controllerEnrolment = new ControllerEnrolment();

            pnlLogin = new pnlLogin(form);

            this.Name = "pnlCourse";
            this.Size = new System.Drawing.Size(350, 142);
            this.Click += new EventHandler(lbls_Click);

            this.lblname = new Label();
            this.lblCourse = new Label();

            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblname);




            this.BackColor = System.Drawing.Color.SkyBlue;
            this.lblname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCourse.ForeColor = System.Drawing.SystemColors.Control;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold);


            if (controllerEnrolment.verification(id, course.getid()) == false)
            {
                //BtnAdd
                this.btnAdd = new Button();
                this.Controls.Add(this.btnAdd);
                this.btnAdd.Location = new System.Drawing.Point(110, 80);
                this.btnAdd.Size = new System.Drawing.Size(105, 45);
                this.btnAdd.Text = "Add";
                this.btnAdd.Click += new EventHandler(btnAdd_Click);
            }

            if (controllerEnrolment.verification(id, course.getid()) == true)
            {
                //BtnDelete
                this.btnDelete = new Button();
                this.Controls.Add(this.btnDelete);
                this.btnDelete.Location = new System.Drawing.Point(110, 80);
                this.btnDelete.Size = new System.Drawing.Size(105, 45);
                this.btnDelete.Text = "Delete";
                this.btnDelete.Click += new EventHandler(btnDelete_Click);

            }


            // lblname
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(11, 45);
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
            this.form.Controls.Add(new pnlView(course, form));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (controllerEnrolment.verification(id, course.getid()) == false)
            {
                MessageBox.Show("You signed up for course " + course.getName(), "Congratulated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int id1 = controllerEnrolment.generareId();
                int idStudent = id;
                int idCours = course.getid();
                DateTime dateTime = DateTime.Now;
                string textul = id1 + ";" + idStudent.ToString() + ";" + idCours.ToString() + ";" + dateTime.ToString();
                controllerEnrolment.addEnrolment(textul);
                this.form.removepnl("pnlHome");
                this.form.Controls.Add(new pnlHome(form, idStudent));

                return;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are no longer part of the " + course.getName() + " course", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int id1 = controllerEnrolment.getIdEnrol(id, course.getid());
            controllerEnrolment.deleteEnrolments(id1);
            this.form.removepnl("pnlHome");
            this.form.Controls.Add(new pnlHome(form, id));
            return;

        }


    }
}
