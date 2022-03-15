using System;

namespace AN.Api.DTO.Request
{
    public class BoardUpdateRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
    }
}
