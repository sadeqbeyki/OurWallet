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
using Accounting.DataLayer.Context;
using Accounting.DataLayer;
using System.IO;

namespace Accounting.App
{
    public partial class frmAddOrEditCustomer : Form
    {
        public int customerId = 0;
        UnitOfWork db = new UnitOfWork();
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
                string path = Application.StartupPath + "/Images/";
                //اگر همچین فولدری وجود نداشت ایجاد کن
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                };
                pcCustomer.Image.Save(path + imageName);
                Customers customers = new Customers()
                {
                    FullName = txtName.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
                    Address = lblAddress.Text,
                    CustomerImage = imageName
                };
                if (customerId == 0)
                {
                    db.CustomerRepository.InsertCustomer(customers);
                }
                else
                {
                    customers.CustomerID = customerId;
                    db.CustomerRepository.UpdateCustomer(customers);
                }

                db.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                var customer = db.CustomerRepository.GetCustomersById(customerId);
                txtName.Text = customer.FullName;
                txtMobile.Text = customer.Mobile;
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
            };
        }
    }
}
