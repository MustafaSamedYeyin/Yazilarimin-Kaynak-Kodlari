using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAspMoq.Core.Interfaces.Services
{
    public interface IGenericService<TEntity> where TEntity : class,new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        TEntity Delete(TEntity entity);
        TEntity Update(TEntity entity);
        Task<TEntity> CreateAsync(TEntity entity);
    }
}
