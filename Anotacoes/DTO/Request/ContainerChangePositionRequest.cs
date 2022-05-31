using System;

namespace AN.Api.DTO.Request
{
    public class ContainerChangePositionRequest
    {
        public Guid BoardId { get; set; }
        public int RemovedIndex { get; set; }
        public int UpdatedIndex { get; set; }
    }
}
