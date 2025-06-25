namespace BudgetSoftware.Models
{
    public class ContractBudget
    {
        public int ContractBudgetId { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }

        public int CategoryId { get; set; }
        public BudgetCategory Category { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal RemainingAmount { get; set; }

        public ICollection<Expense> Expenses { get; set; }
    }
}
