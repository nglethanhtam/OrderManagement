using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure.Interfaces
{
    public interface IMongoContext
    {
        int SaveChanges();
        IMongoCollection<T> GetCollection<T>(string name);
        void Dispose();
        Task AddCommand(Func<Task> func);
    }
}
