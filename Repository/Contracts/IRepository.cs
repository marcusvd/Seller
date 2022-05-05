using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface IRepository<T> where T : class
    {
        void AddRepAsync(T Entity);
        void UpdateRepAsync(T Entity);
        void DeleteRepAsync(T Entity);
        Task<List<T>>GetAllRepAsync();
        Task<T>GetByIdRepAsync(Expression<Func<T, bool>> predicate);

    }
}
