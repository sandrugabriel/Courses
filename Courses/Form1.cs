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
        public int id;
        public Form1()
        {
            InitializeComponent();
            id = 0;
            this.Size = new System.Drawing.Size(1700, 900);
            this.MinimumSize = new Size(1700, 900);
            this.MaximumSize = new Size(1700, 900);

            this.Controls.Add(new pnlLogin(this));
            this.Controls.Add(new pnlHome(this,1));
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
