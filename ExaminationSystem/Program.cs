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

            //questions.AddQuestion(QuestionFactory.CreateChooseOne());
            //questions.AddQuestion(QuestionFactory.CreateTrueOrFalse());


            //foreach (var questionn in questions)
            //{
            //    questionn.Display();
            //    Console.WriteLine("\n");
            //    Console.WriteLine("Enter The Correct Answer Id.");
            //    int correctanswer1 = int.Parse(Console.ReadLine());
            //    var answer = questionn.CheckAnswer(correctanswer1);
            //    Console.WriteLine(answer);
            //}






            var questions = SeedingData.GenerateQuestions();

            var exam = new PracticalExam(questions);

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

