using Wallet.Application.Helpers;
using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces;

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

            txtFilter.TabIndex = 1;
            txtTransactionCategory.TabIndex = 2;
            txtAccountType.TabIndex = 3;
            rbReceive.TabIndex = 4;
            rbPay.TabIndex = 5;
            txtAmount.TabIndex = 6;
            txtDescription.TabIndex = 7;
            btnSave.TabIndex = 8;

            txtName.TabStop = false;
        }

        private async void frmAddTransaction_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = await _unitOfWork.CustomerRepository.GetNameCustomer();
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.DataSource = _unitOfWork.TransactionCategoryRepository.GetCategoryName(txtTransactionCategory.Text);
            dgvAccount.AutoGenerateColumns = false;
            dgvAccount.DataSource = _unitOfWork.AccountRepository.GetAccountName(txtAccountType.Text);

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

        private async void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = await _unitOfWork.CustomerRepository.GetNameCustomer(txtFilter.Text);
        }
        private void txtTransactionCategory_TextChanged(object sender, EventArgs e)
        {
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.DataSource = _unitOfWork.TransactionCategoryRepository.GetCategoryName(txtTransactionCategory.Text);
        }

        private void txtAccountType_TextChanged(object sender, EventArgs e)
        {
            dgvAccount.AutoGenerateColumns = false;
            dgvAccount.DataSource = _unitOfWork.AccountRepository.GetAccountName(txtAccountType.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAccountType.Text = dgvAccount.CurrentRow.Cells[0].Value.ToString();
        }
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTransactionCategory.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //if (BaseValidator.IsFormValid(this.components))
            //{
            if (rbPay.Checked || rbReceive.Checked)
            {
                Wallet.Domain.Entities.Transaction transaction = new()
                {
                    CustomerId = await _unitOfWork.CustomerRepository.GetCustomerIdByName(txtName.Text),

                    CategoryId = _unitOfWork.TransactionCategoryRepository
                        .GetTransactionCategoryIdByName(txtTransactionCategory.Text),

                    AccountId = _unitOfWork.AccountRepository
                        .GetAccountIdByName(txtAccountType.Text),

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
                //_unitOfWork.Dispose();
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
