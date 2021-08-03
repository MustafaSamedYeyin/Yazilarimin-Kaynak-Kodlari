using HashAspMoq.Core.Entties;
using HashAspMoq.Core.Interfaces.Repositories;
using HashAspMoq.Data.EntityFrameworkCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAspMoq.Data.EntityFrameworkCore.Repositories
{
    public class UserRepository : GenericRepository<User>,IUserRepository
    {
        public AppDbContext AppDbContext
        {
            get
            {
                return _appDbContext;
            }
        }
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }

        
    }
}
