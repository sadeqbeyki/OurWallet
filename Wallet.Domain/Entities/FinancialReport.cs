namespace Wallet.Domain.Entities
{
    public class FinancialReport
    {
        public int ReportID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
    }
}
