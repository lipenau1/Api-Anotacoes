using AN.Api.Repositories.Interfaces;
using AN.Api.Model;
using AN.Api.Data;

namespace AN.Api.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
