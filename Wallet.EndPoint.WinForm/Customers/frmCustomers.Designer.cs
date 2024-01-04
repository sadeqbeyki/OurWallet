namespace Wallet.EndPoint.WinForm.Customers
{
    partial class frmCustomers
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
            toolStripMenu = new ToolStrip();
            btnAddNewCustomer = new ToolStripButton();
            btnEditCustomer = new ToolStripButton();
            btnDeleteCustomer = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            searchLabel = new ToolStripLabel();
            txtFilter = new ToolStripTextBox();
            dgvCustomers = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // toolStripMenu
            // 
            toolStripMenu.Items.AddRange(new ToolStripItem[] { btnAddNewCustomer, btnEditCustomer, btnDeleteCustomer, btnRefresh, searchLabel, txtFilter });
            toolStripMenu.Location = new Point(0, 0);
            toolStripMenu.Name = "toolStripMenu";
            toolStripMenu.RightToLeft = RightToLeft.Yes;
            toolStripMenu.Size = new Size(824, 62);
            toolStripMenu.TabIndex = 0;
            toolStripMenu.Text = "toolStrip1";
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.Image = Properties.Resources._1371475930_filenew;
            btnAddNewCustomer.ImageScaling = ToolStripItemImageScaling.None;
            btnAddNewCustomer.ImageTransparentColor = Color.Magenta;
            btnAddNewCustomer.Name = "btnAddNewCustomer";
            btnAddNewCustomer.Size = new Size(80, 59);
            btnAddNewCustomer.Text = "افزودن شخص";
            btnAddNewCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddNewCustomer.Click += btnAddNewCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Image = Properties.Resources._1371475973_document_edit;
            btnEditCustomer.ImageScaling = ToolStripItemImageScaling.None;
            btnEditCustomer.ImageTransparentColor = Color.Magenta;
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(83, 59);
            btnEditCustomer.Text = "ویرایش شخص";
            btnEditCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Image = Properties.Resources._1371476007_Close_Box_Red;
            btnDeleteCustomer.ImageScaling = ToolStripItemImageScaling.None;
            btnDeleteCustomer.ImageTransparentColor = Color.Magenta;
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(72, 59);
            btnDeleteCustomer.Text = "حذف شخص";
            btnDeleteCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources._1371476342_Refresh;
            btnRefresh.ImageScaling = ToolStripItemImageScaling.None;
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(60, 59);
            btnRefresh.Text = "بروزرسانی";
            btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // searchLabel
            // 
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(41, 59);
            searchLabel.Text = "جستجو";
            // 
            // txtFilter
            // 
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(100, 62);
            txtFilter.TextChanged += Filter_TextChanged;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = SystemColors.AppWorkspace;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName, Mobile, Email, CreatedAt });
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.GridColor = SystemColors.ControlDark;
            dgvCustomers.Location = new Point(0, 62);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.Size = new Size(824, 299);
            dgvCustomers.TabIndex = 1;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "نام";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "نام خانوادگی";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Mobile
            // 
            Mobile.DataPropertyName = "Mobile";
            Mobile.HeaderText = "موبایل";
            Mobile.Name = "Mobile";
            Mobile.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "ایمیل";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // CreatedAt
            // 
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "تاریخ";
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 361);
            Controls.Add(dgvCustomers);
            Controls.Add(toolStripMenu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCustomers";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "لیست اشخاص";
            Load += frmCustomers_Load;
            toolStripMenu.ResumeLayout(false);
            toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripMenu;
        private ToolStripButton btnAddNewCustomer;
        private ToolStripButton btnEditCustomer;
        private ToolStripButton btnDeleteCustomer;
        private ToolStripButton btnRefresh;
        private ToolStripLabel searchLabel;
        private ToolStripTextBox txtFilter;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn CreatedAt;
    }
}