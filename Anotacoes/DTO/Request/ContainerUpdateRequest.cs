using System;

namespace AN.Api.DTO.Request
{
    public class ContainerUpdateRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Label { get; set; }
        public Guid BoardId { get; set; }
    }
}
