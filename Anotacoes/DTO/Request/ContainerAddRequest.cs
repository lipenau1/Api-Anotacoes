using System;

namespace AN.Api.DTO.Request
{
    public class ContainerAddRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid BoardId { get; set; }
        public int Position { get; set; }
    }
}
