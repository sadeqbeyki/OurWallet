using Wallet.Application.Helpers;
using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces;
using Wallet.Domain.Interfaces.Base;
using Wallet.Persistance.Common;
using Wallet.Persistance.Data;

namespace Wallet.EndPoint.WinForm.Customers
{
    public partial class frmCustomers : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public frmCustomers(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = _unitOfWork.CustomerRepository.GetAllCustomers();
        }
 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = _unitOfWork.CustomerRepository.GetCustomerByFilter(txtFilter.Text);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {name} مطمعن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //cells[0] = delete by id
                    object value = dgvCustomers.CurrentRow.Cells[0].Value;
                    if (value != null)
                    {
                        Guid customerId = (Guid)value;
                        _unitOfWork.CustomerRepository.DeleteCustomer(customerId);
                        _unitOfWork.Save();
                        BindGrid();
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
            frmAddOrEditCustomer frmAdd = new frmAddOrEditCustomer(_unitOfWork);
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Guid customerId = Guid.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
            frmAddOrEditCustomer frmAddOrEdit = new frmAddOrEditCustomer(_unitOfWork);
            frmAddOrEdit.customerId = customerId;
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}
