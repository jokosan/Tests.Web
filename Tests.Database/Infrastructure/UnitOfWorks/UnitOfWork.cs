using System;
using System.Threading.Tasks;
using Tests.Database.Context;
using Tests.Database.Infrastructure.Repositories;
using Tests.Database.Model;

namespace Tests.Database.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private UserTestingDbContext _dbContext;

        public UnitOfWork(UserTestingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private DbRepository<AnswerOptions> AnswerOptionsUW { get; set; }
        private DbRepository<Questions> QuestionsUW { get; set; }
        private DbRepository<ListTests> TestUW { get; set; }
        private DbRepository<UserTest> UserTestUW { get; set; }

        public DbRepository<AnswerOptions> AnswerOptionsUnitOfWork { get => AnswerOptionsUW ?? (AnswerOptionsUW = new DbRepository<AnswerOptions>(_dbContext)); set => AnswerOptionsUW = value; }
        public DbRepository<Questions> QuestionsUnitOfWorks { get => QuestionsUW ?? (QuestionsUW = new DbRepository<Questions>(_dbContext)); set => QuestionsUW = value; }
        public DbRepository<ListTests> TestUnitOfWork { get => TestUW ?? (TestUW = new DbRepository<ListTests>(_dbContext)); set => TestUW = value; }
        public DbRepository<UserTest> UserTestUnitOfWork { get => UserTestUW ?? (UserTestUW = new DbRepository<UserTest>(_dbContext)); set => UserTestUW = value; }

        #region Dispose
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }

                this.disposed = true;
            }
        }
        #endregion

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
