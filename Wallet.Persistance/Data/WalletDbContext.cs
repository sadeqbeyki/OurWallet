using Microsoft.EntityFrameworkCore;
using Wallet.Domain.Entities;

namespace Wallet.Persistance.Common;

public class WalletDbContext : DbContext
{
    public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
}
