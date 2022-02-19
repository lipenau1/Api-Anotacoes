using System.Collections.Generic;

namespace AN.Api.Model
{
    public class User
    {
        public User() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<Tasks> Tasks { get; set; }
    }
}
