
using ExaminationSystem.Answers.Classes;

namespace ExaminationSystem.Questions.Classes
{
    public class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion()
        {

        }
        public ChooseOneQuestion(string body, AnswerList answerList, int subid,int mark)
        {
            Body = body;
            Answers = answerList;
            Mark = mark;
            SubjectId = subid;
            Header = "Choose One Question";
        }
    }
}

