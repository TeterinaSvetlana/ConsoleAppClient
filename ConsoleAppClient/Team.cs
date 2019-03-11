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
        public string Name { get; set; }
        public User Owner { get; set; }
        public User[] Members { get; set; }
        public Project[] Projects { get; set; }
    }
}
