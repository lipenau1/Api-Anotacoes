using System;
using System.Collections.Generic;

namespace AN.Api.DTO.Request
{
    public class LanesRequest
    {
        public int CurrentPage { get; set; }
        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Title { get; set; }
        public int Position { get; set; }
        public IEnumerable<CardRequest> Cards { get; set; }
    }
}
