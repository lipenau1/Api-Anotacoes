using System;

namespace AN.Api.DTO.Request
{
    public class CommentAddRequest
    {
        public string Description { get; set; }
        public Guid TaskId { get; set; }
        public int UserId { get; set; }
    }
}
