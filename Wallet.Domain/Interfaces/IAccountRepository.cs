using Wallet.Domain.Entities;

namespace Wallet.Domain.Interfaces;

public interface IAccountRepository
{
    List<Account> GetAccountName(string filter = "");
    Guid GetAccountIdByName(string name);
}
