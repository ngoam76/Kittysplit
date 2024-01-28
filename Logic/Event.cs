using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittysplit.Logic
{
    public class Event
    {
        public int EventId { get; set; }
        public string? EventName { get; set; }
        public string? EventDescription { get; set; }
        public string? EventLocation { get; set; }
        public string? Currency {  get; set; }
        public ICollection<Participant>? Participants { get; set; }
        public ICollection<Expense>? Expenses { get; set; }
    }
}
