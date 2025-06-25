namespace BudgetSoftware.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }

        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        
    }
}
