using Wallet.Application.Helpers;
using Wallet.Persistance.Common;
using Wallet.Persistance.Data;

namespace Wallet.EndPoint.WinForm.Customers
{
    public partial class frmCustomers : Form
    {
        private readonly WalletDbContext _walletDbContext;

        public frmCustomers(WalletDbContext walletDbContext)
        {
            _walletDbContext = walletDbContext;
        }

        public frmCustomers()
        {
            InitializeComponent();
        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork(_walletDbContext))
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork(_walletDbContext))
            {
                dgvCustomers.DataSource = db.CustomerRepository.GetCustomerByFilter(txtFilter.Text);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork(_walletDbContext))
                {
                    string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {name} مطمعن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //cells[0] = delete by id
                        object value = dgvCustomers.CurrentRow.Cells[0].Value;
                        if (value != null)
                        {
                            Guid customerId = (Guid)value;
                            db.CustomerRepository.DeleteCustomer(customerId);
                            db.Save();
                            BindGrid();
                        }
                    }

                }

            }
            else
            {
                RtlMessageBox.Show("شخصی را برگزینید");
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEditCustomer frmAdd = new frmAddOrEditCustomer();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Guid customerId = Guid.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
            frmAddOrEditCustomer frmAddOrEdit = new frmAddOrEditCustomer();
            frmAddOrEdit.customerId = customerId;
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}
