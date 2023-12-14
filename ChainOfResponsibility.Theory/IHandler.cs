
namespace ChainOfResponsibility.Theory
{
    public interface IHandler
    {
        void SetTheNextHandler(IHandler handler);
        void Process(string request);
    }
}
