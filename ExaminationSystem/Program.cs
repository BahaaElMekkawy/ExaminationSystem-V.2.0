using ExaminationSystem.Answers.Classes;
using ExaminationSystem.Answers.Interfaces;
using ExaminationSystem.Questions.Classes;
using ExaminationSystem.Questions.Interfaces;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IQuestion question = new TrueOrFalseQuestion() 
            {
                Mark = 5,
                Body = "Is the sky blue?",
                Header = "True Or False Question",
            };
            question.Answers.AddAnswer(new ChooseOneAnswer { Id = 1, Text = "True", IsCorrect = true });
            question.Answers.AddAnswer(new ChooseOneAnswer { Id = 2, Text = "False", IsCorrect = false });
            IQuestion question2 = new ChooseOneQuestion()
            {
                Mark = 5,
                Body = "What Is The Sky Color?",
                Header = "Choose One Answer",
                Answers = new AnswerList()
                {
                    new ChooseOneAnswer() { Id =1 ,Text = "Red", IsCorrect = false },
                    new ChooseOneAnswer() { Id =2 ,Text = "Green", IsCorrect = false },
                    new ChooseOneAnswer() { Id =3 ,Text = "Blue", IsCorrect = true },
                    new ChooseOneAnswer() { Id =4 ,Text = "White", IsCorrect = false }
                }
            };

            question.Display();
            question2.Display();





















        }
    }
}
