using System;
using System.Collections.Generic;

namespace AN.Api.DTO.Response
{
    public class TasksResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Label { get; set; }
    }
}