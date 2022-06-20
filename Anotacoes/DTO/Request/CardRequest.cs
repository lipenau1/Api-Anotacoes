using System;

namespace AN.Api.DTO.Request
{
    public class CardRequest
    {
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string Label { get; set; }
        public Guid LaneId { get; set; }
        public int Position { get; set; }
        public string Title { get; set; }
    }
}
