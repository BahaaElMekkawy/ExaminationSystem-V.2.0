//using ExaminationSystem.Answers.Classes;
//using ExaminationSystem.Questions.Classes;

//namespace ExaminationSystem
//{
//    public static class SeedingData
//    {
//        public static QuestionList GenerateQuestions()
//        {
//            var questions = new QuestionList();

//            // Question 1: True or False
//            var tfAnswers = new AnswerList();
//            tfAnswers.AddAnswer(new Answer { Id = 1, Text = "True", IsCorrect = true });
//            tfAnswers.AddAnswer(new Answer { Id = 2, Text = "False", IsCorrect = false });

//            questions.Add(QuestionFactory.CreateTrueOrFalse("The sky is blue.", tfAnswers, 100, 5));

//            // Question 2: Choose One
//            var coAnswers = new AnswerList();
//            coAnswers.AddAnswer(new Answer { Id = 1, Text = "2", IsCorrect = false });
//            coAnswers.AddAnswer(new Answer { Id = 2, Text = "3", IsCorrect = false });
//            coAnswers.AddAnswer(new Answer { Id = 3, Text = "4", IsCorrect = true });
//            coAnswers.AddAnswer(new Answer { Id = 4, Text = "5", IsCorrect = false });

//            questions.Add(QuestionFactory.CreateChooseOne("What is 2 + 2?", coAnswers, 100, 5));

//            // Question 2: Choose One
//            var coAnswers1 = new AnswerList();
//            coAnswers1.AddAnswer(new Answer { Id = 1, Text = "2", IsCorrect = false });
//            coAnswers1.AddAnswer(new Answer { Id = 2, Text = "3", IsCorrect = false });
//            coAnswers1.AddAnswer(new Answer { Id = 3, Text = "6", IsCorrect = true });
//            coAnswers1.AddAnswer(new Answer { Id = 4, Text = "5", IsCorrect = false });

//            questions.Add(QuestionFactory.CreateChooseOne("3 + 2 + 1?", coAnswers1, 100, 6));

//            // Question 1: True or False
//            var tfAnswers1 = new AnswerList();
//            tfAnswers1.AddAnswer(new Answer { Id = 1, Text = "True", IsCorrect = false });
//            tfAnswers1.AddAnswer(new Answer { Id = 2, Text = "False", IsCorrect = true });

//            questions.Add(QuestionFactory.CreateTrueOrFalse("The sky is red.", tfAnswers1, 100, 5));


//            // Question 1: True or False
//            var tfAnswers2 = new AnswerList();
//            tfAnswers2.AddAnswer(new Answer { Id = 1, Text = "True", IsCorrect = false });
//            tfAnswers2.AddAnswer(new Answer { Id = 2, Text = "False", IsCorrect = true });

//            questions.Add(QuestionFactory.CreateTrueOrFalse("The sky is green.", tfAnswers2, 100, 5));

//            // Question 2: Choose One
//            var coAnswers4 = new AnswerList();
//            coAnswers4.AddAnswer(new Answer { Id = 1, Text = "2", IsCorrect = false });
//            coAnswers4.AddAnswer(new Answer { Id = 2, Text = "-3", IsCorrect = true });
//            coAnswers4.AddAnswer(new Answer { Id = 3, Text = "6", IsCorrect = false });
//            coAnswers4.AddAnswer(new Answer { Id = 4, Text = "5", IsCorrect = false });

//            questions.Add(QuestionFactory.CreateChooseOne("2 -5?", coAnswers4, 100, 6));

//            // Question 2: Choose Multiple
//            var coAnswers5 = new AnswerList();
//            coAnswers5.AddAnswer(new Answer { Id = 1, Text = "SRP", IsCorrect = true });
//            coAnswers5.AddAnswer(new Answer { Id = 2, Text = "OCP", IsCorrect = true });
//            coAnswers5.AddAnswer(new Answer { Id = 3, Text = "Encapsulation", IsCorrect = false });
//            coAnswers5.AddAnswer(new Answer { Id = 4, Text = "DIP", IsCorrect = true });

//            questions.Add(QuestionFactory.CreateChooseMultipleQuestion("What of these is consider a SOLID principle", coAnswers5, 100, 10));

//            return questions;
//        }
//    }
//}