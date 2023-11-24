using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Theory
{
    public interface IPrototype
    {
        IProduct Clone();
    }
}
