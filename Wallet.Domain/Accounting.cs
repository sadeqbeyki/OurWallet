using Wallet.Domain.Base;

namespace Wallet.Domain
{
    public class Accounting : BaseEntity<Guid>
    {
        public Guid CustomerId { get; set; }
        public Guid TypeId { get; set; }
        public Guid BankId { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
    }
}
