using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Answers.Classes
{
    public class ChooseOneAnswer : Answer
    {
        public override bool ValidateAnswer(string answer)
        {
            return Text == answer;
        }
    }
}
