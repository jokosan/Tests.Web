using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tests.Database.Infrastructure.UnitOfWorks;
using Tests.Database.Model;

namespace Tests.Logis.Service
{
    public class QuestionsServises
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionsServises(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Questions>> GetAllQuestionByIdListTests(int id)
            => await _unitOfWork.QuestionsUnitOfWorks.QueryObjectGraph(x => x.TestsId == id, "AnswerOptions");

        public async Task<IEnumerable<Questions>> GetQuestionsRandom(int id)
        {
            var getResult = await GetAllQuestionByIdListTests(id);
            var resultListRandom = new List<Questions>();

            Random random = new Random();

            foreach (var item in getResult)
            {
                int number = random.Next(resultListRandom.Count + 1);

                if (number == resultListRandom.Count)
                {
                    resultListRandom.Add(item);
                }
                else
                {
                    resultListRandom.Add(resultListRandom[number]);
                    resultListRandom[number] = item;
                }
            }

            return resultListRandom.AsEnumerable();
        }
    }
}
