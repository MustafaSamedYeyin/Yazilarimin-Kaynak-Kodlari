using HashAspMoq.Core.Entties;
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
   public class UserService :  GenericService<User>, IUserService
    {
        public UserService(IGenericRepository<User> genericRepository,IUnitOfWork unitOfWork ) : base(genericRepository,unitOfWork)
        {
        }
    }
}
