using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using AN.Api.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace AN.Api.Services
{
    public class ContainerService : Service<Container>, IContainerService
    {
        private readonly IContainerRepository _containerRepository;
        public ContainerService(IContainerRepository containerRepository) : base(containerRepository)
        {
            _containerRepository = containerRepository;
        }

        public IEnumerable<Container> GetByBoardId(Guid id)
        {
            return _containerRepository.GetByBoardId(id);
        }
    }
}
