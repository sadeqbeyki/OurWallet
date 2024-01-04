using System.Data;
using Wallet.Application.Helpers;
using Wallet.Domain.Entities;
using Wallet.EndPoint.WinForm.Customers;
using Wallet.Persistance.Common;
using Wallet.Persistance.Data;

namespace Wallet.EndPoint.WinForm.Transaction
{
    public partial class frmReport : Form
    {
        public int TypeId = 0;
        private readonly WalletDbContext _walletDbContext;
        private readonly UnitOfWork db;
        public frmReport(WalletDbContext walletDbContext)
        {
            _walletDbContext = walletDbContext;
            db = new(_walletDbContext);
        }

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork(_walletDbContext))
            {
                List<Customer> list = new List<Customer>();
                list.Add(new Customer 
                { 
                    Id = Guid.Empty,
                    FirstName = "انتخاب کنید" 
                });
                list.AddRange(db.CustomerRepository.GetNameCustomer());
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
            }
            if (TypeId == 1)
            {
                this.Text = "دریافتی ها";
            }
            else
            {
                this.Text = "پرداختی ها";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        void Filter()
        {
            using (UnitOfWork db = new UnitOfWork(_walletDbContext))
            {
                List<Wallet.Domain.Entities.Transaction> result = new List<Wallet.Domain.Entities.Transaction>();
                // "?" mean is = Can Be Null
                DateTime? startDate;
                DateTime? endDate;
                if ((int)cbCustomer.SelectedValue != 0)
                {
                    Guid customerId = Guid.Parse(cbCustomer.SelectedValue.ToString());
                    result.AddRange(db.transactionRepository.Get(a => a.TypeId == TypeId && a.CustomerId == customerId));
                }
                else
                {
                    result.AddRange(db.transactionRepository.Get(a => a.TypeId == TypeId));
                }

                if (txtFromDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtFromDate.Text);
                    startDate = DateConvertor.ToMiladi(startDate.Value);
                    result = result.Where(r => r.CreatedAt >= startDate.Value).ToList();
                }
                if (txtToDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txtToDate.Text);
                    endDate = DateConvertor.ToMiladi(endDate.Value);
                    result = result.Where(r => r.CreatedAt <= endDate.Value).ToList();

                }


                //dgvReport.AutoGenerateColumns = false;
                //dgvReport.DataSource = result;
                //OR ... foreach
                //this line insert for dont rePrint in report form after Click on ANJAM
                dgvReport.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerId);
                    dgvReport.Rows.Add(accounting.Id, customerName, accounting.Amount, accounting.CreatedAt.ToShamsi(), accounting.Description);
                };
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                Guid id = Guid.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("آیا از حذف مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork(_walletDbContext))
                    {
                        db.transactionRepository.Delete(id);
                        db.Save();
                        Filter();
                    }
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                Guid id = Guid.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                frmAddTransaction frmNew = new frmAddTransaction();
                frmNew.transactionId = id;
                if (frmNew.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");
            foreach (DataGridViewRow item in dgvReport.Rows)
            {
                dtPrint.Rows.Add(
                item.Cells[0].Value.ToString(),
                item.Cells[1].Value.ToString(),
                item.Cells[2].Value.ToString(),
                item.Cells[3].Value.ToString()
                );
            }
            //stiPrint.Load(Application.StartupPath + "/Report.mrt");
            //stiPrint.RegData("OLE DB", dtPrint);
            //stiPrint.Show();
        }
    }
}
