using System.Collections.Generic;

namespace AN.Api.DTO.Response
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<TasksResponse> Tasks { get; set; }
    }
}
