using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.DTO.Response
{
    public class ContainerResponse
    {
        public ContainerResponse()
        {
            Cards = new List<TasksResponse>();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Label { get; set; }
        public IEnumerable<TasksResponse> Cards { get; set; }
    }
}
