namespace Wallet.EndPoint.WinForm.Customers
{
    partial class frmAddTransaction
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            groupBoxPerson = new GroupBox();
            dgvCategory = new DataGridView();
            CategoryName = new DataGridViewTextBoxColumn();
            txtAccountType = new TextBox();
            label5 = new Label();
            txtTransactionCategory = new TextBox();
            label4 = new Label();
            txtAmount = new NumericUpDown();
            rbPay = new RadioButton();
            rbReceive = new RadioButton();
            txtDescription = new TextBox();
            txtName = new TextBox();
            lblAddress = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbPerson = new GroupBox();
            dgvAccount = new DataGridView();
            AccountName = new DataGridViewTextBoxColumn();
            dgvCustomers = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            txtFilter = new TextBox();
            btnSave = new Button();
            groupBoxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            gbPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPerson
            // 
            groupBoxPerson.Controls.Add(dgvCategory);
            groupBoxPerson.Controls.Add(txtAccountType);
            groupBoxPerson.Controls.Add(label5);
            groupBoxPerson.Controls.Add(txtTransactionCategory);
            groupBoxPerson.Controls.Add(label4);
            groupBoxPerson.Controls.Add(txtAmount);
            groupBoxPerson.Controls.Add(rbPay);
            groupBoxPerson.Controls.Add(rbReceive);
            groupBoxPerson.Controls.Add(txtDescription);
            groupBoxPerson.Controls.Add(txtName);
            groupBoxPerson.Controls.Add(lblAddress);
            groupBoxPerson.Controls.Add(label3);
            groupBoxPerson.Controls.Add(label2);
            groupBoxPerson.Controls.Add(label1);
            groupBoxPerson.Location = new Point(213, 12);
            groupBoxPerson.Margin = new Padding(4, 3, 4, 3);
            groupBoxPerson.Name = "groupBoxPerson";
            groupBoxPerson.Padding = new Padding(4, 3, 4, 3);
            groupBoxPerson.Size = new Size(558, 371);
            groupBoxPerson.TabIndex = 0;
            groupBoxPerson.TabStop = false;
            groupBoxPerson.Text = "تراکنش";
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { CategoryName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategory.Location = new Point(4, 19);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategory.Size = new Size(180, 346);
            dgvCategory.TabIndex = 1;
            dgvCategory.CellClick += dgvCategory_CellClick;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "Name";
            CategoryName.HeaderText = "نام دسته بندی";
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // txtAccountType
            // 
            txtAccountType.Location = new Point(191, 109);
            txtAccountType.Margin = new Padding(4, 3, 4, 3);
            txtAccountType.Name = "txtAccountType";
            txtAccountType.Size = new Size(259, 23);
            txtAccountType.TabIndex = 17;
            txtAccountType.TextChanged += txtAccountType_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 112);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 16;
            label5.Text = "نوع حساب:";
            // 
            // txtTransactionCategory
            // 
            txtTransactionCategory.Location = new Point(191, 68);
            txtTransactionCategory.Margin = new Padding(4, 3, 4, 3);
            txtTransactionCategory.Name = "txtTransactionCategory";
            txtTransactionCategory.Size = new Size(259, 23);
            txtTransactionCategory.TabIndex = 15;
            txtTransactionCategory.TextChanged += txtTransactionCategory_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 71);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 14;
            label4.Text = "دسته بندی:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(191, 201);
            txtAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(259, 23);
            txtAmount.TabIndex = 13;
            // 
            // rbPay
            // 
            rbPay.AutoSize = true;
            rbPay.Location = new Point(259, 155);
            rbPay.Name = "rbPay";
            rbPay.Size = new Size(60, 19);
            rbPay.TabIndex = 12;
            rbPay.TabStop = true;
            rbPay.Text = "پرداخت";
            rbPay.UseVisualStyleBackColor = true;
            // 
            // rbReceive
            // 
            rbReceive.AutoSize = true;
            rbReceive.Location = new Point(389, 155);
            rbReceive.Name = "rbReceive";
            rbReceive.Size = new Size(61, 19);
            rbReceive.TabIndex = 11;
            rbReceive.TabStop = true;
            rbReceive.Text = "دریافت";
            rbReceive.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(191, 244);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(259, 52);
            txtDescription.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Enabled = false;
            txtName.Location = new Point(191, 25);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(259, 23);
            txtName.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(514, 244);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(32, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "شرح:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 201);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "مبلغ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 157);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "نوع تراکنش:‌";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(481, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "طرف حساب:";
            // 
            // gbPerson
            // 
            gbPerson.Controls.Add(dgvAccount);
            gbPerson.Controls.Add(dgvCustomers);
            gbPerson.Controls.Add(txtFilter);
            gbPerson.Location = new Point(12, 12);
            gbPerson.Margin = new Padding(4, 3, 4, 3);
            gbPerson.Name = "gbPerson";
            gbPerson.Padding = new Padding(4, 3, 4, 3);
            gbPerson.Size = new Size(198, 371);
            gbPerson.TabIndex = 1;
            gbPerson.TabStop = false;
            gbPerson.Text = "اشخاص";
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Columns.AddRange(new DataGridViewColumn[] { AccountName });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvAccount.DefaultCellStyle = dataGridViewCellStyle5;
            dgvAccount.Location = new Point(5, 222);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvAccount.Size = new Size(189, 141);
            dgvAccount.TabIndex = 0;
            dgvAccount.CellClick += dgvAccount_CellClick;
            // 
            // AccountName
            // 
            AccountName.DataPropertyName = "Name";
            AccountName.HeaderText = "نوع حساب";
            AccountName.Name = "AccountName";
            AccountName.ReadOnly = true;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { FirstName });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle8;
            dgvCustomers.Location = new Point(5, 49);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvCustomers.Size = new Size(189, 167);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "نام شخص";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // txtFilter
            // 
            txtFilter.Cursor = Cursors.IBeam;
            txtFilter.Location = new Point(4, 19);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(190, 23);
            txtFilter.TabIndex = 0;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 389);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 421);
            Controls.Add(btnSave);
            Controls.Add(gbPerson);
            Controls.Add(groupBoxPerson);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddTransaction";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تراکنش جدید";
            Load += frmAddTransaction_Load;
            groupBoxPerson.ResumeLayout(false);
            groupBoxPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            gbPerson.ResumeLayout(false);
            gbPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPerson;
        private GroupBox gbPerson;
        private Button btnSave;
        private Label lblAddress;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtFilter;
        private TextBox txtName;
        private RadioButton rbReceive;
        private RadioButton rbPay;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn FirstName;
        private NumericUpDown txtAmount;
        private TextBox txtTransactionCategory;
        private Label label4;
        private TextBox txtAccountType;
        private Label label5;
        private DataGridView dgvAccount;
        private DataGridView dgvCategory;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn AccountName;
    }
}