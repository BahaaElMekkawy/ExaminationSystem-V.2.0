using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DB.DTOs;
using ExaminationSystem.DB.Repos;
using ExaminationSystem.Questions.Classes;
using ExaminationSystem.Questions.Interfaces;
using ExaminationSystem.Users.Classes;

namespace ExaminationSystem.Exams.Classes
{
    public class FinalExam : Exam
    {
        Dictionary<IQuestion, List<int>> UserAnswers { get; set; }
        int TotalMarks { get; set; }
        int UserMarks { get; set; }
        public FinalExam(QuestionList questions, int numberOfQuestions,int subid, int time)
        {
            Questions = questions;
            NumberOfQuestions = numberOfQuestions;
            Time = time;
            SubjectId = subid;
            UserAnswers = new Dictionary<IQuestion, List<int>>();
            AskedQuestions = new HashSet<int>();
            random = new Random();
        }

        public override void Show(Student student)
        {
            int QuestionNumber = 1;

            while (AskedQuestions.Count < NumberOfQuestions)
            {
                Console.Clear();
                Console.WriteLine($"Final Exam ({NumberOfQuestions} Questions) - Time: {Time} Min\n");

                int randomIndex = random.Next(0, Questions.Count);
                if (AskedQuestions.Contains(randomIndex))
                    continue;

                AskedQuestions.Add(randomIndex);
                var question = Questions[randomIndex];
                TotalMarks += question.Mark;
                Console.WriteLine($"Question {QuestionNumber++}:\n");
                question.Display();

                Console.Write("Enter your answer: ");
                var input = Console.ReadLine();
                var userAnswerIds = input
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(id => int.Parse(id.Trim())).ToHashSet();
                var isCorrect = question.CheckAnswer(userAnswerIds);
                if (isCorrect == true)
                    UserMarks += question.Mark;

                UserAnswers[question] =  userAnswerIds.ToList() ;

                Console.WriteLine("Press any key for next question...");
                Console.ReadKey();
            }
            ShowResult(student);
        }

        public void ShowResult(Student student)
        {
            Console.Clear();
            Console.WriteLine($"Total Marks: {TotalMarks}");
            Console.WriteLine($"Your Marks: {UserMarks}");
            Console.WriteLine($"Your Score: {(UserMarks / (double)TotalMarks * 100):F2}%");

            var result = new StudentResultDto
            {
                StudentId = student.Id,
                StudentName = student.Name,
                TotalMarks = TotalMarks,
                UserMarks = UserMarks,
                SubjectId = SubjectId
            };

            var repo = new ResultsRepository();
            repo.SaveResult(result);
        }
    }
}
