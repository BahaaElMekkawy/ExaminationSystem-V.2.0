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
        public ChooseMultipleQuestion(string body, AnswerList answerList, int mark)
        {
            Body = body;
            Answers = answerList;
            Mark = mark;
            Header = "Choose Multiple Question";
        }
    }
}
