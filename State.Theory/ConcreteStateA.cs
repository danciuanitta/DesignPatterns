

namespace State.Theory
{
    internal class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handled by State A");
            context.SetState(new ConcreteStateB());
        }
    }
}
