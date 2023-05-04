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


        public int pozID(int id)
        {

            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].getid() == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public string stergere(int id)
        {
            string t = "";
            int p = pozID(id);
            for (int i = p; i < courses.Count - 1; i++)
            {
                courses[i] = courses[i + 1];
            }

            for (int i = 0; i < courses.Count; i++)
            {
                t += courses[i].toSave() + "\n";
            }


            return t;
        }

        public void deleteCourese(int id)
        {

            string path = Application.StartupPath + @"/data/courses.txt";
            StreamWriter stream = new StreamWriter(path);

            stream.Write(this.stergere(id));

            stream.Close();
        }


    }
}
