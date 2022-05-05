using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Contracts
{

    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly MwDbContext _CONTEXT;
        public Repository(MwDbContext CONTEXT)
        {
            _CONTEXT = CONTEXT;
        }

        public void AddRepAsync(T Entity)
        {
            _CONTEXT.Add<T>(Entity);
        }

        public void DeleteRepAsync(T Entity)
        {
            _CONTEXT.Remove<T>(Entity);
        }

        public async Task<List<T>> GetAllRepAsync()
        {
            return await _CONTEXT.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdRepAsync(Expression<Func<T, bool>> predicate)
        {
            return await _CONTEXT.Set<T>().AsNoTracking().SingleOrDefaultAsync(predicate);
        }

        public void UpdateRepAsync(T Entity)
        {
           _CONTEXT.Entry(Entity).State = EntityState.Modified;
           _CONTEXT.Set<T>().Update(Entity);
        }
    }
}
