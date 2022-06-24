using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AN.Api.Model
{
    public class Container
    {
        public Container(Guid id)
        {
            Id = id;
            DateCreated = DateTime.Now;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid BoardId { get; set; }
        public Board Board { get; set; }
        public virtual List<Tasks> Tasks { get; set; }
        public int Position { get; set; }

        public void Update(Container newContainer)
        {
            Title = newContainer.Title ?? "";
            Position = newContainer.Position;

            if (newContainer.Tasks == null) return;

            var taskAdd = newContainer.Tasks.Where(x => !Tasks.Any(y => y.Id == x.Id)).ToList();
            var taskUpdate = Tasks.Where(x => newContainer.Tasks.Any(y => y.Id == x.Id)).ToList();
            var taskDelete = Tasks.Where(x => !newContainer.Tasks.Any(y => y.Id == x.Id)).ToList();

            foreach (var task in taskDelete)
            {
                Tasks.Remove(task);
            }

            foreach (var task in taskUpdate)
            {
                var taskEdit = newContainer.Tasks.FirstOrDefault(x => x.Id == task.Id);

                if (taskEdit == null) continue;

                task.Update(taskEdit);
            }

            foreach (var task in taskAdd)
            {
                task.Id = Guid.NewGuid();
                task.Title ??= "";
                task.Description ??= "";
                task.Label ??= "";
                task.ContainerId = newContainer.Id;
                task.Container = newContainer;
            }
            Tasks.AddRange(taskAdd);
        }
    }
}
