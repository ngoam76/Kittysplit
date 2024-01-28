using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Kittysplit.Logic
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string? ExpenseDescription { get; set; }
        public decimal ExpenseAmount { get; set; }
        public DateTime DateSpent { get; set; }
        [JsonIgnore]
        public ICollection<Participant>? Participants { get; set; } // many-to-many with Expense
    }
}
