using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Answers.Classes;

namespace ExaminationSystem.Questions.Classes
{
    public class ChooseMultipleQuestion : Question
    {
        public ChooseMultipleQuestion() : base()
        {
            Header = "Choose Multiple Question";
        }
        public ChooseMultipleQuestion(string body, AnswerList answerList, int subid, int mark)
        {
            Body = body;
            Answers = answerList;
            Mark = mark;
            SubjectId = subid;
            Header = "Choose Multiple Question";
        }
    }
}
