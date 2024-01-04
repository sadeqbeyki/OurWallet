using Wallet.Domain.Entities.Base;

namespace Wallet.Domain.Entities
{
    public class CustomerAccount : BaseEntity<int>
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
