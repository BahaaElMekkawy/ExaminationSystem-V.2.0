using ExaminationSystem.Answers.Classes;
using ExaminationSystem.Questions.Interfaces;

namespace ExaminationSystem.Questions.Classes
{
    public static class QuestionFactory
    {
        public static IQuestion CreateTrueOrFalse()
        {
            var body = GetQuestionBodyFromUseer();
            var answers = AnswerInputHelper.GetTrueOrFalseAnswers();
            var mark = GetQuestionMarkFromUseer();
            return new TrueOrFalseQuestion(body, answers, mark);
        }

        public static IQuestion CreateChooseOne()
        {
            var body = GetQuestionBodyFromUseer();
            var answers = AnswerInputHelper.GetChooseOneAnswers();
            var mark = GetQuestionMarkFromUseer();
            return new ChooseOneQuestion(body, answers, mark);
        }
        public static IQuestion CreateChooseMultipleQuestion()
        {
            var body = GetQuestionBodyFromUseer();
            var answers = AnswerInputHelper.GetChooseMultipleAnswers();
            var mark = GetQuestionMarkFromUseer();
            return new ChooseMultipleQuestion(body, answers, mark);
        }

        public static IQuestion CreateChooseMultipleQuestion(string body, AnswerList answers, int mark)
        {
            return new ChooseMultipleQuestion(body, answers, mark);
        }

        public static IQuestion CreateTrueOrFalse(string body, AnswerList answers, int mark)
        {
            return new TrueOrFalseQuestion(body, answers, mark);
        }

        public static IQuestion CreateChooseOne(string body, AnswerList answers, int mark)
        {
            return new ChooseOneQuestion(body, answers, mark);
        }

 
        public static string GetQuestionBodyFromUseer()
        {
            Console.WriteLine("Enter The Question Body.");
            return Console.ReadLine();
        }
        public static int GetQuestionMarkFromUseer()
        {
            Console.WriteLine("Enter The Question Mark.");
            return int.Parse(Console.ReadLine());
        }
    }

}
