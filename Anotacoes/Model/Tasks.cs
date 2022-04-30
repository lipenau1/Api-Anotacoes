using AN.Api.Utils;
using System;
using System.Collections.Generic;

namespace AN.Api.Model
{
    public class Tasks
    {
        public Tasks(string description, string title, int userId, Guid containerId)
        {
            Id = Guid.NewGuid();
            Description = description;
            Title = title;
            DateCreated = DateTime.Now;
            DateProgress = DateCreated;
            UserId = userId;
            ContainerId = containerId;
            Attachments = new List<Attachment>();
            Comments = new List<Comment>();
        }
        public Tasks() { }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Label { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateProgress { get; set; }
        public int Status { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Guid ContainerId { get; set; }
        public Container Container { get; set; }
        public virtual IEnumerable<Attachment> Attachments { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
    }
}
