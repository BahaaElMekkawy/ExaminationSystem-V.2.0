using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ExaminationSystem.Questions.Classes;
using ExaminationSystem.DB.DTOs;

namespace ExaminationSystem.DB.Repos
{
    public class QuestionsRepository
    {
        string _filePath = @"D:\ITI\C#\LABS\VisualCSharp\Examination System\ExaminationSystem\ExaminationSystem\DB\Json\Questions.json";
        public List<QuestionDto> LoadQuestions()
        {
            if (!File.Exists(_filePath))
                return new List<QuestionDto>();

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<QuestionDto>>(json) ?? new List<QuestionDto>();
        }

        public List<QuestionDto> LoadQuestions(int subid)
        {
            if (!File.Exists(_filePath))
                return new List<QuestionDto>();

            string json = File.ReadAllText(_filePath);
            var allQuestions = JsonSerializer.Deserialize<List<QuestionDto>>(json) ?? new List<QuestionDto>();

            // Filter questions by SubjectId
            return allQuestions.Where(q => q.SubjectId == subid).ToList();
        }

        public void SaveQuestionDtos(List<QuestionDto> newQuestionDtos)
        {
            var existingQuestions = LoadQuestions(); // Load existing data
            existingQuestions.AddRange(newQuestionDtos); // Add new questions

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(existingQuestions, options);
            File.WriteAllText(_filePath, json); // Save all data back
        }

    }
}
