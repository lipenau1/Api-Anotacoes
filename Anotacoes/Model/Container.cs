using System;
using System.Collections.Generic;

namespace AN.Api.Model
{
    public class Container
    {
        public Container(Guid id)
        {
            Id = id;
            DateCreated = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid BoardId { get; set; }
        public Board Board { get; set; }
        public virtual IEnumerable<Tasks> Tasks { get; set; }
        public int Position { get; set; }
    }
}
