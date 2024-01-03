using Wallet.Domain.Base;

namespace Wallet.Domain
{
    public class Bank : BaseEntity<Guid>
    {
        public string Name { get; set; }
    }
}
