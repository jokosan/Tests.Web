using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Tests.Database.Context;

namespace Tests.Database.Infrastructure.Repositories
{
    public class DbRepository<T> : IDbRepository<T> where T : class
    {
        private readonly UserTestingDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public DbRepository(UserTestingDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        #region Get
        public async Task<IEnumerable<T>> Get()
        {
            Lazy<T> lazy = new Lazy<T>();

            var query = await _dbSet.AsEnumerable<T>()
                                    .AsQueryable()
                                    .AsNoTracking()
                                    .ToListAsync();

            return query;
        }

        public async Task<T> GetById(int? id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> QueryObjectGraph(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.Where(filter).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<T>> QueryObjectGraph(Expression<Func<T, bool>> filter, string children)
        {
            return await _dbSet.Include(children).Where(filter).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<T>> QueryObjectGraph(Expression<Func<T, bool>> filter, string children, string childrenTwo)
        {
            return await _dbSet.Include(children).Include(childrenTwo).Where(filter).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetInclude(string children)
        {
            return await _dbSet.Include(children).AsNoTracking().AsEnumerable<T>().AsQueryable().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetInclude(string children, string childrenTwo)
        {
            return await _dbSet.Include(children).Include(childrenTwo).AsNoTracking().AsEnumerable<T>().AsQueryable().ToListAsync();
        }
        public async Task<IEnumerable<T>> GetInclude(string children, string childrenTwo, string childrenThree)
        {
            return await _dbSet.Include(children).Include(childrenTwo).Include(childrenThree).AsNoTracking().AsEnumerable<T>().AsQueryable().ToListAsync();
        }
        #endregion

        #region CRUD
        public virtual void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            T entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(T entityToDelete)
        {
            if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }

            _dbSet.Remove(entityToDelete);
        }

        public virtual void Update(T entityToUpdate)
        {
            var dbEntityEntry = _dbContext.Entry(entityToUpdate);
            dbEntityEntry.CurrentValues.SetValues(entityToUpdate);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _dbContext.Attach(entityToUpdate);
            }

            dbEntityEntry.State = EntityState.Modified;
        }

        public virtual void Update(T entityToUpdate, T getEntity)
        {
            var dbEntityEntry = _dbContext.Entry(getEntity);
            dbEntityEntry.CurrentValues.SetValues(entityToUpdate);
            dbEntityEntry.State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
