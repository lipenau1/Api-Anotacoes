using AN.Api.Repositories.Interfaces;
using AN.Api.Model;
using AN.Api.Data;
using System.Linq;

namespace AN.Api.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(ApplicationContext context) : base(context)
        {
        }

        public bool Login(string email, string password)
        {
            var user = DbSet.Where(x => x.Email == email && x.Password == password);
            if(user.Count() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
