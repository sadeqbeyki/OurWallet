using Wallet.Domain.Entities.Base;

namespace Wallet.Domain.Entities
{
    public class Transaction : BaseEntity<Guid>
    {
        public Guid CustomerId { get; set; }
        public Guid TypeId { get; set; }
        public Guid BankId { get; set; }
        public int CategoryId { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
    }
}
