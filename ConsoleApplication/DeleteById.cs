using Kittysplit.DatabaseAbstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittysplit.ConsoleApplication
{
    public class DeleteById // to delete existing objects
    {
        private readonly KittySplitContext _context;
        public DeleteById(KittySplitContext context)
        {
            _context = context;
        }

        // delete event
        public void DeleteEventById(int id)
        {
            var toBeDeletedEvent = _context.Events.Find(id);
            if (toBeDeletedEvent != null)
            {
                _context.Events.Remove(toBeDeletedEvent);
                _context.SaveChanges();
            }

        }

        // delete participant
        public void DeleteParticipantById(int id)
        {
            var toBeDeletedParticipant = _context.Participants.Find(id);
            if (toBeDeletedParticipant != null)
            {
                _context.Participants.Remove(toBeDeletedParticipant);
                _context.SaveChanges();
            }

        }

        // delete expense
        public void DeleteExpenseById(int id)
        {
            var toBeDeletedExpense = _context.Expenses.Find(id);
            if (toBeDeletedExpense != null)
            {
                _context.Expenses.Remove(toBeDeletedExpense);
                _context.SaveChanges();
            }

        }
    }
}
