
namespace Factory.Theory
{
    //cine face order de fapt si atunci nu apelezi musai create ci ceva mai complex?
    internal class Client
    {
        //depending on the condition, do this in startup during injection
        //var sandbox = configuration.GetValue<bool>("Sandbox");
        //if (sandbox)
        //services.AddTransient<IRelayService, SandboxRelayService>();
        //else
        //services.AddTransient<IRelayService, LiveRelayService>();
        public void SomeMethod(string conditionalValue)
        {
            ICreator? creator = null;
            if (conditionalValue.Equals("value1"))
                creator = new ProductCreator1();
            else
                creator = new ProductCreator2();

            var product = creator.Create();
        }
    }
}
