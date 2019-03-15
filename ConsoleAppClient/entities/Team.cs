using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClient
{
    public class Team
    {
        public DbAwareEntity DbAwareEntity { get; set; }
        public User Owner { get; set; }
        public uint OwnerId { get; set; }
        public User[] Users { get; set; }
        public uint ProjectId { get; set; }
    }
}
