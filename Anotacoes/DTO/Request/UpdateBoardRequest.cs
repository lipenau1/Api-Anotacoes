using System;
using System.Collections.Generic;

namespace AN.Api.DTO.Request
{
    public class UpdateBoardRequest
    {
        public Guid Id { get; set; }
        public IEnumerable<LanesRequest> Lanes { get; set; }
    }
}
