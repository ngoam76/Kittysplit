using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kittysplit.Logic;

namespace Kittysplit.DatabaseAbstraction
{
    public class KittySplitContext : DbContext // to interact with database
    {
        public KittySplitContext() { }
        public KittySplitContext (DbContextOptions<KittySplitContext> options) : base(options)
        {

        }
        public DbSet<Participant> Participants => Set<Participant>();
        public DbSet<Expense> Expenses => Set<Expense>();
        public DbSet<Event> Events => Set<Event>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=ConsoleApplication/Kittysplit.db");
    }
}
