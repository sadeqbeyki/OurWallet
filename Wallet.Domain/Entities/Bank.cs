using Wallet.Domain.Entities.Base;

namespace Wallet.Domain.Entities
{
    public class Bank : BaseEntity<Guid>
    {
        public string Name { get; set; }
    }
}
