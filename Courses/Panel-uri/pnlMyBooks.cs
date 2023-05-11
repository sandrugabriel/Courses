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
    internal class pnlMyBooks:Panel
    {

        Form1 form;

        private int idStudent;

        List<Book> listBooks;
        ControllerBook controllerBook;

        public pnlMyBooks(Form1 form1, int idStudent1)
        {

            form = form1;
            idStudent = idStudent1;
            listBooks = new List<Book>();
            controllerBook = new ControllerBook();

            //pnlMyBooks
            this.Location = new System.Drawing.Point(120, 100);
            this.Size = new System.Drawing.Size(1205, 758);
            this.Name = "pnlMyBooks";

            listBooks = controllerBook.getmybooks(idStudent);

            createCardBook(3);

        }

        public void createCardBook(int nrCol)
        {

            this.Controls.Clear();

            int x = 10, y = 43, ct = 0;

            foreach (Book book in listBooks)
            {
                ct++;

                pnlCardBook pnlCardBook = new pnlCardBook(form, book);
                pnlCardBook.Location = new System.Drawing.Point(x,y);
                this.Controls.Add(pnlCardBook);
                x += 400;

                if(ct%nrCol == 0)
                {
                    x = 10;
                    y += 210;
                }
                if(y>this.Height)
                {
                    this.AutoScroll = true;
                }


            }

        }




    }
}
