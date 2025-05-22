using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Questions.Interfaces;

namespace ExaminationSystem.Questions.Classes
{
    public class QuestionList : List<IQuestion>
    {
        public void AddQuestion(IQuestion question)
        {
            this.Add(question);
        }
        public void RemoveQuestion(IQuestion question)
        {
            this.Remove(question);
        }
    }
    
}
