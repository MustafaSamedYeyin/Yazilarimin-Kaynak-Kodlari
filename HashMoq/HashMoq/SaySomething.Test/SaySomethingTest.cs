using Moq;
using SaySomething.App;
using System;
using Xunit;

namespace SaySomething.Test
{
    public class SaySomethingTest
    {



        /*Kullan�mm� anlayabilmeniz i�in : 
         * �lk ba�ta Normal kullan�m olan yerleri comment'ten ��kart�n
         * Assert metodunu da comment den ��kart�n.
         * testi �al��t�r�n
         * ve class ile interface'lerin davran���n� inceleyin.
         * 
         * 
         * Davran��� anlad�ktan sonra uncomment yapt���n�z yerleri comment'leyip.
         * 
         * 
         * Mock ile kullan�m� adl� yerleri comment'ten ��kart�n.
         * Assert metodunu da comment ��kart�n.
         * testi �al��t�r�n
         * ve class ile interface'lerin davran���n� inceleyin.
         * 
         */
        private readonly SayHelloTo _sayHelloTo;
        public Mock<ISayHelloToService> mymock { get; set; }
        public SaySomethingTest()
        {

            //  Normal kullan�m :
            _sayHelloTo = new SayHelloTo(new SayHelloToService());


            /* Mock ile kullan�m�: 
            * mymock = new Mock<ISayHelloToService>();
            * _sayHelloTo = new SayHelloTo(mymock.Object);
            */

        }

        [Theory]
        [InlineData("Mustafa", "Hello Mustafa")]
        [InlineData("Mehmet", "Hello Mehmet")]
        [InlineData("�mer", "Hello �mer")]
        public void SayHelloToMustafa(string name, string expectedValue)
        {

            //Normal kullan�m:
            var value = _sayHelloTo.SayHello(name);


            /*Mock ile kullan�m : 
            *mymock.Setup(x => x.SayHelloTo(name)).Returns("Hello " + name);
            *var value = _sayHelloTo.SayHello(name);
            */


            Assert.Equal(expectedValue, value);

        }
    }
}
