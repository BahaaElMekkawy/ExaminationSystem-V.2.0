using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ExaminationSystem.DB.DTOs;

namespace ExaminationSystem.DB.Repos
{
    public class ResultsRepository
    {
        private readonly string _filePath = "D:\\ITI\\C#\\LABS\\VisualCSharp\\Examination System\\ExaminationSystem\\ExaminationSystem\\DB\\Json\\StudentsMarks.json";

        public void SaveResult(StudentResultDto result)
        {
            var allResults = LoadAllResults();
            allResults.Add(result);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(allResults, options);
            File.WriteAllText(_filePath, json);
        }


        public List<StudentResultDto> LoadAllResults()
        {
            if (!File.Exists(_filePath))
                return new List<StudentResultDto>();

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<StudentResultDto>>(json) ?? new List<StudentResultDto>();
        }
    }

}
