using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task Add(TEntity obj);
        Task AddRange(IEnumerable<TEntity> obj);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Update(TEntity obj);
        Task Remove(Guid id);
    }
}
