using AN.Api.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AN.Api.Model
{
    public class Board
    {
        public Board()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Container> Containers { get; set; }

        public void Update(Board newBoard)
        {
            var containerAdd = newBoard.Containers.Where(x => !Containers.Any(t => t.Id == x.Id)).ToList();
            var containerUpdate = Containers.Where(x => newBoard.Containers.Any(t => t.Id == x.Id)).ToList();
            var containerDelete = Containers.Where(x => !newBoard.Containers.Any(t => t.Id == x.Id)).ToList();

            foreach (var container in containerDelete)
            {
                Containers.Remove(container);
            }

            foreach (var container in containerUpdate)
            {
                var containerEdit = newBoard.Containers.FirstOrDefault(x => x.Id == container.Id);
                container.Update(containerEdit);
            }
            foreach (var container in containerAdd)
            {
                container.Id = Guid.NewGuid();
                container.BoardId = newBoard.Id;
                Containers.Add(container);
            }
              
        }
    }
}
