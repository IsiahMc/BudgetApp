using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Models;

public class Transaction
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public Decimal Amount { get; set; }

    public TransactionType TransactionType { get; set; }
    
    public Transaction()
    {
        
    }
}
public enum TransactionType
    {
        [Display(Name = "Income")]
        Income = 1,
        
        [Display(Name = "Expense")]
        Expense = 2
    }