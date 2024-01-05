using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces;
using Wallet.Persistance.Common;

namespace Wallet.Persistance
{
    public class AccountRepository : IAccountRepository
    {
        private readonly WalletDbContext _dbContext;

        public AccountRepository(WalletDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Guid GetAccountIdByName(string name)
        {
            return _dbContext.Accounts.FirstOrDefault(a => a.Name == name).Id;
        }

        public List<Account> GetAccountName(string filter = "")
        {
            if (filter == "")
            {
                return _dbContext.Accounts.Select(c => new Account()
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList();
            }
            return _dbContext.Accounts.Where(c => c.Name.Contains(filter)).Select(c => new Account()
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();
        }
    }
}
