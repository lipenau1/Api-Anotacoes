using System;
using System.Collections.Generic;

namespace AN.Api.Model
{
    public class Board
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Container> Containers { get; set; }
    }
}
