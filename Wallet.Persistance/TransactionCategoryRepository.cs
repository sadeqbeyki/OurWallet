using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces;
using Wallet.Persistance.Common;

namespace Wallet.Persistance;

public class TransactionCategoryRepository : ITransactionCategoryRepository
{
    private readonly WalletDbContext _dbContext;

    public TransactionCategoryRepository(WalletDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<TransactionCategory> GetCategoryName(string filter = "")
    {
        if (filter == "")
        {
            return _dbContext.TransactionCategories.Select(c => new TransactionCategory()
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();
        }
        return _dbContext.TransactionCategories.Where(c => c.Name.Contains(filter)).Select(c => new TransactionCategory()
        {
            Id = c.Id,
            Name = c.Name,
        }).ToList();
    }

    public int GetTransactionCategoryIdByName(string name)
    {
        return _dbContext.TransactionCategories.First(c => c.Name == name).Id;
    }
}
