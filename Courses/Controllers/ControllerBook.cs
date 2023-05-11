using Courses.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses.Controllers
{
    internal class ControllerBook
    {

        private List<Book> books;


        public ControllerBook()
        {

            books = new List<Book>();

            load();
        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/books.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while((t = streamReader.ReadLine()) != null)
            {

                Book a = new Book(t);
                books.Add(a);
            }

        }

        public List<Book> getmybooks(int idStudent)
        {
            List<Book> list = new List<Book>();

            for(int i=0;i<books.Count;i++)
            {
                if (books[i].getStudentId()==idStudent)
                    list.Add(books[i]);
            }

            return list;
        }


    }
}
