
using System.Diagnostics;

namespace Composite.Theory
{
    internal class Client
    {
        //We could say that the Composite Pattern takes the Single Responsibility design principle and trades it for transparency.
        public void Operation()
        {
            IComponent composite = new Composite();
            IComponent leaf = new Leaf();
            composite.Add(leaf);
            IComponent secondLeaf= new Leaf();
            composite.Add(secondLeaf);

            composite.Operation();

            leaf.Operation();
        }
    }
}
