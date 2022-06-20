using System;
using System.Collections.Generic;
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
            var taskUpdate = newContainer.Tasks.Where(x => Tasks.Any(y => y.Id == x.Id)).ToList();
            var taskDelete = Tasks.Where(x => !newContainer.Tasks.Any(y => y.Id == x.Id)).ToList();

            foreach (var task in taskDelete)
            {
                Tasks.Remove(task);
            }

            foreach (var task in taskUpdate)
            {
                var taskEdit = Tasks.FirstOrDefault(x => x.Id == task.Id);

                if (taskEdit == null) continue;

                taskEdit.Update(task);
            }

            foreach (var task in taskAdd)
            {
                task.Title ??= "";
                task.Description ??= "";
                task.Label ??= "";
            }
            Tasks.AddRange(taskAdd);
        }
    }
}
