using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmNewAccounting : Form
    {
        private UnitOfWork db;
        //مقدار دهی از بیرون - frmReport (edit Button) - just this line
        public int AccountID = 0;
        public frmNewAccounting()
        {
            InitializeComponent();
        }

        private void frmNewAccounting_Load(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.CustomerRepository.GetNameCustomers();
            if (AccountID != 0)
            {
                var account = db.AccuntingRepository.GetById(AccountID);
                txtAmount.Value = int.Parse(account.Amount.ToString());
                txtDescription.Text = account.Description;
                txtName.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
                if (account.TypeID == 1)
                {
                    rbRecive.Checked=true;
                }
                else
                {
                    rbPay.Checked = true;
                }
                this.Text = "ویرایش";
                btnSave.Text = "ویرایش";
                db.Dispose();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.CustomerRepository.GetNameCustomers(txtFilter.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbRecive.Checked)
                {
                    db = new UnitOfWork();
                    //Accounting Create after make connection between database and datalayer
                    DataLayer.Accounting accounting = new DataLayer.Accounting()
                    {
                        Amount=int.Parse(txtAmount.Value.ToString()),
                        CustomerID = db.CustomerRepository.GetCustomerIdByName(txtName.Text),
                        //condition if == اگه چک شده بود 1 که همون آیدی اکانتینگ تایپ در جدول دیتابیس هست 
                        //و اگه چک نشده بود ۲ رو بزار
                        TypeID= (rbRecive.Checked)?1:2,
                        DateTime = DateTime.Now,
                        Description = txtDescription.Text
                    };
                    if (AccountID == 0)
                    {
                        db.AccuntingRepository.Insert(accounting);
                    }
                    else
                    {
                        accounting.ID = AccountID;
                        db.AccuntingRepository.Update(accounting);
                    }
                    db.Save();
                    db.Dispose();
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
