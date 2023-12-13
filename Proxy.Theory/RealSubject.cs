
namespace Proxy.Theory
{
    //RealSubject implementing the interface
    class RealSubject : ISubject
    {
        public void DoOperation()
        {
            Console.WriteLine("Operation done by Real Subject!");
        }
    }
}
