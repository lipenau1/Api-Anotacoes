using AN.Api.Utils;
using System;
using System.Collections.Generic;

namespace AN.Api.Model
{
    public class Tasks
    {
        public Tasks(string description, DateTime date, int userId)
        {
            Id = Guid.NewGuid();
            Description = description;
            Date = date;    
            UserId = userId;  
        }
        public Tasks() { }
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public IEnumerable<Attachment> Attachments { get; set; }
    }
}
