using Courses.Controllers;
using Courses.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses.Panel_uri
{
    internal class pnlView : Panel
    {

        Label lblCourse;
        Label lblName;
        Label lblby;
        RichTextBox txtDescription;
        Label lbldescription;
        Label lbltime;
        TextBox txtTime;
        Label lblmaterials;
        RichTextBox txtMaterials;
        Button btnDelete;
        Button btnAdd;
        Button btnReturn;

        Form1 form;

        ControllerClient controllerClient;
        ControllerCourses controllerCourses;
        ControllerEnrolment controllerEnrolment;

        pnlLogin pnlLogin;

        Label lblvisibe;

        Course course;
        private int id1;

        public pnlView(Course course1, Form1 form1)
        {
            course = course1;
            form = form1;
           
            // this.form.MinimumSize = new Size(1187, 882);
            this.form.StartPosition = FormStartPosition.CenterParent;
            //this.form.MaximizeSize = new Size();

            controllerClient = new ControllerClient();
            controllerCourses = new ControllerCourses();
            controllerEnrolment = new ControllerEnrolment();
            pnlLogin = new pnlLogin(form);

            id1 = new int();
            id1 = pnlLogin.id;
          //  MessageBox.Show(id1.ToString());
           // MessageBox.Show(course.getid().ToString());
            this.Location = new System.Drawing.Point(120, 95);
            this.Size = new System.Drawing.Size(1387, 762);
            this.Name = "pnlView";
            this.AutoScroll = true;

            this.lblCourse = new Label();
            this.lblName = new Label();
            this.lblby = new Label();
            this.txtDescription = new RichTextBox();
            this.lbldescription = new Label();
            this.lbltime = new Label();
            this.txtTime = new TextBox();
            this.lblmaterials = new Label();
            this.txtMaterials = new RichTextBox();
            this.btnAdd = new Button();
            this.btnDelete = new Button();
            this.btnReturn = new Button();
            this.lblvisibe = new Label();

            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtMaterials);
            this.Controls.Add(this.lblmaterials);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblby);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblvisibe);

            // lblvisibe
            this.lblvisibe.AutoSize = true;
            this.lblvisibe.Location = new System.Drawing.Point(31, 906);
            this.lblvisibe.Text = "";

            // lblCourse
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblCourse.Location = new System.Drawing.Point(31, 116);
            this.lblCourse.Text = "Course";

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(54, 152);
            this.lblName.Text = course.getName();

            // lblby
            this.lblby.AutoSize = true;
            this.lblby.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblby.Location = new System.Drawing.Point(119, 199);
            this.lblby.Text = "By " + controllerClient.namebyid(course.getid_Client());

            // txtDescription
            this.txtDescription.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.txtDescription.Location = new System.Drawing.Point(26, 342);
            this.txtDescription.Size = new System.Drawing.Size(529, 302);
            this.txtDescription.Text = course.getDescription();
            this.txtDescription.ReadOnly = true;
            

            // lbldescription
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lbldescription.Location = new System.Drawing.Point(55, 302);
            this.lbldescription.Text = "Course Description";

            // lbltime
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lbltime.Location = new System.Drawing.Point(738, 180);
            this.lbltime.Text = "Estimate Time";

            // txtTime
            this.txtTime.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.txtTime.Location = new System.Drawing.Point(743, 229);
            this.txtTime.Size = new System.Drawing.Size(268, 34);
            this.txtTime.Text = course.getTime();
            this.txtTime.ReadOnly = true;

            // lblmaterials
            this.lblmaterials.AutoSize = true;
            this.lblmaterials.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblmaterials.Location = new System.Drawing.Point(738, 302);
            this.lblmaterials.Text = "Materials Needed";

            // txtMaterials
            this.txtMaterials.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.txtMaterials.Location = new System.Drawing.Point(743, 342);
            this.txtMaterials.Size = new System.Drawing.Size(322, 302);
            this.txtMaterials.Text = course.getMaterials();
            this.txtMaterials.ReadOnly = true;

            // btnAdd
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.btnAdd.Location = new System.Drawing.Point(26, 24);
            this.btnAdd.Size = new System.Drawing.Size(161, 55);
            this.btnAdd.Text = "Add Course";
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

            // btnDelete
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.btnDelete.Location = new System.Drawing.Point(224, 24);
            this.btnDelete.Size = new System.Drawing.Size(161, 55);
            this.btnDelete.Text = "Delete Course";
            this.btnDelete.Click += new EventHandler(btnDelete_Click);

            // btnReturn
            this.btnReturn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.btnReturn.Location = new System.Drawing.Point(421, 24);
            this.btnReturn.Size = new System.Drawing.Size(161, 55);
            this.btnReturn.Text = "Return List";
            this.btnReturn.Click += new EventHandler(btnReturn_Click);




        }
        

        private void btnReturn_Click(object sender, EventArgs e)
        {

            this.form.Controls.Add(new pnlHome(form, pnlLogin.id));
            this.form.removepnl("pnlView");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("id student: " + id1.ToString() + "   id course " + course.getid()); 
            //MessageBox.Show(controllerEnrolment.verification(id1, course.getid()).ToString());
            if (controllerEnrolment.verification(id1, course.getid()) == true)
            {
                MessageBox.Show("You are already enrolled in the course!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.form.removepnl("pnlView");
                this.form.Controls.Add(new pnlHome(form, id1));
                return;
            }

            if (controllerEnrolment.verification(id1, course.getid()) == false)
            {
                MessageBox.Show("You signed up for course " + course.getName(), "Congratulated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int id = controllerEnrolment.generareId();
                int idStudent = pnlLogin.id;
                int idCours = course.getid();
                DateTime dateTime = DateTime.Now;
                string textul = id.ToString() + ";" + idStudent.ToString() + ";" + idCours.ToString() + ";" + dateTime.ToString();
                controllerEnrolment.addEnrolment(textul);
                this.form.removepnl("pnlView");
                this.form.Controls.Add(new pnlHome(form, id1));
                return;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if(controllerEnrolment.verification(id1,course.getid())==true)
            {
                MessageBox.Show("You are no longer part of the " + course.getName() + " course", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int id = controllerEnrolment.getIdEnrol(id1,course.getid());
                controllerEnrolment.deleteEnrolments(id);
                this.form.removepnl("pnlView");
                this.form.Controls.Add(new pnlHome(form,id1));
                return;
            }
            else
            {
                MessageBox.Show("You are not enrolled in this course","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }


        }


    }
}
