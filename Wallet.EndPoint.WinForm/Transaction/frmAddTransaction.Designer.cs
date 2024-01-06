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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            groupBoxPerson = new GroupBox();
            dgvCategory = new DataGridView();
            CategoryName = new DataGridViewTextBoxColumn();
            txtAccountType = new TextBox();
            label5 = new Label();
            txtTransactionCategory = new TextBox();
            label4 = new Label();
            txtAmount = new NumericUpDown();
            rbExpense = new RadioButton();
            rbIncome = new RadioButton();
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
            groupBoxPerson.Controls.Add(rbExpense);
            groupBoxPerson.Controls.Add(rbIncome);
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { CategoryName });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle11;
            dgvCategory.Location = new Point(4, 19);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            // rbExpense
            // 
            rbExpense.AutoSize = true;
            rbExpense.Location = new Point(259, 155);
            rbExpense.Name = "rbExpense";
            rbExpense.Size = new Size(60, 19);
            rbExpense.TabIndex = 12;
            rbExpense.TabStop = true;
            rbExpense.Text = "پرداخت";
            rbExpense.UseVisualStyleBackColor = true;
            // 
            // rbIncome
            // 
            rbIncome.AutoSize = true;
            rbIncome.Location = new Point(389, 155);
            rbIncome.Name = "rbIncome";
            rbIncome.Size = new Size(61, 19);
            rbIncome.TabIndex = 11;
            rbIncome.TabStop = true;
            rbIncome.Text = "دریافت";
            rbIncome.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Columns.AddRange(new DataGridViewColumn[] { AccountName });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvAccount.DefaultCellStyle = dataGridViewCellStyle14;
            dgvAccount.Location = new Point(5, 222);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Control;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { FirstName });
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Window;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle17;
            dgvCustomers.Location = new Point(5, 49);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
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
        private RadioButton rbIncome;
        private RadioButton rbExpense;
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