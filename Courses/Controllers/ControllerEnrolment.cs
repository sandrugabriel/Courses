using Courses.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses.Controllers
{
    internal class ControllerEnrolment
    {

        private List<Enrolment> enrolments = new List<Enrolment>();

        public ControllerEnrolment()
        {

            enrolments = new List<Enrolment>();

            load();
            
        } 

        public void load()
        {

            string path = Application.StartupPath + @"/data/enrolments.txt";
            StreamReader streamReader = new StreamReader(path);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {

                Enrolment enrolment = new Enrolment(text);
                enrolments.Add(enrolment);

            }

            streamReader.Close();
        }

        public void afisare()
        {

            for(int i=0;i<enrolments.Count;i++)
            {
                MessageBox.Show("id student: " + enrolments[i].getstudentid() + "    id course:" + enrolments[i].getcourseid());
            }


        }

        public bool verification(int idStudent, int idCourse)
        {

            for (int i = 0; i < enrolments.Count; i++)
            {
                if (enrolments[i].getcourseid() == idCourse  &&  enrolments[i].getstudentid() == idStudent)
                {
                    return true;
                }
            }


            return false;
        }


        public void addEnrolment(string textul)
        {

            string path = Application.StartupPath + @"/data/enrolments.txt";
            File.AppendAllText(path, textul + "\n");

        }

        public Enrolment getbyidEnrol(int id)
        {

            for (int i = 0; i < enrolments.Count;i++)
                if(id == enrolments[i].getIdEnrolment())
                    return enrolments[i];

            return null;
        }

        public int generareId()
        {

            Random random = new Random();

            int id = random.Next();
            while (this.getbyidEnrol(id) != null)
            {
                id = random.Next();
            }

            return id;
        }

        public string saveAllFisier()
        {

            string t = "";

            for (int i = 0; i < enrolments.Count; i++)
                t += enrolments[i].tosave() + "\n";

            return t;
        }

        public int pozId(int id)
        {

            for(int i = 0; i < enrolments.Count; i++)
            {
                if (enrolments[i].getIdEnrolment() == id)
                    return i;
            }

            return -1;
        }
        
        public void stergere(int id)
        {

            int p=pozId(id);

            enrolments.RemoveAt(p);


        }

        public void deleteEnrolments(int id)
        {

            this.stergere(id);

            string path = Application.StartupPath + @"/data/enrolments.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(this.saveAllFisier());

            streamWriter.Close();
        }

        public int getIdEnrol(int idStudent, int idCourse)
        {

            for(int i=0;i<enrolments.Count;i++)
                if (enrolments[i].getcourseid() == idCourse && enrolments[i].getstudentid() == idStudent)
                    return enrolments[i].getIdEnrolment();
            return -1;
        }

    }
}
