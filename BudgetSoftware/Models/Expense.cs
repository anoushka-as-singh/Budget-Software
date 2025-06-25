namespace BudgetSoftware.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public int ContractBudgetId { get; set; }
        public ContractBudget ContractBudget { get; set; }

        public int ConsultantId { get; set; }
        public Consultant Consultant { get; set; }

        public string InvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime ExpenseDate { get; set; }
        public bool Paid { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
