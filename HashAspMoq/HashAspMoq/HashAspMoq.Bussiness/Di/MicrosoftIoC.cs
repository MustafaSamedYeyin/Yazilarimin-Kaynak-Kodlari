using FluentValidation;
using HashAspMoq.Bussiness.Services;
using HashAspMoq.Bussiness.ValidationRules;
using HashAspMoq.Core.Interfaces.IUnitOfWork;
using HashAspMoq.Core.Interfaces.Repositories;
using HashAspMoq.Core.Interfaces.Services;
using HashAspMoq.Data.EntityFrameworkCore.Repositories;
using HashAspMoq.Data.UnitOfWork;
using HashAspMoq.Dtos.Dtos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAspMoq.Bussiness.Di
{
    public static class MicrosoftIoC
    {
        public static void AddDependencies(this IServiceCollection services)
        {

            #region servicesForRepositoriesAndServices
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository <>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            #region forValidators
            services.AddTransient<IValidator<UserDto>, UserDtoValidator>();
            #endregion
        }
    }
}
