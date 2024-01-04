using Wallet.Domain.Entities.Base;
using Wallet.Domain.Enum;

namespace Wallet.Domain.Entities
{
    public class Account : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public decimal InitialBalance { get; set; }
        public AccountType Type { get; set; }
    }
}
