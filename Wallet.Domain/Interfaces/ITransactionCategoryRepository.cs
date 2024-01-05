using Wallet.Domain.Entities;

namespace Wallet.Domain.Interfaces;

public interface ITransactionCategoryRepository
{
    List<TransactionCategory> GetCategoryName(string filter = "");
    int GetTransactionCategoryIdByName(string name);
}
