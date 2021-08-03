using AutoMapper;
using HashAspMoq.Core.Interfaces.Services;
using HashAspMoq.Dtos.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace HashAspMoq.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public TestsController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        public async Task<ActionResult> Index()
        {
            var allUsers =  _mapper.Map<List<UserDto>>(await _userService.GetAllAsync());

            return Ok(allUsers);
        }

    }
}
