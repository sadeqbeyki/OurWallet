using Microsoft.EntityFrameworkCore;
using Wallet.Domain.Entities;

namespace Wallet.Persistance.Common;

public class WalletDbContext : DbContext
{
    public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<FinancialReport> FinancialReports { get; set; }
    public DbSet<Login> Logins { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionCategory> TransactionCategories { get; set; }
    public DbSet<TransactionType> TransactionTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HesabDB;Integrated Security=True");
        //base.OnConfiguring(optionsBuilder);
    }
}
