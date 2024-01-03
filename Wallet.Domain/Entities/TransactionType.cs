using Wallet.Domain.Entities.Base;

namespace Wallet.Domain.Entities
{
    public class TransactionType : BaseEntity<int>
    {
        public string Title { get; set; }
    }
}
