using Kittysplit.DatabaseAbstraction;
using Kittysplit.Logic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittysplit.ConsoleApplication
{
    public class Create // to create objects
    {
        private readonly KittySplitContext _context;
        public Create(KittySplitContext context)
        {
            _context = context;
        }

        // create new event
        public Event? CreateEvent(Event newEvent)
        {
            _context.Events.Add(newEvent);
            _context.SaveChanges();
            return newEvent;
        }

        // create new participant
        public Participant? CreateParticipant(Participant newParticipant)
        {
            _context.Participants.Add(newParticipant);
            _context.SaveChanges();
            return newParticipant;
        }

        // create new expense
        public Expense? CreateExpense(Expense newExpense)
        {
            _context.Expenses.Add(newExpense);
            _context.SaveChanges();
            return newExpense;
        }
    }

}
