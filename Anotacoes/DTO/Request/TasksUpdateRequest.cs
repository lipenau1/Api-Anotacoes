using System;

namespace AN.Api.DTO.Request
{
    public class TasksUpdateRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public Guid ContainerId { get; set; }
    }
}
