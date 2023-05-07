using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Models
{
    internal class Enrolment
    {

        private int idEnrolment;
        private int strudentId;
        private int courseId;
        private DateTime createdAt;

        public Enrolment(int idEnrolmet, int strudentid, int courseid, DateTime dateTime)
        {
            this.idEnrolment = idEnrolmet;
            this.strudentId = strudentid;
            this.courseId = courseid;
            this.createdAt = dateTime;
        }

        public Enrolment(string text) {
            string[] porp = text.Split(';');

            this.idEnrolment = int.Parse(porp[0]);
            this.strudentId = int.Parse(porp[1]);
            this.courseId = int.Parse(porp[2]);
            this.createdAt = DateTime.Parse(porp[3]);
        
        
        }


        public int getIdEnrolment() {
            return idEnrolment;
        }

        public int getstudentid()
        {
            return strudentId;
        }

        public int getcourseid()
        {
            return courseId;
        }

        public DateTime getCreatedAt()
        {
            return createdAt;
        }

        public string tosave()
        {
            return idEnrolment.ToString() + ";" + strudentId.ToString() + ";" + courseId.ToString() + ";" + createdAt.ToString();
        }

    }
}
