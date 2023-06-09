﻿using Courses.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Courses.Panel_uri
{
    internal class pnlSignIn:Panel
    {

        Label lblTitlu;
        Label lblEmail;
        Label lblPassword;
        Label lblInformation;
        LinkLabel lnlsignUp;
        TextBox txtpassword;
        TextBox txtemail;
        Button btnSignIn;
        Button btnCancel;

        List<string> erori;
        ControllerClient controllerClients;
        
        Form1 form;

        pnlLogin pnlLogin;

        public pnlSignIn(Form1 form1)
        {

            form = form1;
            erori = new List<string>();
            pnlLogin = new pnlLogin(form);
            controllerClients = new ControllerClient();
            this.form.Size = new System.Drawing.Size(1700,900);
            this.form.MinimumSize = new Size(1700, 900);
            this.form.MaximumSize = new Size(1700, 900);
            this.Size = new System.Drawing.Size(1200, 625);
            this.Name = "pnlSignIn";
            this.Location = new System.Drawing.Point(120, 95); 

            //New
            lblTitlu = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblInformation = new Label();
            lnlsignUp = new LinkLabel();
            txtemail = new TextBox();
            txtpassword = new TextBox();    
            btnSignIn = new Button();
            btnCancel = new Button();

            //Add
            this.Controls.Add(lblTitlu);
            this.Controls.Add(lblEmail);
            this.Controls.Add(lblPassword);
            this.Controls.Add(lblInformation);
            this.Controls.Add(lnlsignUp);
            this.Controls.Add(txtemail);
            this.Controls.Add(txtpassword);
            this.Controls.Add(btnSignIn);
            this.Controls.Add(btnCancel);

            //lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(425, 51);
            this.lblTitlu.Text = "Sign In";
            this.lblTitlu.Font = new Font("Microsoft YaHei UI", 24, FontStyle.Bold);

            //lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(425, 141);
            this.lblEmail.Text = "Email";
            this.lblEmail.Font = new Font("Microsoft YaHei UI Light", 13);

            //txtEmail
            this.txtemail.Location = new System.Drawing.Point(425, 174);
            this.txtemail.Font = new Font("Microsoft YaHei UI Light", 12);
            this.txtemail.Size = new System.Drawing.Size(412,31);

            //lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(425, 236);
            this.lblPassword.Text = "Password";
            this.lblPassword.Font = new Font("Microsoft YaHei UI Light", 13);

            //txtPassword
            this.txtpassword.Location = new System.Drawing.Point(425, 269);
            this.txtpassword.Font = new Font("Microsoft YaHei UI Light", 12);
            this.txtpassword.Size = new System.Drawing.Size(412,31);

            //btnSignIn
            this.btnSignIn.Location = new System.Drawing.Point(425, 344);
            this.btnSignIn.Size = new System.Drawing.Size(190, 48);
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Font = new Font("Microsoft YaHei UI", 13);
            this.btnSignIn.Click += new EventHandler(btnSignIn_Click);

            //btnCancel
            this.btnCancel.Location = new System.Drawing.Point(656, 344);
            this.btnCancel.Size = new System.Drawing.Size(190, 48);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = new Font("Microsoft YaHei UI", 13);
            this.btnCancel.Click += new EventHandler(btnCancel_Click);

            //lblintormation
            this.lblInformation.Location = new System.Drawing.Point(430, 422);
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new Font("Microsoft YaHei UI Light", 12);
            this.lblInformation.Text = "Don't have a user account? Click here to";

            //lblsignUp
            this.lnlsignUp.AutoSize = true;
            this.lnlsignUp.Location = new System.Drawing.Point(734, 422);
            this.lnlsignUp.Font = new Font("Microsoft YaHei UI Light", 12);
            this.lnlsignUp.Text = "sign up!";
            this.lnlsignUp.LinkBehavior = LinkBehavior.NeverUnderline;
            this.lnlsignUp.Click += new EventHandler(lnlsignUp_Click);

        }

        private void lnlsignUp_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlSignIn");
            this.form.Controls.Add(new pnlSignUp(this.form));


        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            errors();
            if (erori.Count > 0)
            {

                for(int i = 0; i < erori.Count; i++)
                {
                    MessageBox.Show(erori[i],"Errors",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                int id = controllerClients.idByemailPass(txtpassword.Text, txtemail.Text);
                string name = controllerClients.namebyid(id);

                this.pnlLogin.lblName.Text = "Welcome, "+name+"!";
                this.pnlLogin.lblName.Visible = true;
                this.pnlLogin.linkSignIn.Visible = false;
                this.pnlLogin.linkSignUp.Visible = false;
                this.pnlLogin.linkSignOut.Visible = true;
                this.form.removepnl("pnlLogin");
                this.form.Controls.Add(pnlLogin);    
                this.form.removepnl("pnlSignIn");
                this.form.id = id;
                this.form.Controls.Add(new pnlHome(form,id));
                this.form.Controls.Add(new pnlLogin(form));

            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {


            this.form.removepnl("pnlSignIn");
            this.form.Controls.Add(new pnlHome(this.form,-1));
        
        
        }

        private void errors()
        {

            erori.Clear();

            if (txtemail.Text.Equals(""))
            {
                erori.Add("You have not entered the email");
            }

            if (txtpassword.Text.Equals(""))
            {
                erori.Add("You have not entered the password");
            }

            if (erori.Count == 0)
            {
                if (controllerClients.verification(txtpassword.Text, txtemail.Text) == false)
                {
                    erori.Add("You have not entered password / email incorrectly");
                }
            }


        }



    }
}
