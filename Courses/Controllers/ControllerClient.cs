using Courses.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Courses.Controllers
{
    internal class ControllerClient
    {

        private List<Client> clients = new List<Client>();


        public ControllerClient() { 
        
            clients = new List<Client>();

            load();
        
        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/client.txt";

            StreamReader streamReader = new StreamReader(path);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {

                Client a = new Client(text);
                clients.Add(a);

            }

            streamReader.Close();
        }

        public bool verification(string pass, string email)
        {
            for (int i = 0; i < clients.Count; i++)
            {

                if (clients[i].getpassword().Equals(pass) && clients[i].getemail().Equals(email))
                {
                    return true;
                }

            }


            return false;
        }

        public string namebyid(int id)
        {

            for(int i=0;i<clients.Count; i++)
            {
                if (clients[i].getid() == id)
                {
                    return clients[i].getname();
                }
            }
            return null;
        }

        public int idByemailPass(string pass, string email)
        {
            for (int i = 0; i < clients.Count; i++)
            {

                if (clients[i].getpassword().Equals(pass) && clients[i].getemail().Equals(email))
                {
                    return clients[i].getid();
                }

            }


            return -1;
        }


        public Client getClientById(int id)
        {

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].getid() == id)
                {
                    return clients[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getClientById(id) != null)
            {

                id = random.Next();

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/client.txt";
            File.AppendAllText(path, text + "\n");


        }


    }
}
