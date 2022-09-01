﻿using System;
using System.Linq;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer.Context;

namespace Accounting.App
{
    public partial class frmLogin : Form
    {
        public bool isEdit = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using(UnitOfWork db = new UnitOfWork())
                {
                    if (isEdit)
                    {
                        var login = db.LoginRepository.Get().First();
                        login.UserName = txtUserName.Text;
                        login.Password = txtPassword.Text;
                        db.LoginRepository.Update(login);
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepository.Get(l => l.UserName == "admin" && l.Password == "admin").Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("اطلاعات وارد شده صحیح نیست");
                        }
                    }

                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (isEdit) //(isEdit=true)
            {
                this.Text = "تنظیمات ورود به برنامه";
                btnLogin.Text = "تغییر رمز";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.LoginRepository.Get().First();
                    txtUserName.Text = login.UserName;
                    txtPassword.Text = login.Password;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}