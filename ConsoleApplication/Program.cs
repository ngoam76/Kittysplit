using Kittysplit.DatabaseAbstraction;
using Kittysplit.Logic;
using Kittysplit.ConsoleApplication;
using System;

namespace Kittysplit.ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var dbContext = new KittySplitContext())
            {
                var createInstance = new Create(dbContext);
                var addInstance = new Add(dbContext);
                var getInstance = new GetById(dbContext);
                var updateInstance = new Update(dbContext);
                var deleteInstance = new DeleteById(dbContext);

                var newExpense1 = new Expense
                {
                    ExpenseId = 1,
                    ExpenseDescription = "Car rent",
                    ExpenseAmount = 100,
                    DateSpent = DateTime.Now
                };
                var newExpense2 = new Expense
                {
                    ExpenseId = 2,
                    ExpenseDescription = "Casino",
                    ExpenseAmount = 1000,
                    DateSpent= DateTime.Now
                };
                var newExpense3 = new Expense
                {
                    ExpenseId = 3,
                    ExpenseDescription = "Hotel rent",
                    ExpenseAmount = 200,
                    DateSpent = DateTime.Now
                };
                var newParticipant1 = new Participant
                {
                    ParticipantId = 1,
                    Name = "Chloe",
                    Expenses = new List<Expense>
                    {
                        newExpense1,
                        newExpense2
                    }
                };
                var newParticipant2 = new Participant
                {
                    ParticipantId = 2,
                    Name = "Numan",
                    Expenses = new List<Expense>
                    {
                        newExpense1,
                        newExpense2
                    }
                };
                var newParticipant3 = new Participant
                {
                    ParticipantId = 3,
                    Name = "Moataz",
                    Expenses = new List<Expense>
                    {
                        newExpense3
                    }
                };
                var newParticipant4 = new Participant
                {
                    ParticipantId = 4,
                    Name = "Abhishek",
                    /*Expenses = new List<Expense>
                    {
                        newExpense3
                    }*/
                };

                var tripToVegas = new Event
                {
                    EventId = 1,
                    EventName = "Trip to Vegas",
                    EventDescription = "For holiday",
                    EventLocation = "Vegas",
                    Currency = "EUR",
                    Participants = new List<Participant>
                    {
                        newParticipant1,
                        newParticipant2
                    },
                    Expenses = new List<Expense> { newExpense1, newExpense2 }
                };

                var tripToAthens = new Event
                {
                    EventId = 2,
                    EventName = "Trip to Athens",
                    EventDescription = "For work",
                    EventLocation = "Athens",
                    Currency = "USD"
                    /*Participants = new List<Participant>
                    {
                        newParticipant3,
                        newParticipant4
                    },
                    Expenses = new List<Expense> { newExpense3 }*/
                };

                //createInstance.CreateEvent(tripToAthens);
                //createInstance.CreateExpense(newExpense3);
                //createInstance.CreateParticipant(newParticipant3);
                //createInstance.CreateParticipant(newParticipant4);
                //addInstance.AddExpenseToParticipant(3, 4);
                //addInstance.AddParticipantToEvent(3, 2);
                //addInstance.AddParticipantToEvent(4, 2);
                //addInstance.AddExpenseToEvent(3, 2);
                //createInstance.CreateEvent(tripToVegas);
                //updateInstance.UpdateEventName(1, "Trip to LA");
                //updateInstance.UpdateEventCurrency(2, "EUR");
                //updateInstance.UpdateParticipantName(1, "Moe");
                //updateInstance.UpdateExpenseDescription(1, "Airplane rent");
                //updateInstance.UpdateExpenseAmount(2, 2000);
                //deleteInstance.DeleteParticipantById(4);
                //deleteInstance.DeleteExpenseById(3);
                //deleteInstance.DeleteEventById(2);
                getInstance.GetParticipantById(1);
                getInstance.GetExpenseById(1);
                getInstance.GetAllEvents();
                getInstance.GetAllParticipantsFromEvent(1);
                getInstance.GetAllExpensesFromEvent(1);

            }
        }
    }
}

