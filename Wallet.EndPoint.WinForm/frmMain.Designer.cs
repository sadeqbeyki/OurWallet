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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            toolStripMain = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            editLoginItem = new ToolStripMenuItem();
            toolStripMain.SuspendLayout();
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
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 341);
            Controls.Add(toolStripMain);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "حسابداری";
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripMain;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem editLoginItem;
    }
}
