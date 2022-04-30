using System;
using System.Collections.Generic;

namespace AN.Api.Model
{
    public class Container
    {
        public Container()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Label { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid BoardId { get; set; }
        public Board Board { get; set; }
        public IEnumerable<Tasks> Tasks { get; set; }
    }
}
