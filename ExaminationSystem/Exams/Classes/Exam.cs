
using ExaminationSystem.Exams.Interfaces;
using ExaminationSystem.Questions.Interfaces;
using ExaminationSystem.Subjects;

namespace ExaminationSystem.Exams.Classes
{
    public abstract class Exam : IExam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<IQuestion, List<int>> QuestionAnswerMap { get; set; }
        public Subject Subject { get; set; }
        public abstract void Show();
    }

}
