using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Subjects;

namespace ExaminationSystem.Users.Classes
{
    class Admin : User
    {
        //for now admin will have to put all the data in the system
        public Admin(string name, int id)
        {
            Name = name;
            Id = id;
            Role = "Admin";
        }
        public void StartExam(Subject subject)
        {
            subject.StartExam();
        }

        public void StopExam(Subject subject)
        {
            subject.StopExam();
        }
    }
}
