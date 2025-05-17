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
        readonly QuestionList questions;
        HashSet<int> askedQuestions = new HashSet<int>();
        int askedQuestionsCount = 0;
        Random random = new Random();
        public PracticalExam(QuestionList _questions)
        {
            Console.WriteLine("Enter The Number of Question of the Exam");
            NumberOfQuestions = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Time of the Exam");
            Time = int.Parse(Console.ReadLine());
            questions = _questions;
            QuestionAnswerMap = new Dictionary<IQuestion, List<int>>();
          
        }
        public override void Show()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine($"Practical Exam {NumberOfQuestions} Questions Time: {Time} Min");
                Console.Clear();
                while (askedQuestionsCount <= NumberOfQuestions)
                {
                    int randomIndex = random.Next(0, questions.Count-1);
                    if (!askedQuestions.Contains(randomIndex))
                    {
                        askedQuestionsCount++;
                        Console.Clear();
                        Console.WriteLine($"Question {i + 1}");
                        askedQuestions.Add(randomIndex);
                        questions[randomIndex].Display();
                        Console.WriteLine("Enter the Answer");
                        var answer = int.Parse(Console.ReadLine());
                        var correctAnswersIds = questions[randomIndex].Answers.Where(a => a.IsCorrect == true).Select(a => a.Id).ToList();
                        QuestionAnswerMap.Add(questions[randomIndex],  correctAnswersIds );
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("The Questions With Answers");
                foreach (var question in QuestionAnswerMap)
                {
                    Console.WriteLine(question.Key);
                    Console.WriteLine($"Correct Answer Id : {question.Value[0]}");
                }
            }
        }
    }
}