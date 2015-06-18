using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agile.Common;

namespace Agile.BL
{
    public class UserStory
    {
        //Constructors
        public UserStory(string name, int points, double estimatedHours, Sprint sprint, User associateUser):
            this(name, "", points, estimatedHours, sprint, associateUser)
        {
            
        }


        public UserStory(string name, string description, int points, double estimatedHours, Sprint sprint, User associateUser)
        {
            if (name.ValidName()) this.Name = name;
            if (string.IsNullOrWhiteSpace(description)) this.Description = "";
            this.Points = points;
            this.EstimatedHours = estimatedHours;
            this.AssociatedSprint = sprint;
            this.AssociatedUser = associateUser;
            this.DateCreated = DateTimeOffset.Now;
            this.DateLastChanged = this.DateCreated;
        }
        //Properties
        public User AssociatedUser { get; set; }
        public double EstimatedHours { get; set; }
        public int Points { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateLastChanged { get; set; }
        public Sprint AssociatedSprint { get; set; }
        public List<Task> AssociatedTasks { get; set; }
        public int Id { get; set; }

        //Methods

        //Should be moved to repository later
        public void Add(Task task)
        {
            this.AssociatedTasks.Add(task);
        }

    }
}
