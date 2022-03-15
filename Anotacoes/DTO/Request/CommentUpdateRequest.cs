using System;

namespace AN.Api.DTO.Request
{
    public class CommentUpdateRequest
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid TaskId { get; set; }
        public int UserId { get; set; }
    }
}
