namespace Wallet.Domain.Entities.Base
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
