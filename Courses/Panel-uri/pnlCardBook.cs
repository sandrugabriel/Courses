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

    internal class pnlCardBook:Panel
    {

        Form1 form;
        Book book;


        Label lblTile;
        Label lblNameBook;

        public pnlCardBook(Form1 form1, Book book1)
        {
            form = form1;
            book = book1;

            //pnlCardBook
            this.Size = new System.Drawing.Size(350, 142);
            this.Name = "pnlCardBook";
            this.BackColor = Color.SkyBlue;
            this.ForeColor = Color.White;

            //New 
            this.lblTile = new Label();
            this.lblNameBook = new Label();

            //Add
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.lblNameBook);

            //lblTile
            this.lblTile.Location = new System.Drawing.Point(13, 14);
            this.lblTile.AutoSize = true;
            this.lblTile.Text = "Book";
            this.lblTile.Font = new Font("Microsoft YaHei UI Light",14,FontStyle.Regular);

            //lblName
            this.lblNameBook.Location = new Point(40, 52);
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Text = book.getBookName();
            this.lblNameBook.Font = new Font("Microsoft YaHei UI Light", 17, FontStyle.Bold);

        }

        private void close_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlMyBook");
            //this.form.Controls.Add(new pnlViewBooks(form,book));

        }

    }
}
