using Wallet.Domain.Entities.Base;

namespace Wallet.Domain.Entities
{
    public class Login : BaseEntity<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
