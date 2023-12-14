
namespace State.Theory
{
    internal class Context
    {
        private IState _state;
        public Context()
        {
            //initial default state
            _state = new ConcreteStateA();
        }

        internal void SetState(IState state)
        {
            _state = state;
        }
        internal void Request()
        {
            _state.Handle(this);
        }
    }
}
