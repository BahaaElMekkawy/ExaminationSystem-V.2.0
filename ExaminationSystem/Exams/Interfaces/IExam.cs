using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Questions.Interfaces;
using ExaminationSystem.Subjects;
using ExaminationSystem.Users.Classes;

namespace ExaminationSystem.Exams.Interfaces
{
    public interface IExam
    {

        public int Time { get; set; }

        public int NumberOfQuestions { get; set; }

        public int SubjectId { get; set; }

        public void Show(Student student);


    }
}
