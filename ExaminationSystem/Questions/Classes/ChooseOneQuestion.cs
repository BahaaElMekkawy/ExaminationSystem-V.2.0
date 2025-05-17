
using ExaminationSystem.Answers.Classes;

namespace ExaminationSystem.Questions.Classes
{
    public class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string body, AnswerList answerList, int mark)
        {
            Body = body;
            Answers = answerList;
            Mark = mark;
            Header = "Choose One Question";
        }
    }
}

