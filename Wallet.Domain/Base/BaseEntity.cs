namespace Wallet.Domain.Base
{
    public class BaseEntity<T>
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
