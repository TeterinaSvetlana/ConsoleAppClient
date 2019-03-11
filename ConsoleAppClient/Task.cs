using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClient
{
    public class Task
    {
        public DbAwareEntity DbAwareEntity { get; set; }
        public string Name { get; set; }
        public string Objective { get; set; }
        public string Description { get; set; }
        public Task ParentTask { get; set; }
        public User Initiator { get; set; }
        public User[] Assignees { get; set; }
        public DateTime Deadline { get; set; }
        public string Severity { get; set; }
        public Status Status { get; set; }
    }
}
