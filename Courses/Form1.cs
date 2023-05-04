using Courses.Panel_uri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(new pnlHome(this,-1));
            this.Controls.Add(new pnlLogin(this));

        }

        public void removepnl(string text)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if(c.Name.Equals(text)) { 
                
                control = c;
                    break;
                }

            }

            this.Controls.Remove(control);
        }


    }
}
