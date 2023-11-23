
namespace Factory.Practice.IAmTimCorey
{
    internal class Client
    {
        private readonly ISample factory;
        public Client(IAbstractFactory<ISample> factory)
        {
            this.factory = factory.Create();
        }
    }
}
