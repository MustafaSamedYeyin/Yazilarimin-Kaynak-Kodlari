using AutoMapper;
using HashAspMoq.Core.Interfaces.Services;
using HashAspMoq.Dtos.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashAspMoq.Web.Controllers
{
    public class TestController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public TestController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetAllUsers()
        {
            var allUsers = _mapper.Map<List<UserDto>>(await _userService.GetAllAsync());
            //var allUsers = await _userService.GetAllAsync();
            return View(allUsers);
        }
    }
}
