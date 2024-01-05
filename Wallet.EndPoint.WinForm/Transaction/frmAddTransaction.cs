using ValidationComponents;
using Wallet.Application.Helpers;
using Wallet.Domain.Interfaces;
using Wallet.Domain.Interfaces.Base;

namespace Wallet.EndPoint.WinForm.Customers
{
    public partial class frmAddTransaction : Form
    {
        public Guid transactionId = Guid.Empty;
        private readonly IUnitOfWork _unitOfWork;

        public frmAddTransaction(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void frmAddTransaction_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = _unitOfWork.CustomerRepository.GetNameCustomer();
            if (transactionId != Guid.Empty)
            {
                var account = _unitOfWork.transactionRepository.GetById(transactionId);
                txtAmount.Value = int.Parse(account.Amount.ToString());
                txtDescription.Text = account.Description;
                txtName.Text = _unitOfWork.CustomerRepository.GetCustomerNameById(account.CustomerId);
                if (account.TypeId == 1)
                {
                    rbReceive.Checked = true;
                }
                else
                {
                    rbPay.Checked = true;
                }
                this.Text = "ویرایش";
                btnSave.Text = "ویرایش";
                _unitOfWork.Dispose();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = _unitOfWork.CustomerRepository.GetNameCustomer(txtFilter.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (BaseValidator.IsFormValid(this.components))
            //{
            var category = _unitOfWork.transactionCategoryRepository
                    .GetEntityByCondition(f => f.Name == txtTransactionCategory.Text);
            var account = _unitOfWork.accountRepository
                    .GetEntityByCondition(f => f.Name == txtAccountType.Text);
            if (rbPay.Checked || rbReceive.Checked)
            {
                Wallet.Domain.Entities.Transaction transaction = new()
                {
                    CustomerId = _unitOfWork.CustomerRepository.GetCustomerIdByName(txtName.Text),

                    CategoryId = category.Id,

                    AccountId = account.Id,

                    TypeId = (rbReceive.Checked) ? 1 : 2,
                    Amount = int.Parse(txtAmount.Value.ToString()),
                    CreatedAt = DateTime.Now,
                    Description = txtDescription.Text
                };
                if (transactionId == Guid.Empty)
                {
                    _unitOfWork.transactionRepository.Insert(transaction);
                }
                else
                {
                    transaction.Id = transactionId;
                    _unitOfWork.transactionRepository.Update(transaction);
                }
                _unitOfWork.Save();
                _unitOfWork.Dispose();
                DialogResult = DialogResult.OK;
            }
            else
            {
                RtlMessageBox.Show("لطفا نوع تراکنش را برگزینید");
            }
            //}
        }
    }
}
