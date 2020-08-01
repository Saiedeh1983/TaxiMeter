namespace Taximeter
{
    partial class Account
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOK1 = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.lblMorajeeDate = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancel1 = new System.Windows.Forms.ToolStripButton();
            this.grdAccount = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ExecuteDate = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxiID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccount)).BeginInit();
            this.Box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK1
            // 
            this.btnOK1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOK1.Image = global::Taximeter.Properties.Resources.tick;
            this.btnOK1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(44, 22);
            this.btnOK1.Text = "ثبت";
            this.btnOK1.Click += new System.EventHandler(this.btnOK1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = global::Taximeter.Properties.Resources.EDIT;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 22);
            this.btnEdit.Text = "ويرايش";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblMorajeeDate
            // 
            this.lblMorajeeDate.AutoSize = true;
            this.lblMorajeeDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorajeeDate.Location = new System.Drawing.Point(181, 18);
            this.lblMorajeeDate.Name = "lblMorajeeDate";
            this.lblMorajeeDate.Size = new System.Drawing.Size(87, 14);
            this.lblMorajeeDate.TabIndex = 25;
            this.lblMorajeeDate.Text = "مجموع هزینه ها";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK1,
            this.btnEdit,
            this.btnNew1,
            this.btnCancel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 109);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew1
            // 
            this.btnNew1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNew1.Image = global::Taximeter.Properties.Resources._new;
            this.btnNew1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew1.Name = "btnNew1";
            this.btnNew1.Size = new System.Drawing.Size(97, 22);
            this.btnNew1.Text = "درخواست جديد";
            this.btnNew1.Click += new System.EventHandler(this.btnNew1_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel1.Image = global::Taximeter.Properties.Resources.EXITS2;
            this.btnCancel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(53, 22);
            this.btnCancel1.Text = "   خروج   ";
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // grdAccount
            // 
            this.grdAccount.AllowUserToAddRows = false;
            this.grdAccount.AllowUserToDeleteRows = false;
            this.grdAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAccount.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdAccount.Location = new System.Drawing.Point(7, 144);
            this.grdAccount.MultiSelect = false;
            this.grdAccount.Name = "grdAccount";
            this.grdAccount.ReadOnly = true;
            this.grdAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdAccount.RowHeadersVisible = false;
            this.grdAccount.RowHeadersWidth = 10;
            this.grdAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccount.Size = new System.Drawing.Size(547, 131);
            this.grdAccount.TabIndex = 17;
            this.grdAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccount_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "تاريخ ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(463, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 14);
            this.label7.TabIndex = 36;
            this.label7.Text = "مبلغ پرداختی";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(97, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 14);
            this.lblTotal.TabIndex = 35;
            this.lblTotal.Text = "0";
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.txtDesc);
            this.Box1.Controls.Add(this.label3);
            this.Box1.Controls.Add(this.lblDebt);
            this.Box1.Controls.Add(this.txtPayment);
            this.Box1.Controls.Add(this.label7);
            this.Box1.Controls.Add(this.lblTotal);
            this.Box1.Controls.Add(this.btnSearch);
            this.Box1.Controls.Add(this.lblMorajeeDate);
            this.Box1.Controls.Add(this.toolStrip1);
            this.Box1.Controls.Add(this.label6);
            this.Box1.Controls.Add(this.label5);
            this.Box1.Controls.Add(this.ExecuteDate);
            this.Box1.Controls.Add(this.txtTaxiID);
            this.Box1.Controls.Add(this.label1);
            this.Box1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.Location = new System.Drawing.Point(4, 1);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(550, 137);
            this.Box1.TabIndex = 16;
            this.Box1.TabStop = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(8, 69);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(157, 22);
            this.txtDesc.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "توضیجات";
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Location = new System.Drawing.Point(97, 47);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(14, 14);
            this.lblDebt.TabIndex = 38;
            this.lblDebt.Text = "0";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(293, 44);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(157, 22);
            this.txtPayment.TabIndex = 37;
            this.txtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayment_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoEllipsis = true;
            this.btnSearch.Location = new System.Drawing.Point(292, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 20);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "بدهی";
            // 
            // ExecuteDate
            // 
            this.ExecuteDate.Location = new System.Drawing.Point(293, 72);
            this.ExecuteDate.Mask = "0000/00/00";
            this.ExecuteDate.Name = "ExecuteDate";
            this.ExecuteDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExecuteDate.Size = new System.Drawing.Size(158, 22);
            this.ExecuteDate.TabIndex = 6;
            this.ExecuteDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtTaxiID
            // 
            this.txtTaxiID.AcceptsReturn = true;
            this.txtTaxiID.Location = new System.Drawing.Point(335, 16);
            this.txtTaxiID.Name = "txtTaxiID";
            this.txtTaxiID.Size = new System.Drawing.Size(115, 22);
            this.txtTaxiID.TabIndex = 1;
            this.txtTaxiID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxiID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه تاکسي";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 287);
            this.Controls.Add(this.grdAccount);
            this.Controls.Add(this.Box1);
            this.Name = "Account";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Account_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccount)).EndInit();
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnOK1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.Label lblMorajeeDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew1;
        private System.Windows.Forms.ToolStripButton btnCancel1;
        private System.Windows.Forms.DataGridView grdAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox Box1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox ExecuteDate;
        private System.Windows.Forms.TextBox txtTaxiID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
    }
}