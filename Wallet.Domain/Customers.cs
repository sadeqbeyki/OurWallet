using Wallet.Domain.Base;

namespace Wallet.Domain
{
    public class Customers : BaseEntity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
    }
}
