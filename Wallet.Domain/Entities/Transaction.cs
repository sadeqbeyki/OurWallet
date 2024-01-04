using Wallet.Domain.Entities.Base;
using Wallet.Domain.Enum;

namespace Wallet.Domain.Entities
{
    public class Transaction : BaseEntity<Guid>
    {
        public Guid CustomerId { get; set; }
        public int Amount { get; set; }
        public int CategoryId { get; set; }
        public Guid AccountId { get; set; }
        public int TypeId { get; set; }
        public string Description { get; set; }
        //public string Month { get; set; }
        //public string Day { get; set; }
    }
}
