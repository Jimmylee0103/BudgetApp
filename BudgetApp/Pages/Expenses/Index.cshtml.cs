using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BudgetApp.Models;

namespace BudgetApp.Pages.Expenses
{
    public class IndexModel : PageModel
    {
        private readonly BudgetApp.Models.BudgetAppContext _context;

        public IndexModel(BudgetApp.Models.BudgetAppContext context)
        {
            _context = context;
        }

        public IList<Expense> Expense { get;set; }

        public async Task OnGetAsync()
        {
            Expense = await _context.Expense.ToListAsync();
        }
    }
}
