using Wallet.Application.DTOs;
using Wallet.Application.Helpers;
using Wallet.Domain.Interfaces;
using Wallet.EndPoint.WinForm.Customers;
using Wallet.EndPoint.WinForm.Transaction;
using Wallet.Service;

namespace Wallet.EndPoint.WinForm
{
    public partial class frmMain : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public frmMain(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //_dbContext.Database.EnsureCreated();
            //_dbContext.Transactions.Load();
        }

        private void btnReportExpense_Click(object sender, EventArgs e)
        {
            frmReport frmReports = new(_unitOfWork);
            frmReports.TypeId = 2;
            frmReports.ShowDialog();
        }

        private void btnReportReceive_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new(_unitOfWork);
            frmReport.TypeId = 1;
            frmReport.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //frmLogin frmLogin = new frmLogin();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
                lblDate.Text = DateConvertor.ToShamsi(DateTime.Now);
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
                this.Show();
                Report();
            //}
            //else
            //{
            //    System.Windows.Forms.Application.Exit();
            //}
        }

        void Report()
        {
            AccountReport accountReport = new(_unitOfWork);
            ReportViewModel report = accountReport.ReportFromMain();
            lblExpense.Text = report.Expense.ToString("#,0");
            lblIncome.Text = report.Income.ToString("#,0");
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Report();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomer = new(_unitOfWork);
            frmCustomer.ShowDialog();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            frmAddTransaction frmAddTransactions = new(_unitOfWork);
            frmAddTransactions.ShowDialog();
        }

    }
}
