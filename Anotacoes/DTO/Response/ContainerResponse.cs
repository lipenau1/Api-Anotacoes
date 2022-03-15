using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.DTO.Response
{
    public class ContainerResponse
    {
        public ContainerResponse()
        {
            Tasks = new List<TasksResponse>();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid BoardId { get; set; }
        public IEnumerable<TasksResponse> Tasks { get; set; }
    }
}
