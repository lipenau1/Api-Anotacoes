

using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.Repositories.Interfaces
{
    public interface IContainerRepository : IRepository<Container>
    {
        IEnumerable<Container> GetByBoardId(Guid id);
        Container GetByPosition(int position, Guid containerId);
    }
}
