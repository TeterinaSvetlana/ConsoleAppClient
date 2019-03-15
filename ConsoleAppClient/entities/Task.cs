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
        public string Objective { get; set; }
        public string Description { get; set; }        
        public User Initiator { get; set; }
        public uint InitiatorId { get; set; }
        public User[] Assignees { get; set; }
        public DateTime Deadline { get; set; }
        public string Severity { get; set; }
        public Status Status { get; set; }
        public uint StatusId { get; set; }
        public Project Project { get; set; }
        public uint ProjectId { get; set; }
        public uint TaskId { get; set; }
    }
}
