using ASPDOTNETBOLMVC6.Data;
using ASPDOTNETBOLMVC6.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace ASPDOTNETBOLMVC6.Repository.IRepository
{
    public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _db;
        public Repository(AppDbContext db)
        {
            _db = db;
        }

        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var result = await _db.Set<T>().ToListAsync();
            return result;
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
