using System;

namespace AN.Api.DTO.Request
{
    public class TasksUpdateRequest
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
