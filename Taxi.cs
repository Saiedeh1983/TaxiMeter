using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taximeter
{
    public partial class Taxi : Form
    {
        public Taxi()
        {
            InitializeComponent();
            this.Load += new EventHandler(Taxi_Load);

            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
            btnServices.Click += new EventHandler(btnServices_Click);
            rdoOldVersion.CheckedChanged += new EventHandler(rdoOldVersion_CheckedChanged);
            txtTaxiCode.LostFocus += new EventHandler(txtTaxiCode_LostFocus);
            btnNew.Click += new EventHandler(btnNew_Click);
            comOffice.SelectedIndexChanged += new EventHandler(comOffice_SelectedIndexChanged);

            txtTaxiID.LostFocus += new EventHandler(txtTaxiID_LostFocus);
            txtTaxiID.KeyPress += new KeyPressEventHandler(txtTaxiID_KeyPress);
            btnOK1.Click += new EventHandler(btnOK1_Click);
            btnCancel1.Click += new EventHandler(btnCancel1_Click);
            grdRequests.CellDoubleClick += new DataGridViewCellEventHandler(grdRequests_CellDoubleClick);
            btnNew1.Click += new EventHandler(btnNew1_Click);
            btnEdit.Click += new EventHandler(btnEdit_Click);
        }

        void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    this.Width = 524;
                    this.Height = 308;
                    groupBox1.Width = 494;
                    groupBox1.Height = 215;
                    break;
                case 1:
                    this.Width = 583;
                    this.Height = 444;
                    Box1.Width = 550;
                    Box1.Height = 197;

                    if (txtTaxiID.Text != "")
                    {
                        txtTaxiID.Enabled = false;
                        txtTaxiID.BackColor = Color.White;
                    }
                    LoadComboBox();
                    break;
            }
            //throw new Exception("The method or operation is not implemented.");
        }

        #region Tab 0   
        void comOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comOffice.SelectedValue.ToString() == "23")
                txtTaxiCode.Enabled = false;
            else
                txtTaxiCode.Enabled = true;
        }

        void txtTaxiCode_LostFocus(object sender, EventArgs e)
        {
            txtTaxiCode.Text = txtTaxiCode.Text.Trim();
            //throw new Exception("The method or operation is not implemented.");
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            txtTaxiCode.Text = "";
            comOffice.SelectedIndex = 0;
            rdoOldVersion.Checked = true;
            old_UpNumber.Text = "";
            old_DownNumber.Text = "";
            old_City.SelectedIndex = 0;
            new_LeftNumber.Text = "";
            new_MidleChar.SelectedIndex = 0;
            new_RigthNumber.Text = "";
            new_CityCode.SelectedIndex = 0;
            txtDriverName.Text = "";
            txtDriverFamily.Text = "";
            txtPhone.Text = "";
            comCarOrganization.SelectedIndex = 0;
            comCarType.SelectedIndex = 0;
            comCarColor.SelectedIndex = 0;
            txtDescription.Text = "";
        }

        void rdoOldVersion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOldVersion.Checked)
            {
                OldNumber.Visible = true;
                NewNumber.Visible = false;
            }
            else
            {
                OldNumber.Visible = false;
                NewNumber.Visible = true;
            }
        }

        void btnServices_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            //txtTaxiID.Text = InsertTaxiData();
        }

        string InsertTaxiData()
        {
            long TaximeterID = 0;
            if ((txtTaxiCode.Text.Trim() != "" || txtTaxiCode.Enabled == false) && //old_UpNumber.Text.Trim() != "" &&
                txtDriverName.Text.Trim() != "" && txtDriverFamily.Text != "")
            {
                MyObjects.Taxi taxi = new MyObjects.Taxi();
                taxi.TaxiCode = txtTaxiCode.Text.Trim();
                taxi.CarNumberVersion = rdoNewVersion.Checked;
                taxi.CarNumber = MakeCarNumber(rdoOldVersion.Checked);
                taxi.Organization = Convert.ToInt32(comCarOrganization.SelectedValue);
                taxi.CarType = Convert.ToInt32(comCarType.SelectedValue);
                taxi.CarColor = Convert.ToInt32(comCarColor.SelectedValue);
                taxi.DriverName = txtDriverName.Text.Trim();
                taxi.DriverFamily = txtDriverFamily.Text.Trim();
                taxi.DriverPhone = txtPhone.Text.Trim();
                taxi.Description = txtDescription.Text.Trim();
                TaxiTransaction.tblTaxiData tr = new TaxiTransaction.tblTaxiData();
                TaximeterID = tr.AddTaxi(taxi);
                if (TaximeterID == 0)
                    MessageBox.Show("اشکال در ثبت", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("اطلاعات را بطور کامل ثبت نمائيد", "تذکر", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return TaximeterID.ToString();
            //throw new Exception("The method or operation is not implemented.");
        }

        string MakeCarNumber(bool IsOld)
        {
            string CarNumber;
            if (IsOld)
                CarNumber = old_UpNumber.Text.Trim() + "-" + old_City.SelectedIndex.ToString() +
                    "-" + old_DownNumber.Text.Trim();
            else
                CarNumber = new_LeftNumber.Text.Trim() + "-" + new_MidleChar.SelectedIndex.ToString() +
                    "-" + new_RigthNumber.Text.Trim() + "-" + new_CityCode.SelectedItem.ToString();
            return CarNumber;
        }

        void Taxi_Load(object sender, EventArgs e)
        {
            TaxiTransaction.tblDetailInfo detail = new TaxiTransaction.tblDetailInfo();
            DataTable dtCarType = detail.GetDetailInfoByBaseInfoID(1);
            comCarType.DataSource = dtCarType;
            comCarType.DisplayMember = "DetailInfoTitle";
            comCarType.ValueMember = "DetailInfoID";
            DataTable dtCarColor = detail.GetDetailInfoByBaseInfoID(2);
            comCarColor.DataSource = dtCarColor;
            comCarColor.DisplayMember = "DetailInfoTitle";
            comCarColor.ValueMember = "DetailInfoID";
            DataTable dtOrganization = detail.GetDetailInfoByBaseInfoID(3);
            comCarOrganization.DataSource = dtOrganization;
            comCarOrganization.DisplayMember = "DetailInfoTitle";
            comCarOrganization.ValueMember = "DetailInfoID";
            DataTable dtOffice = detail.GetDetailInfoByBaseInfoID(7);
            comOffice.DataSource = dtOffice;
            comOffice.DisplayMember = "DetailInfoTitle";
            comOffice.ValueMember = "DetailInfoID";

            string today = DateTime.Now.Date.ToShortDateString();
            string time = DateTime.Now.TimeOfDay.ToString();
            RequestDate.Text = CalPersianDate(today);
            RequestTime.Text = time;

            comOffice.Focus();
            //throw new Exception("The method or operation is not implemented.");
        }
        #endregion

        #region Tab 1   
        void btnNew1_Click(object sender, EventArgs e)
        {
            btnOK1.Enabled = true;
            btnEdit.Enabled = false;
            comRequest.SelectedIndex = 0;
            RequestDate.ResetText();
            RequestTime.ResetText();
            ExecuteDate.ResetText();
            TahvilDatee.ResetText();
            comOperator.SelectedIndex = 0;
            txtDescription.Text = "";
        }

        void grdRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEdit.Enabled = true;
                btnOK1.Enabled = false;
                RequestDate.Text = grdRequests.CurrentRow.Cells[4].Value.ToString();
                RequestTime.Text = grdRequests.CurrentRow.Cells[5].Value.ToString();
                ExecuteDate.Text = grdRequests.CurrentRow.Cells[6].Value.ToString();
                TahvilDatee.Text = grdRequests.CurrentRow.Cells[7].Value.ToString();
                txtDescription.Text = grdRequests.CurrentRow.Cells[10].Value.ToString();
            }
        }

        void txtTaxiID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                if (SearchService())
                    comRequest.Focus();
                else
                    txtTaxiID.Focus();
        }

        void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnOK1_Click(object sender, EventArgs e)
        {
            MyObjects.Request request = new MyObjects.Request();
            string taxiId = InsertTaxiData();
            request.TaxiID = Convert.ToInt64(taxiId);
            request.ServiceID = Convert.ToInt32(comRequest.SelectedValue.ToString());
            request.RequestDate = CalDate(RequestDate.Text);
            request.RequestTime = RequestTime.Text;
            request.ExecuteDate = CalDate(ExecuteDate.Text);
            request.DeliveryDate = CalDate(ExecuteDate.Text);
            request.Operator = Convert.ToInt32(comOperator.SelectedValue);
            request.Description = txtDesc.Text;
            request.Status1 = ComStatus.Text;
            TaxiTransaction.tblRequests taxi = new TaxiTransaction.tblRequests();
            bool Result = taxi.AddRequest(request);
            if (Result)
            {
                MessageBox.Show("اطلاعات تاکسي با کد" + " " + taxiId + " ثبت گرديد");
                grdRequests.DataSource = taxi.GetRequestByTaxiID(Convert.ToInt64(taxiId));
                GridStyle();
            }
            //throw new Exception("The method or operation is not implemented.");
        }

        void txtTaxiID_LostFocus(object sender, EventArgs e)
        {
            if (SearchService())
                comRequest.Focus();
            else
            {
                txtTaxiID.Text = "";
                comRequest.SelectedIndex = 0;
                RequestDate.ResetText();
                RequestTime.ResetText();
                ExecuteDate.ResetText();
                TahvilDatee.ResetText();
                comOperator.SelectedIndex = 0;
                txtDescription.Text = "";
                grdRequests.DataSource = "";
                txtTaxiID.Focus();
            }
        }

        bool SearchService()
        {
            bool result = false;
            if (txtTaxiID.Text.Trim() != "")
            {
                TaxiTransaction.tblRequests taxi = new TaxiTransaction.tblRequests();
                DataTable dt = taxi.GetRequestByTaxiID(Convert.ToInt64(txtTaxiID.Text.Trim()));
                if (dt.Rows.Count > 0)
                {
                    grdRequests.DataSource = dt;
                    GridStyle();
                    grdRequests.Rows[0].Selected = false;
                    result = true;
                }
            }
            else
                result = false;
            return result;
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            MyObjects.Request request = new MyObjects.Request();
            TaxiTransaction.tblRequests tranx = new TaxiTransaction.tblRequests();
            request.ServiceID = Convert.ToInt32(grdRequests.CurrentRow.Cells[0].Value.ToString());
            request.TaxiID = Convert.ToInt64(txtTaxiID.Text.Trim());
            request.RequestID = Convert.ToInt32(comRequest.SelectedValue.ToString());
            request.RequestDate = CalDate(RequestDate.Text);
            request.RequestTime = RequestTime.Text;
            request.ExecuteDate = CalDate(ExecuteDate.Text);
            request.DeliveryDate = CalDate(ExecuteDate.Text);
            request.Operator = Convert.ToInt32(comOperator.SelectedValue);
            request.Description = txtDescription.Text;
            bool Result = tranx.EditRequest(request);
            if (Result)
            {
                MessageBox.Show("اطلاعات ويرايش گرديد");
                grdRequests.DataSource = tranx.GetRequestByTaxiID(Convert.ToInt64(txtTaxiID.Text));
                GridStyle();
            }
            //throw new Exception("The method or operation is not implemented.");
        }

        void LoadComboBox()
        {
            TaxiTransaction.tblDetailInfo detail = new TaxiTransaction.tblDetailInfo();
            TaxiTransaction.tblServices service = new TaxiTransaction.tblServices();
            DataTable dt1 = service.GetServices();
            comRequest.DataSource = dt1;
            comRequest.DisplayMember = "ServiceTitle";
            comRequest.ValueMember = "ServiceID";

            DataTable dt3 = detail.GetDetailInfoByBaseInfoID(6);
            comOperator.DataSource = dt3;
            comOperator.DisplayMember = "DetailInfoTitle";
            comOperator.ValueMember = "DetailInfoID";
        }

        DateTime CalDate(string PersianDate)
        {
            CDate date = new CDate();
            int year = Convert.ToInt16(PersianDate.Substring(0, 4));
            int mon = Convert.ToInt16(PersianDate.Substring(5, 2));
            int day = Convert.ToInt16(PersianDate.Substring(8, 2));
            DateTime PDate = Convert.ToDateTime(date.GetMiladiDate(year, mon, day, true));
            return PDate;
        }

        string CalPersianDate(string mdate)
        {
            DateTime MDate = Convert.ToDateTime(mdate);
            CDate date = new CDate();
            string tt = date.GetPersianDate(MDate.ToShortDateString(), true, true);
            return tt;
        }

        void GridStyle()
        {
            string date, value;
            grdRequests.Columns[0].Visible = false;
            grdRequests.Columns[1].Visible = false;
            grdRequests.Columns[2].Visible = false;
            grdRequests.Columns[3].HeaderText = "درخواست";
            grdRequests.Columns[3].Width = 150;
            grdRequests.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grdRequests.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grdRequests.Columns[4].HeaderText = "تاريخ درخواست";
            grdRequests.Columns[4].Width = 100;
            grdRequests.Columns[5].Visible = false;
            grdRequests.Columns[6].HeaderText = "تاريخ اجرا";
            grdRequests.Columns[6].Width = 100;
            grdRequests.Columns[7].Visible = false;
            grdRequests.Columns[8].HeaderText = "تحويل";
            grdRequests.Columns[8].Width = 60;
            grdRequests.Columns[9].Visible = false;
            grdRequests.Columns[10].Visible = false;
            grdRequests.Columns[11].Visible = false;
            grdRequests.Columns[12].Visible = false;
            grdRequests.Columns[13].HeaderText = "هزينه";
            grdRequests.Columns[13].Width = 100;
            grdRequests.Columns[3].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            for (int count = 0; count < grdRequests.Rows.Count; count++)
            {
                value = grdRequests.Rows[count].Cells[4].Value.ToString();
                date = Convert.ToDateTime(value).ToShortDateString();
                date = CalPersianDate(date);
                grdRequests.Rows[count].Cells[4].Value = date;

                value = grdRequests.Rows[count].Cells[6].Value.ToString();
                date = Convert.ToDateTime(value).ToShortDateString();
                date = CalPersianDate(date);
                grdRequests.Rows[count].Cells[6].Value = date;
            }
        }
        #endregion

        private void btnNew1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnOK1_Click_1(object sender, EventArgs e)
        {
            MyObjects.Request request = new MyObjects.Request();
            string taxiId = InsertTaxiData();
            request.TaxiID = Convert.ToInt64(taxiId);
            request.ServiceID = Convert.ToInt32(comRequest.SelectedValue.ToString());
            request.RequestDate = CalDate(RequestDate.Text);
            request.RequestTime = RequestTime.Text;
            request.ExecuteDate = CalDate(ExecuteDate.Text);
            request.DeliveryDate = CalDate(ExecuteDate.Text);
            request.Operator = Convert.ToInt32(comOperator.SelectedValue);
            request.Description = txtDesc.Text;
            request.Status1 = ComStatus.Text;
            TaxiTransaction.tblRequests taxi = new TaxiTransaction.tblRequests();
            bool Result = taxi.AddRequest(request);
            if (Result)
            {
                MessageBox.Show("اطلاعات تاکسي با کد" + " " + taxiId + " ثبت گرديد");
                grdRequests.DataSource = taxi.GetRequestByTaxiID(Convert.ToInt64(taxiId));
                GridStyle();
            }
        }
    }
}