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

        public User Adicionar(User user)
        {
            var userAdd = _usuarioService.Adicionar(user);
            _unitOfWork.Commit();
            return userAdd;
        }

        public void Atualizar(User user)
        {
            _usuarioService.Atualizar(user);
            _unitOfWork.Commit();
        }

        public User ObterPorId(int id)
        {
            return _usuarioService.ObterPorId(id);
        }

        public IEnumerable<User> ObterTodos()
        {
            return _usuarioService.ObterTodos();
        }

        public void Remover(int id)
        {
            _usuarioService.Remover(id);
            _unitOfWork.Commit();
        }
    }
}
