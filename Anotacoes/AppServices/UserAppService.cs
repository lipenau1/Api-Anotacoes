using AN.Api.AppServices.Interfaces;
using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using AN.Api.Model;
using AN.Api.Services;
using AN.Api.UoW.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace AN.Api.AppServices
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _usuarioService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserAppService(IUserService userService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _usuarioService = userService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public UserAddRequest Add(UserAddRequest user)
        {
            _usuarioService.Add(_mapper.Map<User>(user));
            _unitOfWork.Commit();
            return user;
        }

        public void Update(UserUpdateRequest user)
        {
            _usuarioService.Update(_mapper.Map<User>(user));
            _unitOfWork.Commit();
        }

        public UserResponse GetById(int id)
        {
            return _mapper.Map<UserResponse>(_usuarioService.GetById(id));
        }

        public IEnumerable<UserResponse> GetAll()
        {
            return _mapper.Map<IEnumerable<UserResponse>>(_usuarioService.GetAll());
        }

        public void Remove(int id)
        {
            _usuarioService.Remove(id);
            _unitOfWork.Commit();
        }

        public bool Login(string email, string password)
        {
            return _usuarioService.Login(email, password);
        }
    }
}
