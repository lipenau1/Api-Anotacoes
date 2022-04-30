using System;

namespace AN.Api.DTO.Request
{
    public class ContainerAddRequest
    {
        public string Title { get; set; }
        public string Label { get; set; }
        public Guid BoardId { get; set; }
    }
}
