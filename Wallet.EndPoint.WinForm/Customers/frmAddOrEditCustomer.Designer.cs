namespace Wallet.EndPoint.WinForm.Customers
{
    partial class frmAddOrEditCustomer
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
            groupBoxPerson = new GroupBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            txtName = new TextBox();
            lblAddress = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBoxImg = new GroupBox();
            btnSelectPhoto = new Button();
            pcCustomer = new PictureBox();
            btnSave = new Button();
            groupBoxPerson.SuspendLayout();
            groupBoxImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcCustomer).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPerson
            // 
            groupBoxPerson.Controls.Add(txtAddress);
            groupBoxPerson.Controls.Add(txtEmail);
            groupBoxPerson.Controls.Add(txtMobile);
            groupBoxPerson.Controls.Add(txtName);
            groupBoxPerson.Controls.Add(lblAddress);
            groupBoxPerson.Controls.Add(label3);
            groupBoxPerson.Controls.Add(label2);
            groupBoxPerson.Controls.Add(label1);
            groupBoxPerson.Location = new Point(196, 12);
            groupBoxPerson.Margin = new Padding(4, 3, 4, 3);
            groupBoxPerson.Name = "groupBoxPerson";
            groupBoxPerson.Padding = new Padding(4, 3, 4, 3);
            groupBoxPerson.Size = new Size(276, 267);
            groupBoxPerson.TabIndex = 0;
            groupBoxPerson.TabStop = false;
            groupBoxPerson.Text = "اطلاعات شخص";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(6, 172);
            txtAddress.Margin = new Padding(4, 3, 4, 3);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(259, 52);
            txtAddress.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 128);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(6, 84);
            txtMobile.Margin = new Padding(4, 3, 4, 3);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(259, 23);
            txtMobile.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 40);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(259, 23);
            txtName.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(229, 153);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(37, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "آدرس:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "ایمیل:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "موبایل:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 3;
            label1.Text = "نام:";
            // 
            // groupBoxImg
            // 
            groupBoxImg.Controls.Add(btnSelectPhoto);
            groupBoxImg.Controls.Add(pcCustomer);
            groupBoxImg.Location = new Point(12, 12);
            groupBoxImg.Margin = new Padding(4, 3, 4, 3);
            groupBoxImg.Name = "groupBoxImg";
            groupBoxImg.Padding = new Padding(4, 3, 4, 3);
            groupBoxImg.Size = new Size(178, 267);
            groupBoxImg.TabIndex = 1;
            groupBoxImg.TabStop = false;
            groupBoxImg.Text = "تصویر";
            // 
            // btnSelectPhoto
            // 
            btnSelectPhoto.Location = new Point(6, 240);
            btnSelectPhoto.Margin = new Padding(4, 3, 4, 3);
            btnSelectPhoto.Name = "btnSelectPhoto";
            btnSelectPhoto.Size = new Size(164, 23);
            btnSelectPhoto.TabIndex = 1;
            btnSelectPhoto.Text = "برگزیدن تصویر";
            btnSelectPhoto.UseVisualStyleBackColor = true;
            // 
            // pcCustomer
            // 
            pcCustomer.Image = Properties.Resources.no_profile_image;
            pcCustomer.Location = new Point(6, 22);
            pcCustomer.Margin = new Padding(4, 3, 4, 3);
            pcCustomer.Name = "pcCustomer";
            pcCustomer.Size = new Size(164, 212);
            pcCustomer.SizeMode = PictureBoxSizeMode.StretchImage;
            pcCustomer.TabIndex = 0;
            pcCustomer.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(397, 285);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "افزودن";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmAddOrEditCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 312);
            Controls.Add(btnSave);
            Controls.Add(groupBoxImg);
            Controls.Add(groupBoxPerson);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddOrEditCustomer";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن شخص جدید";
            groupBoxPerson.ResumeLayout(false);
            groupBoxPerson.PerformLayout();
            groupBoxImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPerson;
        private GroupBox groupBoxImg;
        private PictureBox pcCustomer;
        private Button btnSelectPhoto;
        private Button btnSave;
        private Label lblAddress;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private TextBox txtName;
    }
}