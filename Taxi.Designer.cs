namespace Taximeter
{
    partial class Taxi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTaxiInformation = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnServices = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OldNumber = new System.Windows.Forms.GroupBox();
            this.old_DownNumber = new System.Windows.Forms.TextBox();
            this.old_City = new System.Windows.Forms.ComboBox();
            this.old_UpNumber = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoNewVersion = new System.Windows.Forms.RadioButton();
            this.rdoOldVersion = new System.Windows.Forms.RadioButton();
            this.NewNumber = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.new_CityCode = new System.Windows.Forms.ComboBox();
            this.new_MidleChar = new System.Windows.Forms.ComboBox();
            this.new_LeftNumber = new System.Windows.Forms.TextBox();
            this.new_RigthNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comOffice = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comCarOrganization = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comCarType = new System.Windows.Forms.ComboBox();
            this.comCarColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDriverFamily = new System.Windows.Forms.TextBox();
            this.txtTaxiCode = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.grdRequests = new System.Windows.Forms.DataGridView();
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comOperator = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RequestDate = new System.Windows.Forms.MaskedTextBox();
            this.RequestTime = new System.Windows.Forms.MaskedTextBox();
            this.ComStatus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMorajeeDate = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnOK1 = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnNew1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancel1 = new System.Windows.Forms.ToolStripButton();
            this.TahvilDatee = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comRequest = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ExecuteDate = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxiID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabTaxiInformation.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.OldNumber.SuspendLayout();
            this.NewNumber.SuspendLayout();
            this.tabServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequests)).BeginInit();
            this.Box1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTaxiInformation);
            this.tabControl1.Controls.Add(this.tabServices);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(572, 286);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabTaxiInformation
            // 
            this.tabTaxiInformation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabTaxiInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTaxiInformation.Controls.Add(this.toolStrip1);
            this.tabTaxiInformation.Controls.Add(this.groupBox1);
            this.tabTaxiInformation.Location = new System.Drawing.Point(4, 23);
            this.tabTaxiInformation.Name = "tabTaxiInformation";
            this.tabTaxiInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaxiInformation.Size = new System.Drawing.Size(564, 259);
            this.tabTaxiInformation.TabIndex = 0;
            this.tabTaxiInformation.Text = "اطلاعات تاکسي";
            this.tabTaxiInformation.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnServices,
            this.btnNew,
            this.btnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 227);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnServices
            // 
            this.btnServices.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnServices.Image = global::Taximeter.Properties.Resources.EDIT;
            this.btnServices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(70, 22);
            this.btnServices.Text = " خدمات   ";
            // 
            // btnNew
            // 
            this.btnNew.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNew.Image = global::Taximeter.Properties.Resources._new;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(58, 22);
            this.btnNew.Text = "جديد   ";
            // 
            // btnCancel
            // 
            this.btnCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Image = global::Taximeter.Properties.Resources.delete;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 22);
            this.btnCancel.Text = "خروج   ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OldNumber);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoNewVersion);
            this.groupBox1.Controls.Add(this.rdoOldVersion);
            this.groupBox1.Controls.Add(this.NewNumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comOffice);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comCarOrganization);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comCarType);
            this.groupBox1.Controls.Add(this.comCarColor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDriverFamily);
            this.groupBox1.Controls.Add(this.txtTaxiCode);
            this.groupBox1.Controls.Add(this.txtDriverName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(494, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات خودروها";
            // 
            // OldNumber
            // 
            this.OldNumber.Controls.Add(this.old_DownNumber);
            this.OldNumber.Controls.Add(this.old_City);
            this.OldNumber.Controls.Add(this.old_UpNumber);
            this.OldNumber.Location = new System.Drawing.Point(265, 76);
            this.OldNumber.Margin = new System.Windows.Forms.Padding(1);
            this.OldNumber.Name = "OldNumber";
            this.OldNumber.Size = new System.Drawing.Size(151, 74);
            this.OldNumber.TabIndex = 5;
            this.OldNumber.TabStop = false;
            // 
            // old_DownNumber
            // 
            this.old_DownNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.old_DownNumber.Location = new System.Drawing.Point(6, 39);
            this.old_DownNumber.MaxLength = 2;
            this.old_DownNumber.Name = "old_DownNumber";
            this.old_DownNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.old_DownNumber.Size = new System.Drawing.Size(49, 22);
            this.old_DownNumber.TabIndex = 41;
            this.old_DownNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // old_City
            // 
            this.old_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.old_City.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.old_City.FormattingEnabled = true;
            this.old_City.Items.AddRange(new object[] {
            "تهران"});
            this.old_City.Location = new System.Drawing.Point(61, 39);
            this.old_City.Name = "old_City";
            this.old_City.Size = new System.Drawing.Size(82, 22);
            this.old_City.TabIndex = 40;
            // 
            // old_UpNumber
            // 
            this.old_UpNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.old_UpNumber.Location = new System.Drawing.Point(6, 11);
            this.old_UpNumber.MaxLength = 8;
            this.old_UpNumber.Name = "old_UpNumber";
            this.old_UpNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.old_UpNumber.Size = new System.Drawing.Size(137, 22);
            this.old_UpNumber.TabIndex = 39;
            this.old_UpNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoCompleteCustomSource.AddRange(new string[] {
            "22",
            "33",
            "44",
            "55",
            "66",
            "77",
            "88",
            "99",
            "0912",
            "0932",
            "0935"});
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhone.Location = new System.Drawing.Point(282, 181);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhone.Size = new System.Drawing.Size(134, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 37;
            this.label2.Text = "تلفن";
            // 
            // rdoNewVersion
            // 
            this.rdoNewVersion.AutoSize = true;
            this.rdoNewVersion.Location = new System.Drawing.Point(312, 54);
            this.rdoNewVersion.Name = "rdoNewVersion";
            this.rdoNewVersion.Size = new System.Drawing.Size(50, 18);
            this.rdoNewVersion.TabIndex = 4;
            this.rdoNewVersion.Text = "جديد";
            this.rdoNewVersion.UseVisualStyleBackColor = true;
            // 
            // rdoOldVersion
            // 
            this.rdoOldVersion.AutoSize = true;
            this.rdoOldVersion.Checked = true;
            this.rdoOldVersion.Location = new System.Drawing.Point(368, 54);
            this.rdoOldVersion.Name = "rdoOldVersion";
            this.rdoOldVersion.Size = new System.Drawing.Size(48, 18);
            this.rdoOldVersion.TabIndex = 3;
            this.rdoOldVersion.TabStop = true;
            this.rdoOldVersion.Text = "قديم";
            this.rdoOldVersion.UseVisualStyleBackColor = true;
            // 
            // NewNumber
            // 
            this.NewNumber.Controls.Add(this.label10);
            this.NewNumber.Controls.Add(this.new_CityCode);
            this.NewNumber.Controls.Add(this.new_MidleChar);
            this.NewNumber.Controls.Add(this.new_LeftNumber);
            this.NewNumber.Controls.Add(this.new_RigthNumber);
            this.NewNumber.Location = new System.Drawing.Point(238, 76);
            this.NewNumber.Margin = new System.Windows.Forms.Padding(1);
            this.NewNumber.Name = "NewNumber";
            this.NewNumber.Size = new System.Drawing.Size(178, 71);
            this.NewNumber.TabIndex = 6;
            this.NewNumber.TabStop = false;
            this.NewNumber.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 14);
            this.label10.TabIndex = 50;
            this.label10.Text = "ايران";
            // 
            // new_CityCode
            // 
            this.new_CityCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.new_CityCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_CityCode.FormattingEnabled = true;
            this.new_CityCode.Items.AddRange(new object[] {
            "11",
            "22",
            "33",
            "44"});
            this.new_CityCode.Location = new System.Drawing.Point(6, 40);
            this.new_CityCode.Name = "new_CityCode";
            this.new_CityCode.Size = new System.Drawing.Size(49, 22);
            this.new_CityCode.TabIndex = 4;
            // 
            // new_MidleChar
            // 
            this.new_MidleChar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.new_MidleChar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.new_MidleChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.new_MidleChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_MidleChar.FormattingEnabled = true;
            this.new_MidleChar.Items.AddRange(new object[] {
            "الف",
            "ب",
            "پ",
            "ت",
            "ث",
            "ج",
            "چ",
            "ح",
            "خ",
            "د",
            "ذ",
            "ر",
            "ز",
            "ژ",
            "س",
            "ش",
            "ص",
            "ض",
            "ط",
            "ظ",
            "ع",
            "غ",
            "ف",
            "ق",
            "ک",
            "گ",
            "ل",
            "م",
            "ن",
            "و",
            "ه",
            "ي"});
            this.new_MidleChar.Location = new System.Drawing.Point(53, 12);
            this.new_MidleChar.Name = "new_MidleChar";
            this.new_MidleChar.Size = new System.Drawing.Size(62, 22);
            this.new_MidleChar.TabIndex = 2;
            // 
            // new_LeftNumber
            // 
            this.new_LeftNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_LeftNumber.Location = new System.Drawing.Point(6, 12);
            this.new_LeftNumber.MaxLength = 2;
            this.new_LeftNumber.Name = "new_LeftNumber";
            this.new_LeftNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.new_LeftNumber.Size = new System.Drawing.Size(41, 22);
            this.new_LeftNumber.TabIndex = 1;
            this.new_LeftNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_RigthNumber
            // 
            this.new_RigthNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_RigthNumber.Location = new System.Drawing.Point(121, 12);
            this.new_RigthNumber.MaxLength = 3;
            this.new_RigthNumber.Name = "new_RigthNumber";
            this.new_RigthNumber.Size = new System.Drawing.Size(49, 22);
            this.new_RigthNumber.TabIndex = 3;
            this.new_RigthNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 36;
            this.label9.Text = "شماره پلاک";
            // 
            // comOffice
            // 
            this.comOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comOffice.FormattingEnabled = true;
            this.comOffice.Location = new System.Drawing.Point(238, 21);
            this.comOffice.Name = "comOffice";
            this.comOffice.Size = new System.Drawing.Size(103, 22);
            this.comOffice.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = global::Taximeter.Properties.Resources.binoc;
            this.button1.Location = new System.Drawing.Point(238, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 22);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comCarOrganization
            // 
            this.comCarOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCarOrganization.FormattingEnabled = true;
            this.comCarOrganization.Location = new System.Drawing.Point(6, 22);
            this.comCarOrganization.Name = "comCarOrganization";
            this.comCarOrganization.Size = new System.Drawing.Size(149, 22);
            this.comCarOrganization.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 14);
            this.label8.TabIndex = 32;
            this.label8.Text = "شرکت";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 106);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(149, 97);
            this.txtDescription.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "شرح";
            // 
            // comCarType
            // 
            this.comCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCarType.FormattingEnabled = true;
            this.comCarType.Location = new System.Drawing.Point(6, 50);
            this.comCarType.MaxDropDownItems = 100;
            this.comCarType.Name = "comCarType";
            this.comCarType.Size = new System.Drawing.Size(149, 22);
            this.comCarType.Sorted = true;
            this.comCarType.TabIndex = 11;
            // 
            // comCarColor
            // 
            this.comCarColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCarColor.FormattingEnabled = true;
            this.comCarColor.Location = new System.Drawing.Point(6, 78);
            this.comCarColor.Name = "comCarColor";
            this.comCarColor.Size = new System.Drawing.Size(149, 22);
            this.comCarColor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "نوع خودرو";
            // 
            // txtDriverFamily
            // 
            this.txtDriverFamily.Location = new System.Drawing.Point(197, 153);
            this.txtDriverFamily.Name = "txtDriverFamily";
            this.txtDriverFamily.Size = new System.Drawing.Size(134, 22);
            this.txtDriverFamily.TabIndex = 8;
            // 
            // txtTaxiCode
            // 
            this.txtTaxiCode.Location = new System.Drawing.Point(347, 22);
            this.txtTaxiCode.MaxLength = 4;
            this.txtTaxiCode.Name = "txtTaxiCode";
            this.txtTaxiCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTaxiCode.Size = new System.Drawing.Size(69, 22);
            this.txtTaxiCode.TabIndex = 2;
            this.txtTaxiCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(337, 153);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(79, 22);
            this.txtDriverName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "رنگ خودرو";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "طرح پلاک";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "کد تاکسي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "نام خانوادگي";
            // 
            // tabServices
            // 
            this.tabServices.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabServices.Controls.Add(this.grdRequests);
            this.tabServices.Controls.Add(this.Box1);
            this.tabServices.Location = new System.Drawing.Point(4, 23);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(564, 259);
            this.tabServices.TabIndex = 1;
            this.tabServices.Text = "خدمات";
            this.tabServices.UseVisualStyleBackColor = true;
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
            this.grdRequests.Location = new System.Drawing.Point(8, 209);
            this.grdRequests.MultiSelect = false;
            this.grdRequests.Name = "grdRequests";
            this.grdRequests.ReadOnly = true;
            this.grdRequests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdRequests.RowHeadersVisible = false;
            this.grdRequests.RowHeadersWidth = 10;
            this.grdRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRequests.Size = new System.Drawing.Size(550, 174);
            this.grdRequests.TabIndex = 16;
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.btnSearch);
            this.Box1.Controls.Add(this.comOperator);
            this.Box1.Controls.Add(this.label11);
            this.Box1.Controls.Add(this.RequestDate);
            this.Box1.Controls.Add(this.RequestTime);
            this.Box1.Controls.Add(this.ComStatus);
            this.Box1.Controls.Add(this.label12);
            this.Box1.Controls.Add(this.label13);
            this.Box1.Controls.Add(this.lblMorajeeDate);
            this.Box1.Controls.Add(this.toolStrip2);
            this.Box1.Controls.Add(this.TahvilDatee);
            this.Box1.Controls.Add(this.label14);
            this.Box1.Controls.Add(this.comRequest);
            this.Box1.Controls.Add(this.txtDesc);
            this.Box1.Controls.Add(this.label15);
            this.Box1.Controls.Add(this.ExecuteDate);
            this.Box1.Controls.Add(this.txtTaxiID);
            this.Box1.Controls.Add(this.label16);
            this.Box1.Controls.Add(this.label17);
            this.Box1.Controls.Add(this.label18);
            this.Box1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.Location = new System.Drawing.Point(8, 6);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(550, 197);
            this.Box1.TabIndex = 15;
            this.Box1.TabStop = false;
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
            // comOperator
            // 
            this.comOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comOperator.FormattingEnabled = true;
            this.comOperator.Location = new System.Drawing.Point(6, 73);
            this.comOperator.Name = "comOperator";
            this.comOperator.Size = new System.Drawing.Size(158, 22);
            this.comOperator.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(215, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 14);
            this.label11.TabIndex = 31;
            this.label11.Text = "اپراتور";
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
            // ComStatus
            // 
            this.ComStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComStatus.FormattingEnabled = true;
            this.ComStatus.Items.AddRange(new object[] {
            "تحویل داده شد",
            "به تعویق افتاد",
            "مسترد شد "});
            this.ComStatus.Location = new System.Drawing.Point(292, 131);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.Size = new System.Drawing.Size(158, 22);
            this.ComStatus.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(462, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 14);
            this.label12.TabIndex = 26;
            this.label12.Text = "ساعت مراجعه";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(473, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 14);
            this.label13.TabIndex = 27;
            this.label13.Text = "وضعیت تحویل";
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
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK1,
            this.btnEdit,
            this.btnNew1,
            this.btnCancel1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 169);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(544, 25);
            this.toolStrip2.TabIndex = 15;
            this.toolStrip2.Text = "toolStrip2";
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
            this.btnNew1.Click += new System.EventHandler(this.btnNew1_Click_1);
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
            // TahvilDatee
            // 
            this.TahvilDatee.Location = new System.Drawing.Point(6, 44);
            this.TahvilDatee.Mask = "0000/00/00";
            this.TahvilDatee.Name = "TahvilDatee";
            this.TahvilDatee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TahvilDatee.Size = new System.Drawing.Size(158, 22);
            this.TahvilDatee.TabIndex = 7;
            this.TahvilDatee.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(190, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 14);
            this.label14.TabIndex = 11;
            this.label14.Text = "تاريخ انجام";
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
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(7, 101);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(158, 52);
            this.txtDesc.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(178, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 14);
            this.label15.TabIndex = 4;
            this.label15.Text = "شرح خدمات";
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
            // txtTaxiID
            // 
            this.txtTaxiID.AcceptsReturn = true;
            this.txtTaxiID.Enabled = false;
            this.txtTaxiID.Location = new System.Drawing.Point(335, 16);
            this.txtTaxiID.Name = "txtTaxiID";
            this.txtTaxiID.Size = new System.Drawing.Size(115, 22);
            this.txtTaxiID.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(454, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 14);
            this.label16.TabIndex = 0;
            this.label16.Text = "شناسه تاکسي";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(486, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 14);
            this.label17.TabIndex = 1;
            this.label17.Text = "درخواست";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(187, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 14);
            this.label18.TabIndex = 3;
            this.label18.Text = "تاريخ تحويل";
            // 
            // Taxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(572, 286);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Taxi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabTaxiInformation.ResumeLayout(false);
            this.tabTaxiInformation.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OldNumber.ResumeLayout(false);
            this.OldNumber.PerformLayout();
            this.NewNumber.ResumeLayout(false);
            this.NewNumber.PerformLayout();
            this.tabServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRequests)).EndInit();
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTaxiInformation;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox OldNumber;
        private System.Windows.Forms.TextBox old_DownNumber;
        private System.Windows.Forms.ComboBox old_City;
        private System.Windows.Forms.TextBox old_UpNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoNewVersion;
        private System.Windows.Forms.RadioButton rdoOldVersion;
        private System.Windows.Forms.GroupBox NewNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox new_CityCode;
        private System.Windows.Forms.ComboBox new_MidleChar;
        private System.Windows.Forms.TextBox new_LeftNumber;
        private System.Windows.Forms.TextBox new_RigthNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comOffice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comCarOrganization;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comCarType;
        private System.Windows.Forms.ComboBox comCarColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDriverFamily;
        private System.Windows.Forms.TextBox txtTaxiCode;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnServices;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.GroupBox Box1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comOperator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox RequestDate;
        private System.Windows.Forms.MaskedTextBox RequestTime;
        private System.Windows.Forms.ComboBox ComStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMorajeeDate;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnOK1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnNew1;
        private System.Windows.Forms.ToolStripButton btnCancel1;
        private System.Windows.Forms.MaskedTextBox TahvilDatee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comRequest;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox ExecuteDate;
        private System.Windows.Forms.TextBox txtTaxiID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView grdRequests;
    }
}