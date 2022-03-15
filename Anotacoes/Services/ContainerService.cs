using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using AN.Api.Services.Interfaces;

namespace AN.Api.Services
{
    public class ContainerService : Service<Container>, IContainerService
    {
        public ContainerService(IContainerRepository containerRepository) : base(containerRepository)
        {
        }
    }
}
