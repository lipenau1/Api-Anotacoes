using AN.Api.AppServices.Interfaces;
using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using AN.Api.Model;
using AN.Api.Services.Interfaces;
using AN.Api.UoW.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AN.Api.AppServices
{
    public class ContainerAppService : IContainerAppService
    {
        private readonly IContainerService _containerService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContainerAppService(IContainerService containerService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _containerService = containerService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ContainerAddRequest Add(ContainerAddRequest containerAddRequest)
        {
            _containerService.Add(_mapper.Map<Container>(containerAddRequest));
            _unitOfWork.Commit();
            return containerAddRequest;
        }

        public IEnumerable<ContainerResponse> GetAll()
        {
            return _mapper.Map<IEnumerable<ContainerResponse>>(_containerService.GetAll());
        }

        public ContainerResponse GetById(Guid id)
        {
            return _mapper.Map<ContainerResponse>(_containerService.GetById(id));
        }

        public void Remove(Guid id)
        {
            _containerService.Remove(id);
            _unitOfWork.Commit();
        }

        public ContainerUpdateRequest Update(ContainerUpdateRequest containerUpdateRequest)
        {
            _containerService.Update(_mapper.Map<Container>(containerUpdateRequest));
            _unitOfWork.Commit();
            return containerUpdateRequest;
        }
    }
}
