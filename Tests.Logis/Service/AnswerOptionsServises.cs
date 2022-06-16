using System.Collections.Generic;
using System.Linq;
using Tests.Database.Infrastructure.UnitOfWorks;
using Tests.Database.Model;
using Tests.Logis.ModelView;

namespace Tests.Logis.Service
{
    public class AnswerOptionsServises
    {
        private readonly IUnitOfWork _unitOfWork;

        public AnswerOptionsServises(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<TestResultModel> TestResults(IEnumerable<Questions> questions, IEnumerable<AnswerOptions> answers)
        {
            List<TestResultModel> testResultList = new();
            int number = 1;

            foreach (var item in answers)
            {
                testResultList.Add(new TestResultModel
                {
                    id = number,
                    QuestionText = questions.FirstOrDefault(x => x.IdQuestions == item.QuestionsId).QuestionText,
                    Possiblenswer = GetQuestions(questions, item.IdAnswerOptions),
                    ResultAnswer = QuestionAnswerResult(questions, item.IdAnswerOptions)
                });

                number++;
            }

            return testResultList.AsEnumerable();
        }

        private string GetQuestions(IEnumerable<Questions> questions, int idAnswers)
        {
            foreach (var item in questions)
            {
                foreach (var itemAnswer in item.AnswerOptions)
                {
                    if (idAnswers == itemAnswer.IdAnswerOptions)
                    {
                        return itemAnswer.Possiblenswer;
                    }
                }
            }

            return "Дуже шкода, але ви пропустили це питання";
        }

        private bool QuestionAnswerResult(IEnumerable<Questions> questions, int idAnswers)
            => questions.FirstOrDefault(q => q.AnswerOptions.Any(a => a.IdAnswerOptions == idAnswers)).AnswerOptions.FirstOrDefault(x => x.IdAnswerOptions == idAnswers).CorrectAnswer.Value;
    }
}
