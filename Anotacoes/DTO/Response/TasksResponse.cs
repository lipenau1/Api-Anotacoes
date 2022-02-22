using System;

namespace AN.Api.DTO.Response
{
    public class TasksResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}