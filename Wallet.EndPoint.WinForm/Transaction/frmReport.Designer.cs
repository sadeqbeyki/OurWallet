namespace Wallet.EndPoint.WinForm.Transaction
{
    partial class frmReport
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
        private async void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            toolStrip1 = new ToolStrip();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            btnPrint = new ToolStripButton();
            gbSearch = new GroupBox();
            txtToDate = new MaskedTextBox();
            txtFromDate = new MaskedTextBox();
            btnFilter = new Button();
            cbCustomer = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvReport = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CustomerId = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnEdit, btnDelete, btnRefresh, btnPrint });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(684, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnEdit
            // 
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(47, 35);
            btnEdit.Text = "ویرایش";
            btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(36, 35);
            btnDelete.Text = "حذف";
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(60, 35);
            btnRefresh.Text = "بروزرسانی";
            btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnPrint
            // 
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageTransparentColor = Color.Magenta;
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(32, 35);
            btnPrint.Text = "چاپ";
            btnPrint.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPrint.Click += btnPrint_Click;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(txtToDate);
            gbSearch.Controls.Add(txtFromDate);
            gbSearch.Controls.Add(btnFilter);
            gbSearch.Controls.Add(cbCustomer);
            gbSearch.Controls.Add(label3);
            gbSearch.Controls.Add(label2);
            gbSearch.Controls.Add(label1);
            gbSearch.Location = new Point(12, 41);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(660, 57);
            gbSearch.TabIndex = 1;
            gbSearch.TabStop = false;
            gbSearch.Text = "جستجو";
            // 
            // txtToDate
            // 
            txtToDate.Cursor = Cursors.IBeam;
            txtToDate.Location = new Point(105, 19);
            txtToDate.Mask = "0000/00/00";
            txtToDate.Name = "txtToDate";
            txtToDate.Size = new Size(100, 23);
            txtToDate.TabIndex = 8;
            // 
            // txtFromDate
            // 
            txtFromDate.Cursor = Cursors.IBeam;
            txtFromDate.Location = new Point(285, 19);
            txtFromDate.Mask = "0000/00/00";
            txtFromDate.Name = "txtFromDate";
            txtFromDate.Size = new Size(100, 23);
            txtFromDate.TabIndex = 7;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(6, 19);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "بیاب";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cbCustomer
            // 
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(457, 20);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(121, 23);
            cbCustomer.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 23);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "تا تاریخ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 23);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "از تاریخ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(584, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "طرف حساب:";
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Columns.AddRange(new DataGridViewColumn[] { Id, CustomerId, Amount, CreatedAt, Description });
            dgvReport.Location = new Point(12, 104);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.Size = new Size(660, 345);
            dgvReport.TabIndex = 9;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Column1";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // CustomerId
            // 
            CustomerId.DataPropertyName = "CustomerId";
            CustomerId.HeaderText = "طرف حساب";
            CustomerId.Name = "CustomerId";
            CustomerId.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "مبلغ";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // CreatedAt
            // 
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "تاریخ";
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "بابت";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(dgvReport);
            Controls.Add(gbSearch);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmReport";
            RightToLeft = RightToLeft.Yes;
            Text = "گزارش گیری";
            Load += frmReport_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDelete;
        private ToolStripButton btnRefresh;
        private ToolStripButton btnPrint;
        private GroupBox gbSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbCustomer;
        private Button btnFilter;
        private MaskedTextBox txtToDate;
        private MaskedTextBox txtFromDate;
        private DataGridView dgvReport;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn Description;
    }
}