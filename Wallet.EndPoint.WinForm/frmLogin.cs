using ValidationComponents;
using Wallet.Application.Helpers;
using Wallet.Persistance.Common;
using Wallet.Persistance.Data;

namespace Wallet.EndPoint.WinForm
{
    public partial class frmLogin : Form
    {
        private readonly WalletDbContext _walletDbContext;

        public frmLogin(WalletDbContext walletDbContext)
        {
            _walletDbContext = walletDbContext;
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
                using (UnitOfWork db = new UnitOfWork(_walletDbContext))
                {
                    var login = db.LoginRepository.Get().First();
                    txtUsername.Text = login.UserName;
                    txtPassword.Text = login.Password;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork(_walletDbContext))
                {
                    if (isEdit)
                    {
                        var login = db.LoginRepository.Get().First();
                        login.UserName = txtUsername.Text;
                        login.Password = txtPassword.Text;
                        db.LoginRepository.Update(login);
                        db.Save();
                        System.Windows.Forms.Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepository.Get(l => l.UserName == txtUsername.Text && l.Password == txtPassword.Text).Any())
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
}
