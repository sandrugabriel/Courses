using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Models
{
    internal class Student
    {

        private int id;
        private string name;
        private string email;
        private int age;
        private List<int> listIdCourses;

        public Student(int id, string name, string email, int age, List<int> listidCourses)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.age = age;
            this.listIdCourses = listidCourses;
        }

        public Student(string textul)
        {

            string[] prop = textul.Split('⁂');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.email = prop[2];
            this.age = int.Parse(prop[3]);
            for(int i=4;i<listIdCourses.Count;i++)
            {
                listIdCourses[i] = int.Parse(prop[i]);
            }

        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getEmail()
        {
            return email;
        }

        public int getAge()
        {
            return age;
        }

        public List<int> getlistIdCourses()
        {

            return listIdCourses;

        }


    }
}
