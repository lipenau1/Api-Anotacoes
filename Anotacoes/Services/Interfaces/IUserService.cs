using AN.Api.DTO.Request;
using AN.Api.Model;

namespace AN.Api.Services
{
    public interface IUserService : IService<User>
    {
        bool Login(LoginRequest login);
    }
}
