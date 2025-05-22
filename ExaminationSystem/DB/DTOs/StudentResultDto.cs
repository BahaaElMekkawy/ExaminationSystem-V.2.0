using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DB.DTOs
{
    public class StudentResultDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int SubjectId { get; set; }
        public int TotalMarks { get; set; }
        public int UserMarks { get; set; }

        // This property calculates the percentage automatically
        public double ScorePercentage => TotalMarks == 0 ? 0 : (UserMarks / (double)TotalMarks) * 100;
    }
}
