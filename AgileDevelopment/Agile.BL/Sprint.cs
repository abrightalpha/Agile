using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agile.Common;

namespace Agile.BL
{
    public class Sprint
    {
        public Sprint(string name) :
            this(name, new TimeSpan(14, 0, 0, 0))
        {
            
        }
        //Constructors
        public Sprint(string name, TimeSpan offset)
        {
            if (Name.ValidName()) this.Name = name;
            this.DateCreated = DateTimeOffset.Now;
            this.DateDue = DateCreated.Add(offset);
        }
        //Properties
        public string Name { get; set; }
        public List<UserStory> AssociatedUserStories { get; set; }
        public List<Task> AssociatedTasks { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateDue { get; set; }
        public double TotalHours { get; set; }
        public int TotalPoints { get; set; }
    }
}
