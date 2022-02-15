using AN.Api.Model;
using System.Collections.Generic;

namespace AN.Api.AppServices.Interfaces
{
    public interface IUserAppService
    {
        User Adicionar(User user);
        void Atualizar(User user);
        void Remover(int id);
        IEnumerable<User> ObterTodos();
        User ObterPorId(int id);
    }
}
