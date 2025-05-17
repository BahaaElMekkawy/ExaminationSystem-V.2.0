using System.Text;
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
        public virtual bool CheckAnswer(int answerId)
        {
            var answer = Answers.FirstOrDefault(x => x.Id == answerId);
            if (answer != null)
            {
                return answer.IsCorrect;
            }
            return false;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Header}.\t[{Mark} Marks]");
            sb.AppendLine($"{Body} :");

            foreach (var answer in Answers)
            {
                sb.AppendLine($"{answer.Id}. {answer.Text}");
            }

            return sb.ToString();
        }
    }
}
