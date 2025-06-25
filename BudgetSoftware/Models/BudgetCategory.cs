namespace BudgetSoftware.Models
{
    public class BudgetCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } // "Professional Fee", "DSA", etc.

        public ICollection<ContractBudget> ContractBudgets { get; set; }
    }
}
