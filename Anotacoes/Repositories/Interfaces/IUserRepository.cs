using AN.Api.Model;

namespace AN.Api.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        bool Login(string email, string password);
    }
}
