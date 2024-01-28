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
    public class GetById
    {
        private readonly KittySplitContext _context;
        public GetById(KittySplitContext context)
        {
            _context = context;
        }

        // get all events in Kitty
        public void GetAllEvents()
        {
            var events = _context.Events
                .AsNoTracking()
                .ToList();
            Console.WriteLine("Events in Kitty: ");
            foreach (var ev in events)
            {
                Console.WriteLine($"Event ID: {ev.EventId}, Name: {ev.EventName}");
            }
        }

        // get all participants in event
        public void GetAllParticipantsFromEvent(int eventId)
        {
            var participants = _context.Events
                .Where(e => e.EventId == eventId)
                .SelectMany(e => e.Participants)
                .AsNoTracking()
                .ToList();
            Console.WriteLine($"Participants in event: ");
            foreach (var participant in participants)
            {
                Console.WriteLine($"Participant ID: {participant.ParticipantId}, Name: {participant.Name}");
            }
        }

        // get all expenses in event
        public void GetAllExpensesFromEvent(int eventId)
        {
            var expenses = _context.Events
                .Where(e => e.EventId == eventId)
                .SelectMany(e => e.Expenses)
                .AsNoTracking()
                .ToList();
            Console.WriteLine($"Expenses in event: ");
            foreach (var expense in expenses)
            {
                Console.WriteLine($"Expense: {expense.ExpenseDescription}, Amount: {expense.ExpenseAmount}");
            }
        }

        // get participant by ID
        public void GetParticipantById(int id)
        {
            var participant = _context.Participants
                .Where(p => p.ParticipantId == id)
                .FirstOrDefault();
            if (participant != null)
            {
                Console.WriteLine($"Participant found - Id: {participant.ParticipantId}, Name: {participant.Name}");
            }
            else
            {
                Console.WriteLine($"Participant with Id {id} not found.");
            }
        }
        // get expense by ID
        public void GetExpenseById(int id)
        {
            var expense = _context.Expenses
                .Where(e => e.ExpenseId == id)
                .FirstOrDefault();
            if (expense != null)
            {
                Console.WriteLine($"Expense found - Description: {expense.ExpenseDescription}, Amount: {expense.ExpenseAmount}");
            }
            else
            {
                Console.WriteLine($"Expense with Id {id} not found.");
            }
        }
    }
}
