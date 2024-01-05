using Wallet.Application.DTOs;
using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces;
using Wallet.Domain.Interfaces.Base;

namespace Wallet.Service
{
    public class AccountReport
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Guid, Transaction> _transactionRepository;

        public AccountReport(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _transactionRepository = _unitOfWork.GetRepository<Guid, Transaction>();
        }


        public ReportViewModel ReportFromMain()
        {
            ReportViewModel rp = new();

            DateTime startDate = new(DateTime.Now.Year, DateTime.Now.Month, 01);
            DateTime endDate = new(DateTime.Now.Year, DateTime.Now.Month, 30);

            var receive = _transactionRepository.Get(a => a.TypeId == 1
            && a.CreatedAt >= startDate && a.CreatedAt <= endDate)
                .Select(a => a.Amount).ToList();

            var pay = _transactionRepository.Get(a => a.TypeId == 2
            && a.CreatedAt >= startDate && a.CreatedAt <= endDate)
                .Select(a => a.Amount).ToList();

            rp.Income = receive.Sum();
            rp.Expense = pay.Sum();
            rp.AccountBalance = (receive.Sum() - pay.Sum());

            return rp;
        }

    }
}
