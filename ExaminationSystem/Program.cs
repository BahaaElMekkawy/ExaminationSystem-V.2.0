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

            var practicalExam = new PracticalExam(questions, 5, 20);
            var finalExam = new PracticalExam(questions, 5, 20);


            Console.WriteLine("Enter Which Exam U Want To Start 1|Practical 2|Final");
            var input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                practicalExam.Show();
            }
            else if (input == 2)
            {
                finalExam.Show();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


        }
    }
}

