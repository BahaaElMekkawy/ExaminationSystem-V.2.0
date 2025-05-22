using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Answers.Classes;
using ExaminationSystem.Questions.Classes;

namespace ExaminationSystem.DB.DTOs
{

    public class QuestionDto
    {
        public string QuestionType { get; set; }
        public int Mark { get; set; }
        public string Body { get; set; }
        public string Header { get; set; }
        public int SubjectId { get; set; }

        public List<AnswerDto> Answers { get; set; } = new List<AnswerDto>();

        public static QuestionDto ToDto(Question question)
        {
            return new QuestionDto
            {
                QuestionType = question.GetType().Name,
                Mark = question.Mark,
                Body = question.Body,
                Header = question.Header,
                SubjectId = question.SubjectId,
                Answers = question.Answers.Select(a => new AnswerDto { Id = a.Id, IsCorrect = a.IsCorrect, Text = a.Text }).ToList()
            };
        }

        public static Question FromDto(QuestionDto dto)
        {
            switch (dto.QuestionType)
            {
                case "TrueOrFalseQuestion":
                    return new TrueOrFalseQuestion
                    {
                        Mark = dto.Mark,
                        Body = dto.Body,
                        Header = dto.Header,
                        SubjectId = dto.SubjectId,
                        Answers = new AnswerList(dto.Answers.Select(a => new Answer
                        {
                            Id = a.Id,
                            IsCorrect = a.IsCorrect,
                            Text = a.Text
                        }).ToList())
                    };
                case "ChooseOneQuestion":
                    return new ChooseOneQuestion
                    {
                        Mark = dto.Mark,
                        Body = dto.Body,
                        Header = dto.Header,
                        SubjectId = dto.SubjectId,
                        Answers = new AnswerList(dto.Answers.Select(a => new Answer
                        {
                            Id = a.Id,
                            IsCorrect = a.IsCorrect,
                            Text = a.Text
                        }))
                    };

                case "ChooseMultipleQuestion":
                    return new ChooseMultipleQuestion
                    {
                        Mark = dto.Mark,
                        Body = dto.Body,
                        Header = dto.Header,
                        SubjectId = dto.SubjectId,
                        Answers = new AnswerList(dto.Answers.Select(a => new Answer
                        {
                            Id = a.Id,
                            IsCorrect = a.IsCorrect,
                            Text = a.Text
                        }))
                    };

                default:
                    throw new Exception($"Unknown question type: {dto.QuestionType}");
            }
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

