namespace BudgetSoftware.Models
{
    public class Consultant
    {
        public int ConsultantId { get; set; }
        public string ConsultantName { get; set; }
        public string ConsultantCode { get; set; }

        public int ContractId { get; set; }
        public Contract Contract { get; set; }

        public ICollection<Expense> Expenses { get; set; }
    }
}
