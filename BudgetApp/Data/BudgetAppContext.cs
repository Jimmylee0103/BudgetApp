using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Models
{
    public class BudgetAppContext : DbContext
    {
        public BudgetAppContext (DbContextOptions<BudgetAppContext> options)
            : base(options)
        {
        }

        public DbSet<Expense> Expense { get; set; }
    }
}
