using Moq;
using SaySomething.App;
using System;
using Xunit;

namespace SaySomething.Test
{
    public class SaySomethingTest
    {



        /*Kullanýmmý anlayabilmeniz için : 
         * Ýlk baþta Normal kullaným olan yerleri comment'ten çýkartýn
         * Assert metodunu da comment den çýkartýn.
         * testi çalýþtýrýn
         * ve class ile interface'lerin davranýþýný inceleyin.
         * 
         * 
         * Davranýþý anladýktan sonra uncomment yaptýðýnýz yerleri comment'leyip.
         * 
         * 
         * Mock ile kullanýmý adlý yerleri comment'ten çýkartýn.
         * Assert metodunu da comment çýkartýn.
         * testi çalýþtýrýn
         * ve class ile interface'lerin davranýþýný inceleyin.
         * 
         */
        private readonly SayHelloTo _sayHelloTo;
        public Mock<ISayHelloToService> mymock { get; set; }
        public SaySomethingTest()
        {

            //  Normal kullaným :
            _sayHelloTo = new SayHelloTo(new SayHelloToService());


            /* Mock ile kullanýmý: 
            * mymock = new Mock<ISayHelloToService>();
            * _sayHelloTo = new SayHelloTo(mymock.Object);
            */

        }

        [Theory]
        [InlineData("Mustafa", "Hello Mustafa")]
        [InlineData("Mehmet", "Hello Mehmet")]
        [InlineData("Ömer", "Hello Ömer")]
        public void SayHelloToMustafa(string name, string expectedValue)
        {

            //Normal kullaným:
            var value = _sayHelloTo.SayHello(name);


            /*Mock ile kullaným : 
            *mymock.Setup(x => x.SayHelloTo(name)).Returns("Hello " + name);
            *var value = _sayHelloTo.SayHello(name);
            */


            Assert.Equal(expectedValue, value);

        }
    }
}
