using AN.Api.Model;
using System.Collections.Generic;

namespace AN.Api.AppServices.Interfaces
{
    public interface IUserAppService
    {
        User Add(User user);
        void Update(User user);
        void Remove(int id);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
