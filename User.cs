using System;
using System.Collections.Generic;

namespace SqlServerSample {

    public class Task {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }
        public virtual User AssignedTo { get; set; }

        public override string ToString () {
            return "Task [id=" + this.TaskId + ", title=" + this.Title + ", dueDate=" + this.DueDate.ToString () + ", IsComplete=" + this.IsComplete + "]";
        }
    }
    public class User {
        public int UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public virtual IList<Task> Tasks { get; set; }

        public String GetFullName () {
            return this.FirstName + " " + this.LastName;
        }
        public override string ToString () {
            return "User [id=" + this.UserId + ", name=" + this.GetFullName () + "]";
        }
    }
}