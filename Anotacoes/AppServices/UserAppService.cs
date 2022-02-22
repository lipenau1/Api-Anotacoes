using AN.Api.AppServices.Interfaces;
using AN.Api.Model;
using AN.Api.Services;
using AN.Api.UoW.Interfaces;
using System.Collections.Generic;

namespace AN.Api.AppServices
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _usuarioService;
        private readonly IUnitOfWork _unitOfWork;

        public UserAppService(IUserService userService, IUnitOfWork unitOfWork)
        {
            _usuarioService = userService;
            _unitOfWork = unitOfWork;
        }

        public User Add(User user)
        {
            var userAdd = _usuarioService.Add(user);
            _unitOfWork.Commit();
            return userAdd;
        }

        public void Update(User user)
        {
            _usuarioService.Update(user);
            _unitOfWork.Commit();
        }

        public User GetById(int id)
        {
            return _usuarioService.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _usuarioService.GetAll();
        }

        public void Remove(int id)
        {
            _usuarioService.Remove(id);
            _unitOfWork.Commit();
        }
    }
}
