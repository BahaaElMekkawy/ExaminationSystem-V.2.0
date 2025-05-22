
using ExaminationSystem.Exams.Interfaces;
using ExaminationSystem.Questions.Classes;
using ExaminationSystem.Questions.Interfaces;
using ExaminationSystem.Subjects;
using ExaminationSystem.Users.Classes;

namespace ExaminationSystem.Exams.Classes
{
    public abstract class Exam : IExam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public int SubjectId { get; set; }

        protected QuestionList Questions;

        protected HashSet<int> AskedQuestions;

        protected int askedQuestionsCount = 0;

        protected Random random ;
        public abstract void Show(Student student);
    }

}
