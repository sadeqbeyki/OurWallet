using Wallet.Domain.Base;

namespace Wallet.Domain
{
    public class Login : BaseEntity<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
