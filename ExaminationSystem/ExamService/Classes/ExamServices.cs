using ExaminationSystem.Exams.Interfaces;
using ExaminationSystem.Subjects;
using ExaminationSystem.Users.Classes;

namespace ExaminationSystem.ExamService.Classes
{
    public class ExamServices
    {
        public void TakeExam(IExam exam, Student student, Subject subject)
        {
            if (!subject.IsStarted)
            {
                Console.WriteLine($"Exam for subject {subject.Name} has not started yet.");
                return;
            }

            if (student.IsEnrolledInSubject(exam.SubjectId))
            {
                Console.WriteLine($"Student {student.Name} is taking the exam for subject {subject.Name}.");
                Console.WriteLine("Press Any Key to Start The Exam.");
                Console.ReadLine();
                exam.Show();
            }
            else
            {
                Console.WriteLine($"Student {student.Name} is not enrolled in the subject {subject.Name}.");
            }
        }

    }
}
