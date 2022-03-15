using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using AN.Api.Model;
using System.Collections.Generic;

namespace AN.Api.AppServices.Interfaces
{
    public interface IUserAppService
    {
        UserAddRequest Add(UserAddRequest user);
        void Update(UserUpdateRequest user);
        void Remove(int id);
        IEnumerable<UserResponse> GetAll();
        UserResponse GetById(int id);
        bool Login(string email, string password);
    }
}
