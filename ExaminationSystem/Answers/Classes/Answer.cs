
using ExaminationSystem.Answers.Interfaces;

namespace ExaminationSystem.Answers.Classes
{
    public  abstract class Answer : IAnswer
    {
        public int Id { get ; set  ; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public abstract bool ValidateAnswer(string answer);
      
    }
}
