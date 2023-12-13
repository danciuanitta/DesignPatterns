
namespace Proxy.Theory
{
    //Proxy implementing the interface
    class Proxy : ISubject
    {
        private RealSubject _realSubject;
        public void DoOperation()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            Console.WriteLine("Proxy operation before Real Subject's operation.");
            _realSubject.DoOperation();
        }
    }
}
