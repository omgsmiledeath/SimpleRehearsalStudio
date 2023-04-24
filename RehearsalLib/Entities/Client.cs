using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RehearsalLib.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Entry> Entries { get; set; }
        
    }
}