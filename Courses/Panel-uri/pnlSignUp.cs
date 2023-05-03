using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses.Panel_uri
{
    internal class pnlSignUp:Panel
    {
        Form1 form;

        Label lblTitlu;
        Label lblFirstName;
        Label lblLastName;
        Label lblEmail;
        Label lblPassword;
        Label lblInformation;
        LinkLabel lnlsignIn;
        TextBox txtpassword;
        TextBox txtemail;
        TextBox txtFisrtname;
        TextBox txtLastName;
        Button btnSignUp;
        Button btnCancel;


        public pnlSignUp(Form1 form1)
        {

            form = form1;

            this.form.Size = new System.Drawing.Size(1205, 758);
            this.Size = new System.Drawing.Size(1200, 625);
            this.Name = "pnlSignUp";
            this.Location = new System.Drawing.Point(0, 95);

            //New
            this.lblTitlu = new Label();
            this.lblFirstName = new Label();
            this.lblLastName = new Label();
            this.lblEmail = new Label();
            this.lblPassword = new Label();
            this.lblInformation = new Label();
            this.lnlsignIn = new LinkLabel();
            this.txtpassword = new TextBox();
            this.txtemail = new TextBox();
            this.txtFisrtname = new TextBox();
            this.txtLastName = new TextBox();
            this.btnSignUp = new Button();
            this.btnCancel = new Button();

            //Add
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lnlsignIn);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtFisrtname);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnCancel);


            //lbltitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(425, 38);
            this.lblTitlu.Font = new Font("Microsoft YaHei UI", 24, FontStyle.Bold );
            this.lblTitlu.Text = "Sign Up";

            //lblFisrtName;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(425, 126);
            this.lblFirstName.Font = new Font("Microsoft YaHei UI Light", 13);
            this.lblFirstName.Text = "First Name";

            //txtFirstName
            this.txtFisrtname.Location = new System.Drawing.Point(425, 159);
            this.txtFisrtname.Size = new System.Drawing.Size(412, 31);
            this.txtFisrtname.Font = new Font("Microsoft YaHei UI Light", 11); 

            //lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(425, 221);
            this.lblLastName.Font = new Font("Microsoft YaHei UI Light", 13);
            this.lblLastName.Text = "Last Name";

            //txtLastName
            this.txtLastName.Location = new System.Drawing.Point(425, 254);
            this.txtLastName.Size = new System.Drawing.Size(412, 31);
            this.txtLastName.Font = new Font("Microsoft YaHei UI Light", 11);
            
            //lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(425, 301);
            this.lblEmail.Font = new Font("Microsoft YaHei UI Light", 13);
            this.lblEmail.Text = "Email";

            //txtEmail
            this.txtemail.Location = new System.Drawing.Point(425, 344);
            this.txtemail.Font = new Font("Microsoft YaHei UI Light", 11);
            this.txtemail.Size = new System.Drawing.Size(412, 31);

            //lblpassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(429, 396);
            this.lblPassword.Font = new Font("Microsoft YaHei UI Light", 13);
            this.lblPassword.Text = "Password";

            //txtpassword
            this.txtpassword.Location = new System.Drawing.Point(425, 429);
            this.txtpassword.Font = new Font("Microsoft YaHei UI Light", 11);
            this.txtpassword.Size = new System.Drawing.Size(412, 31);

            // lnlsignIn
            this.lnlsignIn.AutoSize = true;
            this.lnlsignIn.Font = new Font("Microsoft YaHei UI Light", 12);
            this.lnlsignIn.LinkBehavior = LinkBehavior.NeverUnderline;
            this.lnlsignIn.Location = new System.Drawing.Point(773, 566);
            this.lnlsignIn.Name = "lnlsignIn";
            this.lnlsignIn.Text = "sign in!";
            this.lnlsignIn.Click += new EventHandler(lnlsignIn_Click);
             
            // lbltext
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new Font("Microsoft YaHei UI Light", 13);
            this.lblInformation.Location = new System.Drawing.Point(425, 566);
            this.lblInformation.Text = "Already have a user account? Click here to";
             
            // btnCancel
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F);
            this.btnCancel.Location = new System.Drawing.Point(656, 488);
            this.btnCancel.Size = new System.Drawing.Size(190, 45);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
             
            // btnSignUp
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F);
            this.btnSignUp.Location = new System.Drawing.Point(425, 488);
            this.btnSignUp.Size = new System.Drawing.Size(190, 45);
            this.btnSignUp.Text = "Sign In";
            this.btnSignUp.Click += new EventHandler(btnSignUp_Click);

        }


        private void lnlsignIn_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlSignUp");
            this.form.Controls.Add(new pnlSignIn(form));

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {



        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {


        }

    }
}
