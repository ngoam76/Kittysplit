using Kittysplit.DatabaseAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittysplit.ConsoleApplication
{
    internal class Update // to update attribute values of entities
    {
        private readonly KittySplitContext _context;
        public Update(KittySplitContext context)
        {
            _context = context;
        }
        // Update event name
        public void UpdateEventName(int eventId, string newEventName)
        {
            var eventToUpdate = _context.Events
                .Where(e => e.EventId == eventId)
                .FirstOrDefault();
            if (eventToUpdate != null)
            {
                eventToUpdate.EventName = newEventName;
            }
            _context.SaveChanges();
        } 
        // Update event currency
        public void UpdateEventCurrency(int eventId, string newCurrency)
        {
            var eventToUpdate = _context.Events
                .Where(e => e.EventId == eventId)
                .FirstOrDefault();
            if (eventToUpdate != null)
            {
                eventToUpdate.Currency = newCurrency;
            }
            _context.SaveChanges();
        }
        // Update participant name
        public void UpdateParticipantName(int parId, string newName)
        {
            var participantToUpdate = _context.Participants
                .Where(p => p.ParticipantId == parId)
                .FirstOrDefault();
            if (participantToUpdate != null)
            {
                participantToUpdate.Name = newName;
            }
            _context.SaveChanges();
        }
        // Update expense description
        public void UpdateExpenseDescription(int expenseId, string newDescription)
        {
            var expenseToUpdate = _context.Expenses
                .Where(e => e.ExpenseId == expenseId)
                .FirstOrDefault();
            if (expenseToUpdate != null)
            {
                expenseToUpdate.ExpenseDescription = newDescription;
            }
            _context.SaveChanges();
        }
        // Update expense amount
        public void UpdateExpenseAmount(int expenseId, decimal newAmount)
        {
            var expenseToUpdate = _context.Expenses
                .Where(e => e.ExpenseId == expenseId)
                .FirstOrDefault();
            if (expenseToUpdate != null)
            {
                expenseToUpdate.ExpenseAmount = newAmount;
            }
            _context.SaveChanges();
        }
    }
}
