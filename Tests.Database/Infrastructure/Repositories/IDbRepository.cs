using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Tests.Database.Infrastructure.Repositories
{
    public interface IDbRepository<T> where T : class
    {
        void Delete(object id);
        void Delete(T entityToDelete);
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int? id);
        Task<IEnumerable<T>> GetInclude(string children);
        Task<IEnumerable<T>> GetInclude(string children, string childrenTwo);
        Task<IEnumerable<T>> GetInclude(string children, string childrenTwo, string childrenThree);
        void Insert(T entity);
        Task<IEnumerable<T>> QueryObjectGraph(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>> QueryObjectGraph(Expression<Func<T, bool>> filter, string children);
        Task<IEnumerable<T>> QueryObjectGraph(Expression<Func<T, bool>> filter, string children, string childrenTwo);
        void Update(T entityToUpdate);
        void Update(T entityToUpdate, T getEntity);
    }
}