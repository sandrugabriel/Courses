using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Models
{
    internal class Course
    {

        private int id;
        private int id_Client;
        private string name;
        private string description;
        private string time;
        private string materials;

        public Course(int id, int id_Client, string name, string description, string time, string materials)
        {
            this.id = id;
            this.id_Client = id_Client;
            this.name = name;
            this.description = description;
            this.time = time;
            this.materials = materials;
        }

        public Course(string text) {

            string[] prop = text.Split('⁂');
            
            this.id = int.Parse(prop[0]);
            this.id_Client = int.Parse(prop[1]);
            this.name = prop[2];
            this.description = prop[3];
            this.time = prop[4];
            this.materials = prop[5];

        }

        public int getid()
        {
            return id;
        }

        public int getid_Client()
        {
            return id_Client;
        }

        public string getName()
        {
            return name;
        }

        public string getDescription()
        {
            return description;
        }

        public string getTime()
        {
            return time;
        }

        public string getMaterials()
        {
            return materials;
        }

        public string toSave()
        {
            return id.ToString() + "⁂" + id_Client.ToString() + "⁂" + name + "⁂" + description + "⁂" + time + "⁂" + materials;
        }

    }
}
