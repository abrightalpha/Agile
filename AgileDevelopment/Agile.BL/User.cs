using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.BL
{
    public class User
    {
        public User(string firstName, string lastName)
        {
            this.FirstName = firstName.Trim();
            this.LastName = lastName.Trim();
            this.FullName = firstName + " " + LastName;
        }

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            private set { _fullName = value; }
        }

        public List<Task> AssociatedTasks { get; set; }
        public List<UserStory> AssociatedUserStories { get; set; } 
    }
}
