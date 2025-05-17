using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Questions.Classes;

namespace ExaminationSystem.Exams.Classes
{
    public class FinalExam : Exam
    {
        public FinalExam(QuestionList questions)
        {
            
        }
        public override void Show()
        {
            for (int i = 1; i <= NumberOfQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine($"Question{i}");
                Console.WriteLine($"Final Exam {NumberOfQuestions} Questions Time: {Time}");
            }
        }
    }
}
