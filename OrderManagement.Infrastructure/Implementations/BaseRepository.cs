using MongoDB.Driver;
using OrderManagement.Infrastructure.Interfaces;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure.Implementations
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly IMongoContext _context;
        protected readonly IMongoCollection<TEntity> _dbSet;

        protected BaseRepository(IMongoContext context)
        {
            _context = context;
            _dbSet = _context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public virtual Task Add(TEntity obj)
        {
            return _context.AddCommand(async () => await _dbSet.InsertOneAsync(obj));
        }

        public virtual Task AddRange(IEnumerable<TEntity> obj)
        {
            return _context.AddCommand(async () => await _dbSet.InsertManyAsync(obj));
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            var data = await _dbSet.FindAsync(Builders<TEntity>.Filter.Eq(" _id ", id));
            return data.FirstOrDefault();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            var all = await _dbSet.FindAsync(Builders<TEntity>.Filter.Empty);
            return all.ToList();
        }

        public virtual Task Update(TEntity obj)
        {
            return _context.AddCommand(async () =>
            {
                await _dbSet.ReplaceOneAsync(Builders<TEntity>.Filter.Eq(" _id ", obj.GetId()), obj);
            });
        }

        public virtual Task Remove(Guid id) => _context.AddCommand(() => _dbSet.DeleteOneAsync(Builders<TEntity>.Filter.Eq(" _id ", id)));

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
