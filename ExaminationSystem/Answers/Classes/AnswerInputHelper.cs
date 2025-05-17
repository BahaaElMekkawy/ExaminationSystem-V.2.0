using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Answers.Classes
{
    public class AnswerInputHelper
    {
        public static AnswerList GetTrueOrFalseAnswers()
        {
            var answers = new AnswerList();

            // Predefined answers
            answers.Add(new Answer { Id = 1, Text = "True", IsCorrect = false });
            answers.Add(new Answer { Id = 2, Text = "False", IsCorrect = false });

            Console.WriteLine("Enter the correct answer ID (1 For True, 2 For False):");
            int correctId = int.Parse(Console.ReadLine());

            var correctAnswer = answers.FirstOrDefault(a => a.Id == correctId);
            if (correctAnswer != null)
            {
                correctAnswer.IsCorrect = true;
            }

            return answers;
        }

        public static AnswerList GetChooseOneAnswers()
        {
            var answers = new AnswerList();

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Enter Answer {i}: ");
                string text = Console.ReadLine();
                answers.Add(new Answer
                {
                    Id = i,
                    Text = text,
                    IsCorrect = false
                });
            }

            Console.Write("Enter The ID Of The Correct Answer (1-4): ");
            int correctId = int.Parse(Console.ReadLine());

            var correctAnswer = answers.FirstOrDefault(a => a.Id == correctId);
            if (correctAnswer != null)
            {
                correctAnswer.IsCorrect = true;
            }

            return answers;
        }
        public static AnswerList GetChooseMultipleAnswers()
        {
            var answers = new AnswerList();

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Enter Answer {i}: ");
                string text = Console.ReadLine();
                answers.Add(new Answer
                {
                    Id = i,
                    Text = text,
                    IsCorrect = false
                });
            }

            Console.Write("Enter The ID Of The Correct Answers Note Write Them with ',' Seperated: ");
            var correctIds = Console.ReadLine();
            var correctIdsList = correctIds.Split(',').Select(int.Parse).ToList();

            foreach (var correctId in correctIdsList)
            {
                var correctAnswer = answers.FirstOrDefault(a => a.Id == correctId);
                if (correctAnswer != null)
                {
                    correctAnswer.IsCorrect = true;
                }
            }
            return answers;
        }
    }
}
