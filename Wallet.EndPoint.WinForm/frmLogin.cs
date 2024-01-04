using ValidationComponents;
using Wallet.Application.Helpers;
using Wallet.Persistance.Common;
using Wallet.Persistance.Data;

namespace Wallet.EndPoint.WinForm
{
    public partial class frmLogin : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public frmLogin(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool isEdit = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.Text = "تنظیمات ورود به برنامه";
                btnLogin.Text = "تغییر رمز";

                var login = _unitOfWork.LoginRepository.Get().First();
                txtUsername.Text = login.UserName;
                txtPassword.Text = login.Password;

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (isEdit)
                {
                    var login = _unitOfWork.LoginRepository.Get().First();
                    login.UserName = txtUsername.Text;
                    login.Password = txtPassword.Text;
                    _unitOfWork.LoginRepository.Update(login);
                    _unitOfWork.Save();
                    System.Windows.Forms.Application.Restart();
                }
                else
                {
                    if (_unitOfWork.LoginRepository.Get(l => l.UserName == txtUsername.Text && l.Password == txtPassword.Text).Any())
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
}
