using Wallet.Application.DTOs;
using Wallet.EndPoint.WinForm.Customers;
using Wallet.EndPoint.WinForm.Transaction;
using Wallet.Persistance.Common;
using Wallet.Service;

namespace Wallet.EndPoint.WinForm
{
    public partial class frmMain : Form
    {
        private readonly WalletDbContext _walletDbContext;

        public frmMain(WalletDbContext walletDbContext)
        {
            _walletDbContext = walletDbContext;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomer = new frmCustomers();
            frmCustomer.ShowDialog();
        }

        private void btnNewAccounting_Click(object sender, EventArgs e)
        {
            frmAddTransaction frmAddTransactions = new frmAddTransaction();
            frmAddTransactions.ShowDialog();
        }

        private void btnReportPay_Click(object sender, EventArgs e)
        {
            frmReport frmReports = new frmReport();
            frmReports.TypeId = 2;
            frmReports.ShowDialog();
        }

        private void btnReportRecive_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.TypeId = 1;
            frmReport.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            //this.Hide();
            //frmLogin frmLogin = new frmLogin();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    lblDate.Text = DateConvertor.ToShamsi(DateTime.Now);
            //    lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            //    this.Show();
            //    Report();
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }

        void Report()
        {
            AccountReport accountReport = new (_walletDbContext);
            ReportViewModel report = accountReport.ReportFromMain();
            lblExpense.Text = report.Pay.ToString("#,0");
            lblReceive.Text = report.Recive.ToString("#,0");
            lblAccountBalance.Text = report.AccountBalance.ToString("0,#");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void editLoginItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new();
            frmLogin.isEdit = true;
            frmLogin.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Report();
        }
    }
}
