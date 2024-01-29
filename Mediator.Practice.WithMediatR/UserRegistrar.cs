namespace Mediator.Practice.WithMediatR
{
    public sealed class UserRegistrar
    {
        private readonly List<IUser> users;
        public IReadOnlyList<IUser> ChatUsers => users;

        public UserRegistrar()
        {
            users = new List<IUser>();
        }

        public void RegisterUser(IUser user)
        {
            users.Add(user);
        }
    }
}
