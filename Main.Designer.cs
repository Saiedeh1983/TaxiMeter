namespace Taximeter
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCarInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcounting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOperation,
            this.mnuReports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuOperation
            // 
            this.mnuOperation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCarInfo,
            this.mnuService,
            this.mnuAcounting,
            this.mnuExit});
            this.mnuOperation.Name = "mnuOperation";
            this.mnuOperation.Size = new System.Drawing.Size(53, 20);
            this.mnuOperation.Text = "عمليات";
            // 
            // mnuCarInfo
            // 
            this.mnuCarInfo.Name = "mnuCarInfo";
            this.mnuCarInfo.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuCarInfo.Size = new System.Drawing.Size(152, 22);
            this.mnuCarInfo.Text = "تاکسي";
            // 
            // mnuService
            // 
            this.mnuService.Name = "mnuService";
            this.mnuService.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuService.Size = new System.Drawing.Size(152, 22);
            this.mnuService.Text = "خدمات";
            this.mnuService.Click += new System.EventHandler(this.mnuService_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "خروج";
            // 
            // mnuReports
            // 
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(49, 20);
            this.mnuReports.Text = "گزارش";
            // 
            // mnuAcounting
            // 
            this.mnuAcounting.Name = "mnuAcounting";
            this.mnuAcounting.Size = new System.Drawing.Size(152, 22);
            this.mnuAcounting.Text = "حسابداری";
            this.mnuAcounting.Click += new System.EventHandler(this.mnuAcounting_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(557, 294);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "تاکسيمتر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuOperation;
        private System.Windows.Forms.ToolStripMenuItem mnuCarInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuService;
        private System.Windows.Forms.ToolStripMenuItem mnuAcounting;
    }
}