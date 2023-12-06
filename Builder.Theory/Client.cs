using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Theory
{
    internal class Client
    {
        public void SomeOperation()
        {
            IBuilder builder = new Builder();
            var director = new Director(builder);

            var result = director.Construct();
        }
    }
}
