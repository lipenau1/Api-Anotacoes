using AN.Api.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AN.Api.Model
{
    public class Tasks
    {
        public Tasks(Guid id, string description, string title, Guid containerId)
        {
            Id = id;
            Description = description;
            Title = title;
            DateCreated = DateTime.Now;
            DateProgress = DateCreated;
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
        public Guid? ContainerId { get; set; }
        public Container Container { get; set; }
        public virtual IEnumerable<Attachment> Attachments { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
        public int Position { get; set; }

        public void Update(Tasks newTask)
        {
            //ContainerId = newTask.ContainerId.Value;
            Title = newTask.Title ?? "";
            Description = newTask.Description ?? "";
            Label = newTask.Label ?? "";
            Position = newTask.Position;
        }
    }
}
