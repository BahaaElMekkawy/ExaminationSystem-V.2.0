using ExaminationSystem.Exams.Classes;
using ExaminationSystem.Subjects;
using ExaminationSystem.Users.Classes;
using ExaminationSystem.ExamService.Classes;
using ExaminationSystem.Questions.Classes;
using ExaminationSystem.DB.Repos;
using ExaminationSystem.Questions.Interfaces;
using ExaminationSystem.DB.DTOs;


namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Admin", 1);
            //QuestionFactory.SetCurrentUser(admin);

            //QuestionList questions1 = new QuestionList();

            //bool addMore = true;
            //while (addMore)
            //{
            //    Console.WriteLine("Enter Type Of Questions U Want To Add.");
            //    Console.WriteLine("1|True Or False    2|ChooseOne   3|ChooseMultiple");
            //    int questionType = 0;
            //    int.TryParse(Console.ReadLine(), out questionType);
            //    IQuestion adminQuestion = QuestionFactory.CreateQuestionByType(questionType);
            //    questions1.AddQuestion(adminQuestion);
            //    Console.Clear();
            //    Console.WriteLine("Want To Add More Questions");
            //    Console.WriteLine("1|Yes 2|No");
            //    int addMoreInput = 0;
            //    int.TryParse(Console.ReadLine(), out addMoreInput);
            //    if (addMoreInput != 1)
            //        addMore = false;
            //}

            //List<QuestionDto> questionDtos = new List<QuestionDto>();
            //foreach (var question in questions1)
            //{
            //    var q1 = QuestionDto.ToDto(question);
            //    questionDtos.Add(q1);
            //}

            QuestionsRepository questionsRepository = new QuestionsRepository();

            //questionsRepository.SaveQuestionDtos(questionDtos);

            //**************************  the end of add questions **************************

            var mathQuestionsDtos = questionsRepository.LoadQuestions(200);

            var chemistryQuestionsDtos = questionsRepository.LoadQuestions(100);

            var mathQuestions = new QuestionList();

            foreach (var item in mathQuestionsDtos)
            {
                var q1 = QuestionDto.FromDto(item);
                mathQuestions.AddQuestion(q1);
            }

            Student student1 = new Student("Ahmed", 5);
            Student student2 = new Student("Sara", 6);

            Subject subject1 = new Subject("Math", 100);
            Subject subject2 = new Subject("Chemistry", 200);

            admin.StartExam(subject1);

            var practicalExam = new FinalExam(mathQuestions, 5, 100, 20);
            var finalExam = new FinalExam(mathQuestions, 5, 100, 20);

            student1.EnrollInSubject(200);
            student1.EnrollInSubject(100);


            ExamServices examService = new ExamServices();
            examService.TakeExam(practicalExam, student1, subject1);



























        }
    }
}

