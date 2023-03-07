using System;
using Legend.Domain;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Legend.Domain.Interface;

namespace Legend.Data.Repositories
{
    public abstract class LegendRepository<T> : ILegendRepository<T> where T : class
    {
        protected readonly LegendContext _context;

        protected LegendRepository(LegendContext context)
        {
            _context = context;
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
    /* public class LegendRepository<T> : ILegendRepository<T> where T : BaseEntity
     {
         protected readonly LegendContext _context;
         private DbSet<T> _entities;
         string errorMessage = string.Empty;
         public LegendRepository(LegendContext context)
         {
             _context = context;
             _entities = _context.Set<T>();
         }
         public IEnumerable<T> GetAll()
         {
             return _entities.AsEnumerable();
         }

         public T GetById(Guid id)
         {
             return _entities.SingleOrDefault(s => s.Id == id);
         }

         public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
         {
             return _entities.Where(expression);
         }

         public void Insert(T entity)
         {
             if (entity == null) throw new ArgumentNullException("entity");

             _entities.Add(entity);
             _context.SaveChanges();
         }

         public void Update(T entity)
         {
             if (entity == null) throw new ArgumentNullException("entity");
             _context.SaveChanges();
         }

         public void Delete(Guid id)
         {
             if (id == null) throw new ArgumentNullException("entity");

             T entity = _entities.SingleOrDefault(s => s.Id == id);
             _entities.Remove(entity);
             _context.SaveChanges();
         }
     }*/
}


