
namespace State.Theory
{
    internal class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handled by State B");
        }
    }
}
