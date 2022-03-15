using AN.Api.Model;

namespace AN.Api.Services
{
    public interface IUserService : IService<User>
    {
        bool Login(string email, string password);
    }
}
