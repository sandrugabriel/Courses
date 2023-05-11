using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Models
{
    internal class Book
    {

        private int id;
        private int studentId;
        private string bookName;
        private DateTime creatAt;

        public Book(int id, int studentId, string bookName, DateTime creatAt)
        {
            this.id = id;
            this.studentId = studentId;
            this.bookName = bookName;
            this.creatAt = creatAt;
        }

        public Book(string textul)
        {

            string[] prop = textul.Split(',');

            this.id = int.Parse(prop[0]);
            this.studentId = int.Parse(prop[1]);
            this.bookName = prop[2];
            this.creatAt = DateTime.Parse(prop[3]);

        }

        public int getIdBook() { 
            
            return id;
        }

        public int getStudentId()
        {
            return studentId;
        }

        public string getBookName()
        {
            return bookName;
        }

        public DateTime getCreatAt()
        {
            return creatAt;
        }

    }
}
