using AN.Api.Repositories.Interfaces;
using AN.Api.Model;
using AN.Api.Utils;
using AN.Api.DTO.Request;

namespace AN.Api.Services
{
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public override User Add(User obj)
        {
            obj.Password = PasswordHash.PasswordHasher(obj.Password);
            return _userRepository.Add(obj);
        }

        public bool Login(LoginRequest login)
        {
            var hashedPassword = _userRepository.GetHashedPassword(login.Login);
            if(hashedPassword == null)
                return false;
            return PasswordHash.PasswordVerifier(login.Password, hashedPassword);
        }
    }
}
