using Kittysplit.DatabaseAbstraction;
using Kittysplit.Logic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittysplit.Application
{
    public class UseCase1
    {
        private readonly KittySplitContext _vegascontext;
        public UseCase1(KittySplitContext vegascontext)
        {
            _vegascontext = vegascontext;
        }
        // get all participants
        public IEnumerable<Participant> GetAllParticipants()
        {
            return _vegascontext.Participants
                .AsNoTracking()
                .ToList();
        }
        // get all expenses
        public IEnumerable<Expense> GetAllExpenses()
        {
            return _vegascontext.Expenses
                .AsNoTracking()
                .ToList();
        }
        // get participant by ID
        public Participant? GetById(int id)
        {
            return _vegascontext.Participants
                .Include(p => p.Event)
                .Include(p => p.Expenses)
                .FirstOrDefault(p => p.ParticipantId == id);
        }
        // get expense by ID
        // create new participant
        public Participant? CreateParticipant(Participant newParticipant)
        {
            _vegascontext.Participants.Add(newParticipant);
            _vegascontext.SaveChanges();
            return newParticipant;
        }
        // create new expense
        // add expense to participant
        // update event
        // delete participant
        // delete expense
    }

}
