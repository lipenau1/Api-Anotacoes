using System;
using System.Collections.Generic;

namespace AN.Api.DTO.Response
{
    public class TasksResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
        public IEnumerable<CommentResponse> Comments { get; set; }
    }
}