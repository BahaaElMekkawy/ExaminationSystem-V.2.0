using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Answers.Classes;

namespace ExaminationSystem.Questions.Classes
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion()
        {
            Header = "True Or False Question";
        }
        public TrueOrFalseQuestion(string body, AnswerList answers, int subid,int mark )
        {
            Body = body;
            Mark = mark;
            Header = "True Or False Question";
            Answers = answers;
            SubjectId = subid;

        }
    }
}
