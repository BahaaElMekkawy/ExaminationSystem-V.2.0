using ExaminationSystem.Answers.Classes;
using ExaminationSystem.Questions.Interfaces;
using ExaminationSystem.Users.Classes;
using ExaminationSystem.Users.Interfaces;

namespace ExaminationSystem.Questions.Classes
{
    public static class QuestionFactory
    {
        private static IUser currentUser;
        public static void SetCurrentUser(User user)
        {
            currentUser = user;
        }
        private static void CheckAdmin()
        {
            if (currentUser == null || currentUser.Role != "Admin") {
                Console.WriteLine("Only Admins Can Create Questions.");
                throw new Exception("Only Admins Can Create Questions.");
        } }
        public static IQuestion CreateTrueOrFalse()
        {
            CheckAdmin();
            var body = GetQuestionBodyFromAdmin();
            var answers = AnswerInputHelper.GetTrueOrFalseAnswers();
            var mark = GetQuestionMarkFromAdmin();
            var subid = GetQuestionSubjectIdFromAdmin();
            return new TrueOrFalseQuestion(body, answers, subid, mark);
        }

        public static IQuestion CreateChooseOne()
        {
            CheckAdmin();
            var body = GetQuestionBodyFromAdmin();
            var answers = AnswerInputHelper.GetChooseOneAnswers();
            var mark = GetQuestionMarkFromAdmin();
            var subid = GetQuestionSubjectIdFromAdmin();
            return new ChooseOneQuestion(body, answers, subid, mark);
        }
        public static IQuestion CreateChooseMultipleQuestion()
        {
            CheckAdmin();
            var body = GetQuestionBodyFromAdmin();
            var answers = AnswerInputHelper.GetChooseMultipleAnswers();
            var mark = GetQuestionMarkFromAdmin();
            var subid = GetQuestionSubjectIdFromAdmin();
            return new ChooseMultipleQuestion(body, answers, subid, mark);
        }

        public static IQuestion CreateChooseMultipleQuestion(string body, AnswerList answers, int subid,int mark)
        {
            CheckAdmin();
            return new ChooseMultipleQuestion(body, answers, subid, mark);
        }

        public static IQuestion CreateTrueOrFalse(string body, AnswerList answers, int subid,int mark)
        {
            CheckAdmin();
            return new TrueOrFalseQuestion(body, answers, subid, mark);
        }

        public static IQuestion CreateChooseOne(string body, AnswerList answers, int subid,int mark)
        {
            CheckAdmin();
            return new ChooseOneQuestion(body, answers, subid, mark);
        }

 
        public static string GetQuestionBodyFromAdmin()
        {
            Console.WriteLine("Enter The Question Body.");
            return Console.ReadLine();
        }
        public static int GetQuestionMarkFromAdmin()
        {
            Console.WriteLine("Enter The Question Mark.");
            return int.Parse(Console.ReadLine());
        }
        public static int GetQuestionSubjectIdFromAdmin()
        {
            Console.WriteLine("Enter The Question Subject ID.");
            return int.Parse(Console.ReadLine());
        }
    }

}
