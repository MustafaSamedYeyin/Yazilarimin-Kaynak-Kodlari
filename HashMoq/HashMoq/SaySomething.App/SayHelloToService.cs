using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaySomething.App
{
    public class SayHelloToService : ISayHelloToService
    {
        public string SayHelloTo(string name)
        {
            return "Hello " + name;
        }
    }
}
