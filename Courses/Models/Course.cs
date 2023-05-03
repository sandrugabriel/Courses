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
        private string name;
        private string description;
        private string time;
        private string materials;

        public Course(int id, string name, string description, string time, string materials)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.time = time;
            this.materials = materials;
        }

        public Course(string text) {

            string[] prop = text.Split('⁂');
            
            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.description = prop[2];
            this.time = prop[3];
            this.materials = prop[4];

        }

        public int getid()
        {
            return id;
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

    }
}
