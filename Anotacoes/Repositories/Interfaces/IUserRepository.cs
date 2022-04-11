using AN.Api.Model;

namespace AN.Api.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        string GetHashedPassword(string email);
    }
}
