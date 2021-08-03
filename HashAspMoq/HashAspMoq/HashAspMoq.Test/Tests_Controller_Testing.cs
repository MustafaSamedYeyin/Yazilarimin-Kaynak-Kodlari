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
    
    public class Tests_Controller_Testing
    {
        private readonly TestsController _testsController;
        private readonly Mock<IUserService> _mock;
        private readonly IMapper _map;
        private readonly List<User> _user;
        public Tests_Controller_Testing()
        {
            _mock = new Mock<IUserService>();
            _map = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapping())));
            _testsController = new TestsController(new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapping()))), _mock.Object);
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
        public async Task Index_GetAllUsers()
        {
            _mock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(_user);

            var result = await _testsController.Index();


            var okResult = Assert.IsType<OkObjectResult>(result);

            var userList = Assert.IsAssignableFrom<List<UserDto>>(okResult.Value);

            Assert.Single(userList);

        }
    }
}
