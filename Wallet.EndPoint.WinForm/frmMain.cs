namespace Wallet.EndPoint.WinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void editLoginItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new();
            frmLogin.isEdit = true;
            frmLogin.ShowDialog();
        }
    }
}
