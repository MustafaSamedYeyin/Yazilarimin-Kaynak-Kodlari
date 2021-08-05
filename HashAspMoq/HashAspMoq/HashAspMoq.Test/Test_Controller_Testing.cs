using AutoMapper;
using HashAspMoq.Core.Entties;
using HashAspMoq.Core.Interfaces.Services;
using HashAspMoq.Dtos.Dtos;
using HashAspMoq.Web.AutoMapper;
using HashAspMoq.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HashAspMoq.Test
{
    public class Test_Controller_Testing
    {
        private readonly TestController _testController;
        private readonly Mock<IUserService> _mock;
        private readonly IMapper _map;
        private readonly List<User> _user;
        public Test_Controller_Testing()
        {
            _mock = new Mock<IUserService>();
            _map = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapping())));
            _testController = new TestController(_map, _mock.Object);
            _user = new List<User>()
            {
                new User() {
                Age = 24,
                Country = "Turkey",
                Name = "MustafaSy"
                }
            };
        }
        [Fact]
        public async Task GetAllUsers_Test()
        {
            _mock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(_user);
           
            var result = await _testController.GetAllUsers();


            var viewResult = Assert.IsType<ViewResult>(result);

            var userList = Assert.IsAssignableFrom<List<UserDto>>(viewResult.Model);

            Assert.Single(userList);
        }
    }
}
