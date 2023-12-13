
namespace Proxy.Theory
{
    //Client class that requests the service
    class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.DoOperation();
        }
    }
}
