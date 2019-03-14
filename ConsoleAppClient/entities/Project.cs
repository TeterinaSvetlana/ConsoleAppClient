using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClient
{
    public class Project
    {
        public DbAwareEntity DbAwareEntity { get; set; }
        public Team Team { get; set; }
        public User Owner { get; set; }
        public uint OwnerId { get; set; }
        public User[] Members { get; set; }
        public Task[] Tasks { get; set; }
    }
}
