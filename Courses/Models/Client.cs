using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Models
{
    internal class Client
    {

        private int id;
        private string name;
        private string password;
        private string email;

        public Client(int id, string name, string password, string email)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.email = email;
        }

        public Client(string text)
        {

            string[] prop = text.Split('⁂');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.password = prop[2];
            this.email = prop[3];

        }


        public int getid()
        {
            return id;
        }

        public string getname()
        {
            return name;
        }

        public string getpassword()
        {
            return password;
        }

        public string getemail()
        {
            return email;
        }


    }
}
