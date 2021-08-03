using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAspMoq.Core.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class,new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        TEntity Delete(TEntity entity);
        TEntity Update(TEntity entity);
        Task<TEntity> CreateAync(TEntity entity);
    }
}
