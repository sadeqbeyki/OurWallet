namespace Wallet.EndPoint.WinForm
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            toolStripMain = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            editLoginItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnCustomers = new ToolStripButton();
            btnAddTransaction = new ToolStripButton();
            btnReportExpense = new ToolStripButton();
            btnReportReceive = new ToolStripButton();
            gbMonthReport = new GroupBox();
            lblAccountBalance = new Label();
            lblExpense = new Label();
            lblReceive = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRefresh = new Button();
            statusStrip1 = new StatusStrip();
            lblTime = new ToolStripStatusLabel();
            lblDate = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            toolStripMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            gbMonthReport.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStripMain
            // 
            toolStripMain.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStripMain.Location = new Point(0, 0);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new Size(784, 25);
            toolStripMain.TabIndex = 0;
            toolStripMain.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { editLoginItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(63, 22);
            toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // editLoginItem
            // 
            editLoginItem.Name = "editLoginItem";
            editLoginItem.Size = new Size(180, 22);
            editLoginItem.Text = "تنظیمات ورود";
            editLoginItem.Click += editLoginItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCustomers, btnAddTransaction, btnReportExpense, btnReportReceive });
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCustomers
            // 
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageTransparentColor = Color.Magenta;
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(87, 22);
            btnCustomers.Text = "طرف حساب";
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Image = (Image)resources.GetObject("btnAddTransaction.Image");
            btnAddTransaction.ImageTransparentColor = Color.Magenta;
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(88, 22);
            btnAddTransaction.Text = "تراکنش جدید";
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // btnReportExpense
            // 
            btnReportExpense.Image = (Image)resources.GetObject("btnReportExpense.Image");
            btnReportExpense.ImageTransparentColor = Color.Magenta;
            btnReportExpense.Name = "btnReportExpense";
            btnReportExpense.Size = new Size(113, 22);
            btnReportExpense.Text = "گزارش پرداختی ها";
            btnReportExpense.Click += btnReportExpense_Click;
            // 
            // btnReportReceive
            // 
            btnReportReceive.Image = (Image)resources.GetObject("btnReportReceive.Image");
            btnReportReceive.ImageTransparentColor = Color.Magenta;
            btnReportReceive.Name = "btnReportReceive";
            btnReportReceive.Size = new Size(114, 22);
            btnReportReceive.Text = "گزارش دریافتی ها";
            btnReportReceive.Click += btnReportReceive_Click;
            // 
            // gbMonthReport
            // 
            gbMonthReport.Controls.Add(lblAccountBalance);
            gbMonthReport.Controls.Add(lblExpense);
            gbMonthReport.Controls.Add(lblReceive);
            gbMonthReport.Controls.Add(label3);
            gbMonthReport.Controls.Add(label2);
            gbMonthReport.Controls.Add(label1);
            gbMonthReport.Location = new Point(375, 77);
            gbMonthReport.Name = "gbMonthReport";
            gbMonthReport.Size = new Size(397, 173);
            gbMonthReport.TabIndex = 2;
            gbMonthReport.TabStop = false;
            gbMonthReport.Text = "گزارش این ماه";
            // 
            // lblAccountBalance
            // 
            lblAccountBalance.Location = new Point(6, 131);
            lblAccountBalance.Name = "lblAccountBalance";
            lblAccountBalance.Size = new Size(286, 23);
            lblAccountBalance.TabIndex = 5;
            lblAccountBalance.Text = "0";
            // 
            // lblExpense
            // 
            lblExpense.Location = new Point(6, 90);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(286, 23);
            lblExpense.TabIndex = 4;
            lblExpense.Text = "0";
            // 
            // lblReceive
            // 
            lblReceive.Location = new Point(6, 50);
            lblReceive.Name = "lblReceive";
            lblReceive.Size = new Size(286, 23);
            lblReceive.TabIndex = 3;
            lblReceive.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 131);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "مانده: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 90);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "پرداختی ها:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 50);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "دریافتی ها:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(375, 293);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "تازه سازی";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTime, lblDate });
            statusStrip1.Location = new Point(0, 319);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(118, 17);
            lblTime.Text = "toolStripStatusLabel1";
            // 
            // lblDate
            // 
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(118, 17);
            lblDate.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.narcissusDaffodilFlower;
            pictureBox1.Location = new Point(12, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 341);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(btnRefresh);
            Controls.Add(gbMonthReport);
            Controls.Add(toolStrip1);
            Controls.Add(toolStripMain);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "حسابداری";
            Load += frmMain_Load;
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gbMonthReport.ResumeLayout(false);
            gbMonthReport.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripMain;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem editLoginItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCustomers;
        private ToolStripButton btnAddTransaction;
        private ToolStripButton btnReportExpense;
        private ToolStripButton btnReportReceive;
        private GroupBox gbMonthReport;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblExpense;
        private Label lblReceive;
        private Label lblAccountBalance;
        private Button btnRefresh;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTime;
        private ToolStripStatusLabel lblDate;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}
