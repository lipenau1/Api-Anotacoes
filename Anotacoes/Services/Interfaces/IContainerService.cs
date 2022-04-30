using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.Services.Interfaces
{
    public interface IContainerService : IService<Container>
    {
        IEnumerable<Container> GetByBoardId(Guid id);
    }
}
