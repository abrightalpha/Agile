using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agile.Common;

namespace Agile.BL
{
    public class Task
    {
        //Constructors
        public Task(string name, User owner, double estimatedHours, UserStory userStory, Sprint sprint)
        {
            if (name.ValidName()) this.Name = name;
            this.Owner = owner;
            this.EstimatedHours = estimatedHours;
            this.AssociatedUserStory = userStory;
            this.AssociatedSprint = sprint;

            this.ToDoHours = estimatedHours;
            this.SpentHours = 0;
        }

        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Blocked { get; set; }
        public User Owner { get; set; }
        public double EstimatedHours { get; set; }
        public double SpentHours { get; set; }
        public double ToDoHours { get; set; }
        public UserStory AssociatedUserStory { get; set; }
        public Sprint AssociatedSprint { get; set; }
    }
}
