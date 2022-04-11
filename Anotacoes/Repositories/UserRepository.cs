using AN.Api.Repositories.Interfaces;
using AN.Api.Model;
using AN.Api.Data;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AN.Api.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(ApplicationContext context) : base(context)
        {
        }

        public override IEnumerable<User> GetAll()
        {
            return DbSet
                    .Include(x => x.Tasks)
                    .Include(x => x.Comments);
        }

        public string GetHashedPassword(string login)
        {
            var user = DbSet.FirstOrDefault(x => x.Email == login || x.Name == login);
            if(user == null)
                return null;
            return user.Password;
        }
    }
}
