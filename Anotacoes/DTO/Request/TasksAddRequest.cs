using System;

namespace AN.Api.DTO.Request
{
    public class TasksAddRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Label { get; set; }
        public int Position { get; set; }
        public Guid ContainerId { get; set; }
    }
}
