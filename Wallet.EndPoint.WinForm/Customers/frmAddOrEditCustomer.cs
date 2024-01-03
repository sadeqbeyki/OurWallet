using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Wallet.Domain.Entities;
using Wallet.Persistance.Common;
using Wallet.Persistance.Data;

namespace Wallet.EndPoint.WinForm.Customers
{
    public partial class frmAddOrEditCustomer : Form
    {
        public Guid customerId = Guid.Empty;
        private readonly WalletDbContext _walletDbContext;
        private readonly UnitOfWork db;

        public frmAddOrEditCustomer(WalletDbContext walletDbContext)
        {
            _walletDbContext = walletDbContext;
            db = new(_walletDbContext);
        }


        public frmAddOrEditCustomer()
        {
            InitializeComponent();
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
            if (BaseValidator.IsFormValid(this.components))
            {
                //تولید نام تصادفی برای عکس که منحصر به فرد هم هست
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                //ذخیره در لوکیشن با نام تصادفی
                string path = System.Windows.Forms.Application.StartupPath + "/Images/";
                //اگر همچین فولدری وجود نداشت ایجاد کن
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                };
                pcCustomer.Image.Save(path + imageName);
                Customer customers = new Customer()
                {
                    FirstName = txtName.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
                    Address = lblAddress.Text,
                    Image = imageName
                };
                if (customerId == Guid.Empty)
                {
                    db.CustomerRepository.InsertCustomer(customers);
                }
                else
                {
                    customers.Id = customerId;
                    db.CustomerRepository.UpdateCustomer(customers);
                }

                db.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != Guid.Empty)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                var customer = db.CustomerRepository.GetCustomerById(customerId);
                txtName.Text = customer.FirstName;
                txtMobile.Text = customer.Mobile;
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                pcCustomer.ImageLocation = System.Windows.Forms.Application.StartupPath + "/Images/" + customer.Image;
            };
        }
    }
}
