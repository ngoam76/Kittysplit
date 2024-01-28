using Kittysplit.DatabaseAbstraction;
using Kittysplit.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittysplit.ConsoleApplication
{
    public class Add // for already existing objects
    {
        private readonly KittySplitContext _context;
        public Add(KittySplitContext context)
        {
            _context = context;
        }
        // Add participant to event
        public void AddParticipantToEvent( int parId, int eventId)
        {
            var eventToUpdate = _context.Events.Find(eventId);
            var participantToAdd = _context.Participants.Find(parId);
            if (participantToAdd is null || eventToUpdate is null )
            {
                throw new InvalidOperationException("Event or participant does not exist.");
            }
            if (eventToUpdate.Participants is null )
            {
                eventToUpdate.Participants = new List<Participant>();
            }
            eventToUpdate.Participants.Add(participantToAdd);
            _context.SaveChanges();
        }
        // Add expense to event
        public void AddExpenseToEvent(int expenseId, int eventId)
        {
            var eventToUpdate = _context.Events.Find(eventId);
            var expenseToAdd = _context.Expenses.Find(expenseId);
            if (expenseToAdd is null || eventToUpdate is null)
            {
                throw new InvalidOperationException("Event or expense does not exist.");
            }
            if (eventToUpdate.Expenses is null)
            {
                eventToUpdate.Expenses = new List<Expense>();
            }
            eventToUpdate.Expenses.Add(expenseToAdd);
            _context.SaveChanges();
        }
        // Add expense to participant
        public void AddExpenseToParticipant(int expenseId, int parId)
        {
            var participantToUpdate = _context.Participants.Find(parId);
            var expenseToAdd = _context.Expenses.Find(expenseId);
            if (expenseToAdd is null || participantToUpdate is null)
            {
                throw new InvalidOperationException("Participant or expense does not exist.");
            }
            if (participantToUpdate.Expenses is null)
            {
                participantToUpdate.Expenses = new List<Expense>();
            }
            participantToUpdate.Expenses.Add(expenseToAdd);
            _context.SaveChanges();
        }
    }
}
