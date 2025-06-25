using Microsoft.EntityFrameworkCore;

namespace BudgetSoftware.Models
{
    public class ContractDbContext:DbContext
    {
        public ContractDbContext(DbContextOptions<ContractDbContext> options)
            : base(options)
        {
        }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<BudgetCategory> BudgetCategories { get; set; }
        public DbSet<ContractBudget> ContractBudgets { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Contract
            modelBuilder.Entity<Contract>()
                .HasKey(c => c.ContractId);

            modelBuilder.Entity<Contract>()
                .HasMany(c => c.Consultants)
                .WithOne(cons => cons.Contract)
                .HasForeignKey(cons => cons.ContractId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Contract>()
                .HasMany(c => c.Budgets)
                .WithOne(b => b.Contract)
                .HasForeignKey(b => b.ContractId)
                .OnDelete(DeleteBehavior.Cascade);

            // Consultant
            modelBuilder.Entity<Consultant>()
                .HasKey(c => c.ConsultantId);

            modelBuilder.Entity<Consultant>()
                .HasMany(c => c.Expenses)
                .WithOne(e => e.Consultant)
                .HasForeignKey(e => e.ConsultantId)
                .OnDelete(DeleteBehavior.Restrict);

            // BudgetCategory
            modelBuilder.Entity<BudgetCategory>()
                .HasKey(bc => bc.CategoryId);

            modelBuilder.Entity<BudgetCategory>()
                .HasMany(bc => bc.ContractBudgets)
                .WithOne(cb => cb.Category)
                .HasForeignKey(cb => cb.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // ContractBudget
            modelBuilder.Entity<ContractBudget>()
                .HasKey(cb => cb.ContractBudgetId);

            modelBuilder.Entity<ContractBudget>()
                .HasMany(cb => cb.Expenses)
                .WithOne(e => e.ContractBudget)
                .HasForeignKey(e => e.ContractBudgetId)
                .OnDelete(DeleteBehavior.Restrict);

            // Expense
            modelBuilder.Entity<Expense>()
                .HasKey(e => e.ExpenseId);

            modelBuilder.Entity<Expense>()
                .HasMany(e => e.Payments)
                .WithOne(p => p.Expense)
                .HasForeignKey(p => p.ExpenseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Payment
            modelBuilder.Entity<Payment>()
                .HasKey(p => p.PaymentId);
        }
}
}
