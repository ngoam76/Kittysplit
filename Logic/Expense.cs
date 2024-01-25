using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittysplit.Logic
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string? ExpenseDescription { get; set; }
        public decimal ExpenseAmount { get; set; }
        public DateTime DateSpent { get; set; }
    }
}
