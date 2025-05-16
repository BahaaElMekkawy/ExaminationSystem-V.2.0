using ExaminationSystem.Answers.Classes;
using ExaminationSystem.Answers.Interfaces;
using ExaminationSystem.Questions.Interfaces;

namespace ExaminationSystem.Questions.Classes
{
    public abstract class Question : IQuestion
    {
        public int Mark { get; set; }
        public string Body { get; set; }
        public string Header { get; set; }

        public AnswerList Answers { get; set; } = new AnswerList();


        public void Display() 
        {
            Console.WriteLine($"{Header}.\t[{Mark} Marks] \n{Body} : ");
            foreach (var answer in Answers)
            {
                Console.WriteLine($"{answer.Id}.{answer.Text}\t");
            }
            Console.WriteLine("\n");
        }
        
    }
}
