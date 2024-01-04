using ValidationComponents;
using Wallet.Application.Helpers;
using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces;
using Wallet.Persistance.Common;
using Wallet.Persistance.Data;

namespace Wallet.EndPoint.WinForm.Customers
{
    public partial class frmAddTransaction : Form
    {
        public Guid transactionId = Guid.Empty;
        private readonly UnitOfWork _unitOfWork;

        public frmAddTransaction(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public frmAddTransaction()
        {
            InitializeComponent();
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
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbReceive.Checked)
                {

                    //Accounting Create after make connection between database and datalayer
                    Wallet.Domain.Entities.Transaction transaction = new()
                    {
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        CustomerId = _unitOfWork.CustomerRepository.GetCustomerIdByName(txtName.Text),
                        //condition if == اگه چک شده بود 1 که همون آیدی اکانتینگ تایپ در جدول دیتابیس هست 
                        //و اگه چک نشده بود ۲ رو بزار
                        TypeId = (rbReceive.Checked) ? 1 : 2,
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
            }
        }
    }
}
