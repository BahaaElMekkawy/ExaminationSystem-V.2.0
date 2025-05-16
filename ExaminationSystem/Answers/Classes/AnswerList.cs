using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Answers.Interfaces;

namespace ExaminationSystem.Answers.Classes
{
    public class AnswerList : List<IAnswer>
    {
        public void AddAnswer(Answer answer)
        {
            this.Add(answer);
        }
        public void RemoveAnswer(Answer answer)
        {
            this.Remove(answer);
        }
    }
}
