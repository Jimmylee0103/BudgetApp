using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class Expense
    {
        public int Id { get; set; }        
        public DateTime ExpenseDate { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public string Merchant { get; set; }
        public string Category { get; set; }
    }    
}
