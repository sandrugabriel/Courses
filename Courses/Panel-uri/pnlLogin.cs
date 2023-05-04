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
        LinkLabel linkSignUp;
        public LinkLabel linkSignIn;

        public pnlLogin(Form1 form1) { 
        
            form = form1;

            // pnlLogin
            this.Location = new System.Drawing.Point(-1, 3);
            this.Name = "pnlLogin";
            this.Size = new System.Drawing.Size(1360, 70);
            this.BackColor = Color.SkyBlue;
            
            int dim = this.Size.Height / 2 - 16;

            this.lblTitlu = new Label();
            this.linkSignUp = new LinkLabel();
            this.linkSignIn = new LinkLabel();
            this.lblName = new Label();

            this.Controls.Add(this.linkSignIn);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblName);
             
            // linksignin
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.linkSignIn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSignIn.Location = new System.Drawing.Point(990, dim);
            this.linkSignIn.Text = "Sign In";
            this.linkSignIn.Click += new EventHandler(linkSignIn_Click);

            // linksignup
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.linkSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSignUp.Location = new System.Drawing.Point(1070, dim);
            this.linkSignUp.Text = "Sign Up";
            this.linkSignUp.Click += new EventHandler(linkSignUp_Click);

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




        }

        private void linkSignIn_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlSignUp");
            this.form.removepnl("pnlSignIn");
            this.form.removepnl("pnlHome");
            this.form.Controls.Add(new pnlSignIn(form));


        }
        private void linkSignUp_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlSignIn");
            this.form.removepnl("pnlSignUp");
            this.form.removepnl("pnlHome");
            this.form.Controls.Add(new pnlSignUp(form));

        }



    }
}
