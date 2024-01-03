using Wallet.Domain.Base;

namespace Wallet.Domain
{
    public class AccountingType : BaseEntity<int>
    {
        public string Title { get; set; }
    }
}
