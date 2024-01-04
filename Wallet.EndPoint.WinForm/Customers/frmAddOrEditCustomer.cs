using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces;

namespace Wallet.EndPoint.WinForm.Customers
{
    public partial class frmAddOrEditCustomer : Form
    {
        public Guid customerId = Guid.Empty;
        private readonly IUnitOfWork _unitOfWork;

        public frmAddOrEditCustomer(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (BaseValidator.IsFormValid(this.components))
            //{
            string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
            string path = System.Windows.Forms.Application.StartupPath + "/Images/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            };
            pcCustomer.Image.Save(path + imageName);
            Customer customers = new Customer()
            {
                CreatedAt = DateTime.Now,
                FirstName = txtName.Text,
                LastName = txtLastName.Text,
                Mobile = txtMobile.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                Image = imageName
            };
            if (customerId == Guid.Empty)
            {
                _unitOfWork.CustomerRepository.InsertCustomer(customers);
            }
            else
            {
                customers.Id = customerId;
                _unitOfWork.CustomerRepository.UpdateCustomer(customers);
            }

            _unitOfWork.Save();
            DialogResult = DialogResult.OK;
            //}
        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != Guid.Empty)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                var customer = _unitOfWork.CustomerRepository.GetCustomerById(customerId);
                txtName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtMobile.Text = customer.Mobile;
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                pcCustomer.ImageLocation = System.Windows.Forms.Application.StartupPath + "/Images/" + customer.Image;
            };
        }
    }
}
