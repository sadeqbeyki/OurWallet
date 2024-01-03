using Wallet.Domain.Entities.Base;

namespace Wallet.Domain.Entities
{
    public class TransactionCategory : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
