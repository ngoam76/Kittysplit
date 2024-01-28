using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Kittysplit.Logic
{
    public class Participant // entity
    {
        public int ParticipantId {  get; set; }
        public string? Name { get; set; } // nullable string
        [JsonIgnore]
        public ICollection<Event>? Events { get; set; } // many-to-many relationship with Participant
        public ICollection<Expense>? Expenses { get; set; } 
    }
}
