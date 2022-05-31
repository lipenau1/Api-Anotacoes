using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using System;
using System.Collections.Generic;

namespace AN.Api.AppServices.Interfaces
{
    public interface IContainerAppService
    {
        ContainerAddRequest Add(ContainerAddRequest containerAddRequest);
        ContainerUpdateRequest Update(ContainerUpdateRequest containerUpdateRequest);
        void Remove(Guid id);
        void ChangeIndexBoard(Guid boardId, int removedIndex, int updatedIndex);
        IEnumerable<ContainerResponse> GetByBoardId(Guid id);
        IEnumerable<ContainerResponse> GetAll();
        ContainerResponse GetById(Guid id);
    }
}
