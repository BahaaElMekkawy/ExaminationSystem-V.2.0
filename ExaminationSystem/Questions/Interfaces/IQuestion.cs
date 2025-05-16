using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Answers.Classes;

namespace ExaminationSystem.Questions.Interfaces
{
    public interface IQuestion
    {
        public int Mark { get; set; }
        public string Body { get; set; }
        public string Header { get; set; }

        public AnswerList Answers { get; set; } 
        public void Display();

    }
}
