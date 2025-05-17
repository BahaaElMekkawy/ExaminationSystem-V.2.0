using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Questions.Classes;
using ExaminationSystem.Questions.Interfaces;

namespace ExaminationSystem.Exams.Classes
{
    public class PracticalExam : Exam
    {
        Dictionary<IQuestion, List<int>> CorrectAnswers { get; set; }
        public PracticalExam(QuestionList questions, int numberOfQuestions, int time)
        {
            Questions = questions;
            NumberOfQuestions = numberOfQuestions;
            Time = time;
            CorrectAnswers = new Dictionary<IQuestion, List<int>>();
            AskedQuestions = new HashSet<int>();
            random = new Random();

        }
       
        public override void Show()
        {
            int QuestionNumber = 1;

            while (AskedQuestions.Count < NumberOfQuestions)
            {
                Console.Clear();
                Console.WriteLine($"Practical Exam ({NumberOfQuestions} Questions) - Time: {Time} Min\n");

                int randomIndex = random.Next(0, Questions.Count);
                if (AskedQuestions.Contains(randomIndex))
                    continue;

                AskedQuestions.Add(randomIndex);
                var question = Questions[randomIndex];

                Console.WriteLine($"Question {QuestionNumber++}:\n");
                question.Display();

                Console.Write("Enter your answer: ");
                int userAnswerId = int.Parse(Console.ReadLine());

                var correctAnswersIds = Questions[randomIndex].Answers.Where(a => a.IsCorrect == true).Select(a => a.Id).ToList();
                CorrectAnswers[question] = correctAnswersIds;

                Console.WriteLine("Press any key for next question...");
                Console.ReadKey();
            }
            ShowCorrectAnswers();
        }

        public void ShowCorrectAnswers()
        {
            Console.Clear();
            Console.WriteLine("The Questions With Answers:");
            foreach (var question in CorrectAnswers)
            {
                Console.WriteLine(question.Key);
                Console.WriteLine($"Correct Answer Ids: {string.Join(',',question.Value)}\n");
                Console.WriteLine("**********************************");
            }
        }
    }
}