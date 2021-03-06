namespace Taximeter
{
    partial class Services
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaxiID = new System.Windows.Forms.TextBox();
            this.ExecuteDate = new System.Windows.Forms.MaskedTextBox();
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbStatuse = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comOperator = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RequestDate = new System.Windows.Forms.MaskedTextBox();
            this.RequestTime = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMorajeeDate = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOK1 = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnNew1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancel1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TahvilDatee = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comRequest = new System.Windows.Forms.ComboBox();
            this.grdRequests = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Box1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequests)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "درخواست";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاريخ تحويل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "شرح خدمات";
            // 
            // txtTaxiID
            // 
            this.txtTaxiID.AcceptsReturn = true;
            this.txtTaxiID.Location = new System.Drawing.Point(335, 16);
            this.txtTaxiID.Name = "txtTaxiID";
            this.txtTaxiID.Size = new System.Drawing.Size(115, 22);
            this.txtTaxiID.TabIndex = 1;
            // 
            // ExecuteDate
            // 
            this.ExecuteDate.Location = new System.Drawing.Point(7, 15);
            this.ExecuteDate.Mask = "0000/00/00";
            this.ExecuteDate.Name = "ExecuteDate";
            this.ExecuteDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExecuteDate.Size = new System.Drawing.Size(158, 22);
            this.ExecuteDate.TabIndex = 6;
            this.ExecuteDate.ValidatingType = typeof(System.DateTime);
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.txtDescription);
            this.Box1.Controls.Add(this.label9);
            this.Box1.Controls.Add(this.cmbStatuse);
            this.Box1.Controls.Add(this.btnSearch);
            this.Box1.Controls.Add(this.comOperator);
            this.Box1.Controls.Add(this.label8);
            this.Box1.Controls.Add(this.RequestDate);
            this.Box1.Controls.Add(this.RequestTime);
            this.Box1.Controls.Add(this.label3);
            this.Box1.Controls.Add(this.lblMorajeeDate);
            this.Box1.Controls.Add(this.toolStrip1);
            this.Box1.Controls.Add(this.TahvilDatee);
            this.Box1.Controls.Add(this.label6);
            this.Box1.Controls.Add(this.comRequest);
            this.Box1.Controls.Add(this.label5);
            this.Box1.Controls.Add(this.ExecuteDate);
            this.Box1.Controls.Add(this.txtTaxiID);
            this.Box1.Controls.Add(this.label1);
            this.Box1.Controls.Add(this.label2);
            this.Box1.Controls.Add(this.label4);
            this.Box1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.Location = new System.Drawing.Point(14, 1);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(550, 192);
            this.Box1.TabIndex = 14;
            this.Box1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(500, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 35;
            this.label9.Text = "وضعیت";
            // 
            // cmbStatuse
            // 
            this.cmbStatuse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatuse.FormattingEnabled = true;
            this.cmbStatuse.Items.AddRange(new object[] {
            "تحویل داده شد",
            "به تعویق افتاد",
            "مسترد شد "});
            this.cmbStatuse.Location = new System.Drawing.Point(292, 131);
            this.cmbStatuse.Name = "cmbStatuse";
            this.cmbStatuse.Size = new System.Drawing.Size(158, 22);
            this.cmbStatuse.TabIndex = 34;
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comOperator
            // 
            this.comOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comOperator.FormattingEnabled = true;
            this.comOperator.Location = new System.Drawing.Point(6, 73);
            this.comOperator.Name = "comOperator";
            this.comOperator.Size = new System.Drawing.Size(158, 22);
            this.comOperator.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 14);
            this.label8.TabIndex = 31;
            this.label8.Text = "اپراتور";
            // 
            // RequestDate
            // 
            this.RequestDate.BeepOnError = true;
            this.RequestDate.HidePromptOnLeave = true;
            this.RequestDate.Location = new System.Drawing.Point(292, 73);
            this.RequestDate.Mask = "0000/00/00";
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RequestDate.Size = new System.Drawing.Size(158, 22);
            this.RequestDate.TabIndex = 3;
            // 
            // RequestTime
            // 
            this.RequestTime.Location = new System.Drawing.Point(292, 103);
            this.RequestTime.Mask = "00:00";
            this.RequestTime.Name = "RequestTime";
            this.RequestTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RequestTime.Size = new System.Drawing.Size(158, 22);
            this.RequestTime.TabIndex = 4;
            this.RequestTime.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "ساعت مراجعه";
            // 
            // lblMorajeeDate
            // 
            this.lblMorajeeDate.AutoSize = true;
            this.lblMorajeeDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorajeeDate.Location = new System.Drawing.Point(474, 76);
            this.lblMorajeeDate.Name = "lblMorajeeDate";
            this.lblMorajeeDate.Size = new System.Drawing.Size(68, 14);
            this.lblMorajeeDate.TabIndex = 25;
            this.lblMorajeeDate.Text = "تاريخ مراجعه";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK1,
            this.btnEdit,
            this.btnNew1,
            this.btnCancel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 164);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOK1
            // 
            this.btnOK1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOK1.Image = global::Taximeter.Properties.Resources.tick;
            this.btnOK1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(44, 22);
            this.btnOK1.Text = "ثبت";
            this.btnOK1.Click += new System.EventHandler(this.btnOK1_Click_1);
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
            // 
            // btnNew1
            // 
            this.btnNew1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNew1.Image = global::Taximeter.Properties.Resources._new;
            this.btnNew1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew1.Name = "btnNew1";
            this.btnNew1.Size = new System.Drawing.Size(97, 22);
            this.btnNew1.Text = "درخواست جديد";
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
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::Taximeter.Properties.Resources.EDIT;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "ويرايش";
            // 
            // TahvilDatee
            // 
            this.TahvilDatee.Location = new System.Drawing.Point(6, 45);
            this.TahvilDatee.Mask = "0000/00/00";
            this.TahvilDatee.Name = "TahvilDatee";
            this.TahvilDatee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TahvilDatee.Size = new System.Drawing.Size(158, 22);
            this.TahvilDatee.TabIndex = 7;
            this.TahvilDatee.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "تاريخ انجام";
            // 
            // comRequest
            // 
            this.comRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comRequest.FormattingEnabled = true;
            this.comRequest.Location = new System.Drawing.Point(292, 45);
            this.comRequest.Name = "comRequest";
            this.comRequest.Size = new System.Drawing.Size(158, 22);
            this.comRequest.TabIndex = 2;
            // 
            // grdRequests
            // 
            this.grdRequests.AllowUserToAddRows = false;
            this.grdRequests.AllowUserToDeleteRows = false;
            this.grdRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdRequests.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdRequests.Location = new System.Drawing.Point(12, 199);
            this.grdRequests.MultiSelect = false;
            this.grdRequests.Name = "grdRequests";
            this.grdRequests.ReadOnly = true;
            this.grdRequests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdRequests.RowHeadersVisible = false;
            this.grdRequests.RowHeadersWidth = 10;
            this.grdRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRequests.Size = new System.Drawing.Size(550, 174);
            this.grdRequests.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 101);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(158, 52);
            this.txtDescription.TabIndex = 36;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(575, 383);
            this.Controls.Add(this.grdRequests);
            this.Controls.Add(this.Box1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Services";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "خدمات";
            this.Load += new System.EventHandler(this.Services_Load_1);
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaxiID;
        private System.Windows.Forms.MaskedTextBox ExecuteDate;
        private System.Windows.Forms.GroupBox Box1;
        private System.Windows.Forms.DataGridView grdRequests;
        private System.Windows.Forms.MaskedTextBox TahvilDatee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comRequest;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MaskedTextBox RequestDate;
        private System.Windows.Forms.MaskedTextBox RequestTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMorajeeDate;
        private System.Windows.Forms.ComboBox comOperator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnOK1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnCancel1;
        private System.Windows.Forms.ToolStripButton btnNew1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbStatuse;
        private System.Windows.Forms.TextBox txtDescription;
    }
}