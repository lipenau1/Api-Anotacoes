using System;

namespace AN.Api.DTO.Response
{
    public class CommentResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid TaskId { get; set; }
        public int UserId { get; set; }
    }
}
