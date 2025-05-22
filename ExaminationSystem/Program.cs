using ExaminationSystem.Exams.Classes;
using ExaminationSystem.Subjects;
using ExaminationSystem.Users.Classes;
using ExaminationSystem.ExamService.Classes;
using ExaminationSystem.Questions.Classes;
using ExaminationSystem.DB.Repos;


namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Admin admin = new Admin("Admin", 1);
            //QuestionList questions1 = new QuestionList();
            //QuestionFactory.SetCurrentUser(admin);
            //var q1 = QuestionFactory.CreateChooseOne();
            //Console.Clear();
            //var q2 = QuestionFactory.CreateChooseMultipleQuestion();
            //Console.Clear();
            //var q3 = QuestionFactory.CreateTrueOrFalse();
            //Console.Clear();
            //questions1.Add(q1);
            //questions1.Add(q2);
            //questions1.Add(q3);

            QuestionsRepository questionRepository = new QuestionsRepository();

            //questionRepository.SaveQuestions(questions1);

            var questions2 = questionRepository.LoadQuestions();

            foreach (var question in questions2)
            {
                Console.WriteLine(question);
            }










            //foreach (var question in questions1)
            //{
            //    question.Display();
            //}

            //var questions = SeedingData.GenerateQuestions();

            //var practicalExam = new PracticalExam(questions, 5, 100, 20);
            //var finalExam = new FinalExam(questions, 5,100, 20);

            //Student student1 = new Student("Ahmed", 5);
            //Student student2 = new Student("Sara", 6);

            //Subject subject1 = new Subject("Math", 100);
            //Subject subject2 = new Subject("Chemistry", 200);

            //student1.EnrollInSubject(100);
            //student1.EnrollInSubject(200);

            //ExamServices examService = new ExamServices();

            //Admin admin = new Admin("Admin", 1);
            //admin.StartExam(subject1);

            //examService.TakeExam(finalExam, student1 , subject1);

























            //Console.WriteLine("Enter Which Exam U Want To Start 1|Practical 2|Final");
            //var input = int.Parse(Console.ReadLine());
            //if (input == 1)
            //{
            //    practicalExam.Show();
            //}
            //else if (input == 2)
            //{
            //    finalExam.Show();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            //Console.ReadLine();
        }
    }
}

