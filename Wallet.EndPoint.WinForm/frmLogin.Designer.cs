namespace Wallet.EndPoint.WinForm
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxLogin = new GroupBox();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(txtPassword);
            groupBoxLogin.Controls.Add(txtUsername);
            groupBoxLogin.Controls.Add(lblPassword);
            groupBoxLogin.Controls.Add(lblUsername);
            groupBoxLogin.Location = new Point(12, 12);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(347, 97);
            groupBoxLogin.TabIndex = 0;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "فرم ورود";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(247, 22);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(55, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "نام کاربری";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(260, 50);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "گذرواژه";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(20, 22);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 115);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 23);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "ورود به برنامه";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 148);
            Controls.Add(btnLogin);
            Controls.Add(groupBoxLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmLogin";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ورود";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
        private Button btnLogin;
    }
}