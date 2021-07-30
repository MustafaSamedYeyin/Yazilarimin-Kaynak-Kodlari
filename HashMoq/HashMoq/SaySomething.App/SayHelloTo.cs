using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaySomething.App
{
    public class SayHelloTo
    {
        private readonly ISayHelloToService _sayHelloToService;
        public SayHelloTo(ISayHelloToService sayHelloToService)
        {
            _sayHelloToService = sayHelloToService;

        }
        public string SayHello(string name)
        {
            return _sayHelloToService.SayHelloTo(name);
        }
    }
}
