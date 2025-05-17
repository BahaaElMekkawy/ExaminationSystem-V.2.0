using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Questions.Interfaces;
using ExaminationSystem.Subjects;

namespace ExaminationSystem.Exams.Interfaces
{
    public interface IExam
    {

        public int Time { get; set; }

        public int NumberOfQuestions { get; set; }

        public Subject Subject { get; set; }

        public void Show();


    }
}
