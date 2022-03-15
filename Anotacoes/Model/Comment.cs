using System;

namespace AN.Api.Model
{
    public class Comment
    {
        public Comment(string description, Guid taskId, int userId) 
        { 
            Id = Guid.NewGuid();
            Description = description;
            UserId = userId;
            TaskId = taskId;
        }

        public Comment() { }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid TaskId { get; set; }
        public Tasks Task { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
