using System;
using System.Linq.Expressions;

namespace Legend.Domain.Interface
{
    public interface ILegendRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}

