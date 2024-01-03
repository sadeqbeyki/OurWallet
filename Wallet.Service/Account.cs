using Wallet.Application.DTOs;
using Wallet.Persistance.Common;
using Wallet.Persistance.Data;

namespace Wallet.Service
{
    public class Account
    {
        private readonly WalletDbContext _walletDbContext;

        public Account(WalletDbContext walletDbContext)
        {
            _walletDbContext = walletDbContext;
        }

        public ReportViewModel ReportFromMain()
        {
            ReportViewModel rp = new();
            using (UnitOfWork db = new(_walletDbContext))
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);

                var receive = db.transactionRepository.Get(a => a.TypeId == 1 
                && a.CreatedAt >= startDate && a.CreatedAt <= endDate)
                    .Select(a => a.Amount).ToList();

                var pay = db.transactionRepository.Get(a => a.TypeId == 2 
                && a.CreatedAt >= startDate && a.CreatedAt <= endDate)
                    .Select(a => a.Amount).ToList();

                rp.Recive = receive.Sum();
                rp.Pay = pay.Sum();
                rp.AccountBalance = (receive.Sum() - pay.Sum());
            }
            return rp;
        }

    }
}
