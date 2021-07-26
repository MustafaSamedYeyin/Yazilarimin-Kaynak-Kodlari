using HashTest.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HashTest.Test
{
    public class SaySomeThingTest
    {
        [Fact]
        public void SayHelloTest()
        {
            //Arrange 
            string name = "Mustafa";
            SaySomeThing saySomeThing = new SaySomeThing();

            //Act
            var Value = saySomeThing.SayHello(name);
            //Assert

            Assert.Equal("Hello Mustafa", Value);

        }
    }
}
