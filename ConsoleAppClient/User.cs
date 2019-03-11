using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClient
{
    public class User
    {
        public DbAwareEntity DbAwareEntity { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public Team Team { get; set; }
    }
}
