using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittysplit.Logic
{
    public class Participant // entity
    {
        public int ParticipantId {  get; set; }
        public string? Name { get; set; } // nullable string
        public Event? Event { get; set; }
        public ICollection<Expense>? Expenses { get; set; } // many-to-many relationship with Participant
    }
}
