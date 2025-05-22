using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Questions.Interfaces;

namespace ExaminationSystem.Questions.Classes
{
    public class QuestionList : List<Question>
    {
        public void AddQuestion(Question question)
        {
            this.Add(question);
        }
        public void RemoveQuestion(Question question)
        {
            this.Remove(question);
        }
    }
    
}
