using System.Reflection.Metadata;

namespace BudgetSoftware.Models
{
    public class Contract
    {
        public int ContractId { get; set; }
        public string ContractNumber { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime BudgetValidity { get; set; }
        public string State { get; set; }
        public string DutyStation { get; set; }
        public string Programme { get; set; }
        public string Modality { get; set; }
        public string Comments { get; set; }

        public ICollection<Consultant> Consultants { get; set; }
        public ICollection<ContractBudget> Budgets { get; set; }
    }
}
