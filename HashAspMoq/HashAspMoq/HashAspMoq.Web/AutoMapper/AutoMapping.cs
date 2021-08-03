using AutoMapper;
using HashAspMoq.Core.Entties;
using HashAspMoq.Dtos.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAspMoq.Web.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }

    }
    
}
