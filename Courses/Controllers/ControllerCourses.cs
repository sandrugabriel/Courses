using Courses.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses.Controllers
{
    internal class ControllerCourses
    {

        private List<Course> courses;

        public ControllerCourses()
        {

            courses = new List<Course>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/courses.txt";

            StreamReader streamReader = new StreamReader(path);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {

                Course a = new Course(text);

                courses.Add(a);
            }

            streamReader.Close();
        }

        public string namById(int id)
        {
            string name = null;

            for(int i = 0; i < courses.Count; i++)
            {
                if (courses[i].getid() == id) return name;
            }


            return null;
        }

        public List<Course> getcourses()
        {

            return courses;
        }

        public List<Course> getMyCourses(int id)
        {
            List<Course> list = new List<Course>(); 

            for(int i = 0;i < courses.Count;i++)
                if (courses[i].getid_Client() == id) list.Add(courses[i]);

            return list;
        }

        public Course getById(int id)
        {

            for (int i = 0; i < courses.Count; i++)
            {
                if (id == courses[i].getid())
                {
                    return courses[i];
                }
            }

            return null;
        }

        public int generareId()
        {

            Random random = new Random();

            int id = random.Next();
            while(this.getById(id) != null)
            {

                id = random.Next();

            }

            return id;
        }


    }
}
