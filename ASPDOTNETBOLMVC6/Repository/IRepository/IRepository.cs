using System.Linq.Expressions;
using ASPDOTNETBOLMVC6.Repository.Base;

namespace ASPDOTNETBOLMVC6.Repository.IRepository
{
    public interface IRepository<T> where T:class, IEntityBase, new()
    {
        
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        Task<T> Update(int id,T entity);
        void Delete(int id);
    }
}
