using HashAspMoq.Core.Interfaces.IUnitOfWork;
using HashAspMoq.Core.Interfaces.Repositories;
using HashAspMoq.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAspMoq.Bussiness.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class, new()
    {
        protected readonly IGenericRepository<TEntity> _genericRepository;
        protected readonly IUnitOfWork _unitOfWork;

        public GenericService(IGenericRepository<TEntity> genericRepository, IUnitOfWork unitOfWork)
        {
            _genericRepository = genericRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var createdEntity = await _genericRepository.CreateAync(entity);
            await _unitOfWork.CommitAsync();
            return createdEntity;
        }

        public TEntity Delete(TEntity entity)
        {
             var deletedEntity = _genericRepository.Delete(entity);
            _unitOfWork.Commit();
            return deletedEntity;
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            return _genericRepository.GetAllAsync();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            var entity = _genericRepository.GetByIdAsync(id);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            var updatedEntity = _genericRepository.Update(entity);
            _unitOfWork.Commit();
            return updatedEntity;
        }

        public void CreateTwoEntity(TEntity one, TEntity two)
        {
            _genericRepository.CreateAync(one);

            _genericRepository.CreateAync(two);
        }
    }
}
