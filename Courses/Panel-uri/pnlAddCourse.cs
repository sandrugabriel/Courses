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
    internal class pnlAddCourse:Panel
    {


        Label lblCourse;
        TextBox txtName;
        Label lblby;
        RichTextBox txtDescription;
        Label lbldescription;
        Label lbltime;
        TextBox txtTime;
        Label lblmaterials;
        RichTextBox txtMaterials;
        Button btnAdd;
        Button btnReturn;

        Form1 form;

        ControllerClient controllerClient;
        ControllerCourses controllerCourses;

        pnlLogin pnlLogin;

        Label lblvisibe;

        private int id_Client;

        public pnlAddCourse(Form1 form1, int id)
        {
            form = form1;
            id_Client = id;
            controllerClient = new ControllerClient();
            controllerCourses = new ControllerCourses();
            pnlLogin = new pnlLogin(form);

            this.Location = new System.Drawing.Point(120, 95);
            this.Size = new System.Drawing.Size(1387, 762);
            this.Name = "pnlAddCourse";
            this.AutoScroll = true;

            this.lblCourse = new Label();
            this.txtName = new TextBox();
            this.lblby = new Label();
            this.txtDescription = new RichTextBox();
            this.lbldescription = new Label();
            this.lbltime = new Label();
            this.txtTime = new TextBox();
            this.lblmaterials = new Label();
            this.txtMaterials = new RichTextBox();
            this.btnAdd = new Button();
            this.btnReturn = new Button();
            this.lblvisibe = new Label();

            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMaterials);
            this.Controls.Add(this.lblmaterials);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblby);
            this.Controls.Add(this.txtName);
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

            // txtName
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(54, 152);
            this.txtName.Size = new System.Drawing.Size(268, 34);
            this.txtName.Text = "";
            this.txtName.Multiline = false;

            // lblby
            this.lblby.AutoSize = true;
            this.lblby.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblby.Location = new System.Drawing.Point(119, 199);
            this.lblby.Text = "By " + controllerClient.namebyid(pnlLogin.id);

            // txtDescription
            this.txtDescription.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.txtDescription.Location = new System.Drawing.Point(26, 342);
            this.txtDescription.Size = new System.Drawing.Size(529, 302);
            this.txtDescription.Text = "";
            this.txtDescription.Multiline = false;

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
            this.txtTime.Text = "";
            this.txtTime.Multiline = false;

            // lblmaterials
            this.lblmaterials.AutoSize = true;
            this.lblmaterials.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblmaterials.Location = new System.Drawing.Point(738, 302);
            this.lblmaterials.Text = "Materials Needed";

            // txtMaterials
            this.txtMaterials.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.txtMaterials.Location = new System.Drawing.Point(743, 342);
            this.txtMaterials.Size = new System.Drawing.Size(322, 302);
            this.txtMaterials.Text = "";
            this.txtMaterials.Multiline = false;

            // btnUpdate
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.btnAdd.Location = new System.Drawing.Point(26, 24);
            this.btnAdd.Name = "btnUpdate";
            this.btnAdd.Size = new System.Drawing.Size(161, 55);
            this.btnAdd.Text = "Add Course";
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

            // btnReturn
            this.btnReturn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular);
            this.btnReturn.Location = new System.Drawing.Point(224, 24);
            this.btnReturn.Size = new System.Drawing.Size(161, 55);
            this.btnReturn.Text = "Return List";
            this.btnReturn.Click += new EventHandler(btnReturn_Click);




        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            this.form.Controls.Add(new pnlHome(form, pnlLogin.id));
            this.form.removepnl("pnlAddCourse");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string description = txtDescription.Text;
            string time = txtTime.Text;
            string materials = txtMaterials.Text;
            int id = controllerCourses.generareId();
            int idClient = id_Client;
            // ⁂
            string textul = id.ToString() + "⁂" + idClient.ToString() + "⁂" + name + "⁂" + description + "⁂" + time + "⁂" + materials;

           // controllerCourses.addCourse(textul);
            this.form.removepnl("pnlAddCourse");
            this.form.Controls.Add(new pnlHome(form, form.id));

        }


    }
}
