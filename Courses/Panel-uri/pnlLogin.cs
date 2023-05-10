using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses.Panel_uri
{
    internal class pnlLogin:Panel
    {

        Form1 form;

        Label lblTitlu;
        public Label lblName;
        public LinkLabel linkSignUp;
        public LinkLabel linkSignIn;
        public LinkLabel linkSignOut;
        public LinkLabel linkSeeCourses;

        public int id;

        public pnlLogin(Form1 form1) { 
        
            form = form1;
            id = new int();
            id = form.id;
            // pnlLogin
            this.Location = new System.Drawing.Point(-1, 3);
            this.Name = "pnlLogin";
            this.Size = new System.Drawing.Size(1560, 70);
            this.BackColor = Color.SkyBlue;
            
            int dim = this.Size.Height / 2 - 16;

            this.lblTitlu = new Label();
            this.linkSignUp = new LinkLabel();
            this.linkSignIn = new LinkLabel();
            this.lblName = new Label();
            this.linkSignOut = new LinkLabel();
            this.linkSeeCourses = new LinkLabel();

            this.Controls.Add(this.linkSignIn);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.linkSeeCourses);
            this.Controls.Add(linkSignOut);

            // linksignin
            this.linkSeeCourses.AutoSize = true;
            this.linkSeeCourses.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.linkSeeCourses.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSeeCourses.Location = new System.Drawing.Point(1350, dim);
            this.linkSeeCourses.Text = "Enrolled courses";
            this.linkSeeCourses.Click += new EventHandler(linkSeeCourses_Click);

            // linksignin
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.linkSignIn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSignIn.Location = new System.Drawing.Point(1350, dim);
            this.linkSignIn.Text = "Sign In";
            this.linkSignIn.Click += new EventHandler(linkSignIn_Click);

            // linksignup
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.linkSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSignUp.Location = new System.Drawing.Point(1430, dim);
            this.linkSignUp.Text = "Sign Up";
            this.linkSignUp.Click += new EventHandler(linkSignUp_Click);

            //linksignout
            this.linkSignOut.AutoSize = true;
            this.linkSignOut.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.linkSignOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSignOut.Location = new System.Drawing.Point(1430, dim);
            this.linkSignOut.Text = "Sign Out";
            this.linkSignOut.Click += new EventHandler(linkSignOut_Click);
            this.linkSignOut.Visible = false;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.lblName.Location = new System.Drawing.Point(linkSignUp.Location.X/2, dim);
            this.lblName.Visible = false;
            this.lblName.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;

            // lbltilit
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI", 20, System.Drawing.FontStyle.Bold);
            this.lblTitlu.Location = new System.Drawing.Point(24, dim-3);
            this.lblTitlu.Name = "lblTITLU";
            this.lblTitlu.Text = "Courses";
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Click += new EventHandler(lblTitlu_Click);




        }

        private void linkSeeCourses_Click(object sender, EventArgs e)
        {
            this.linkSeeCourses.Visible = false;

            this.form.removepnl("pnlHome");
            this.form.removepnl("pnlSignUp");
            this.form.removepnl("pnlSignIn");
            this.form.removepnl("pnlView");
            this.form.removepnl("pnlAddCourse");
            this.form.Controls.Add(new pnlSignIn(form));

        }


        private void linkSignOut_Click(object sender, EventArgs e)
        {

            this.form.id = 0;

            this.linkSignOut.Visible = false;
            this.linkSignUp.Visible = true;
            this.linkSignIn.Visible = true;
            this.lblName.Visible = false;

            this.form.removepnl("pnlHome");
            this.form.removepnl("pnlSignUp");
            this.form.removepnl("pnlSignIn");
            this.form.removepnl("pnlView");
            this.form.removepnl("pnlAddCourse");
            this.form.Controls.Add(new pnlSignIn(form));

        }


        private void lblTitlu_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlHome");
            this.form.removepnl("pnlSignUp");
            this.form.removepnl("pnlSignIn");
            this.form.removepnl("pnlView");
            this.form.removepnl("pnlAddCourse");
            this.form.Controls.Add(new pnlHome(form,id));

        }

        private void linkSignIn_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlSignUp");
            this.form.removepnl("pnlView");
            this.form.removepnl("pnlAddCourse");
            this.form.removepnl("pnlSignIn");
            this.form.removepnl("pnlHome");
            this.form.Controls.Add(new pnlSignIn(form));


        }
        private void linkSignUp_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlSignIn");
            this.form.removepnl("pnlSignUp");
            this.form.removepnl("pnlAddCourse");
            this.form.removepnl("pnlView");
            this.form.removepnl("pnlHome");
            this.form.Controls.Add(new pnlSignUp(form));

        }



    }
}
