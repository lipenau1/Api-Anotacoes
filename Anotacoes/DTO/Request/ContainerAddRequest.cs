using System;

namespace AN.Api.DTO.Request
{
    public class ContainerAddRequest
    {
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid BoardId { get; set; }
    }
}
