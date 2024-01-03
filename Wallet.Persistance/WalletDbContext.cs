using Microsoft.EntityFrameworkCore;
using Wallet.Domain.Entities;

namespace Wallet.Persistance;

public class WalletDbContext : DbContext
{
    public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options)
    {
    }

    public DbSet<Member> Members { get; set; }
}
