using ExaminationSystem.Answers.Classes;
using ExaminationSystem.Answers.Interfaces;
using ExaminationSystem.Exams.Classes;
using ExaminationSystem.Questions.Classes;
using ExaminationSystem.Questions.Interfaces;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var questions = SeedingData.GenerateQuestions();

            var exam = new FinalExam(questions,2,20);

            exam.Show();


            //foreach (var question in questions)
            //{
            //    Console.Clear();
            //    question.Display();
            //    Console.ReadLine();
            //}






        }
    }
}

