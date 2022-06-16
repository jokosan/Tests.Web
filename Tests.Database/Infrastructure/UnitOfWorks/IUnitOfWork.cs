using System.Threading.Tasks;
using Tests.Database.Infrastructure.Repositories;
using Tests.Database.Model;

namespace Tests.Database.Infrastructure.UnitOfWorks
{
    public interface IUnitOfWork
    {
        void Dispose();
        Task Save();

        DbRepository<AnswerOptions> AnswerOptionsUnitOfWork { get; set; }
        DbRepository<Questions> QuestionsUnitOfWorks { get; set; }
        DbRepository<ListTests> TestUnitOfWork { get; set; }
        DbRepository<UserTest> UserTestUnitOfWork { get; set; }
    }
}
