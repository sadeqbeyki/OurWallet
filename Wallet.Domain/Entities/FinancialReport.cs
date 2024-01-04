using Wallet.Domain.Entities.Base;

namespace Wallet.Domain.Entities
{
    public class FinancialReport : BaseEntity<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
    }
}
