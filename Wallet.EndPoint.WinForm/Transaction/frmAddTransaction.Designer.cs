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
            groupBoxPerson = new GroupBox();
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
            dgvCustomers = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            txtFilter = new TextBox();
            btnSave = new Button();
            label4 = new Label();
            txtTransactionCategory = new TextBox();
            txtAccountType = new TextBox();
            label5 = new Label();
            groupBoxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            gbPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPerson
            // 
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
            // txtAmount
            // 
            txtAmount.Location = new Point(191, 201);
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
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { FirstName });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle11;
            dgvCustomers.Location = new Point(5, 49);
            dgvCustomers.Name = "dgvCustomers";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvCustomers.Size = new Size(189, 316);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "نام شخص";
            FirstName.Name = "FirstName";
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
            btnSave.Location = new Point(696, 389);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            // txtTransactionCategory
            // 
            txtTransactionCategory.Enabled = false;
            txtTransactionCategory.Location = new Point(191, 68);
            txtTransactionCategory.Margin = new Padding(4, 3, 4, 3);
            txtTransactionCategory.Name = "txtTransactionCategory";
            txtTransactionCategory.Size = new Size(259, 23);
            txtTransactionCategory.TabIndex = 15;
            // 
            // txtAccountType
            // 
            txtAccountType.Enabled = false;
            txtAccountType.Location = new Point(191, 109);
            txtAccountType.Margin = new Padding(4, 3, 4, 3);
            txtAccountType.Name = "txtAccountType";
            txtAccountType.Size = new Size(259, 23);
            txtAccountType.TabIndex = 17;
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
            // frmAddTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
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
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            gbPerson.ResumeLayout(false);
            gbPerson.PerformLayout();
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
    }
}