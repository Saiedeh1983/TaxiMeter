using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taximeter
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
            this.Load += new EventHandler(Services_Load);
            txtTaxiID.LostFocus += new EventHandler(txtTaxiID_LostFocus);
            txtTaxiID.KeyPress += new KeyPressEventHandler(txtTaxiID_KeyPress);
            btnOK1.Click += new EventHandler(btnOK1_Click);
            btnCancel1.Click += new EventHandler(btnCancel1_Click);
            grdRequests.CellDoubleClick +=new DataGridViewCellEventHandler(grdRequests_CellDoubleClick);
            btnNew1.Click += new EventHandler(btnNew1_Click);
            btnEdit.Click += new EventHandler(btnEdit_Click);
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
            //tranx.EditRequest
            //throw new Exception("The method or operation is not implemented.");
        }

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
                //comRequest.sele
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
            request.TaxiID = Convert.ToInt64(txtTaxiID.Text.Trim());
            request.ServiceID = Convert.ToInt32(comRequest.SelectedValue.ToString());
            request.RequestDate = CalDate(RequestDate.Text);
            request.RequestTime = RequestTime.Text;
            request.ExecuteDate = CalDate(ExecuteDate.Text);
            request.DeliveryDate = CalDate(ExecuteDate.Text);
            request.Operator = Convert.ToInt32(comOperator.SelectedValue);
            request.Description = txtDescription.Text;
            TaxiTransaction.tblRequests taxi = new TaxiTransaction.tblRequests();
            bool Result = taxi.AddRequest(request);
            if (Result)
            {
                MessageBox.Show("اطلاعات ثبت گرديد");
                grdRequests.DataSource = taxi.GetRequestByTaxiID(Convert.ToInt64(txtTaxiID.Text));
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
                TaxiTransaction.tblRequests request = new TaxiTransaction.tblRequests();
                DataTable dt = request.GetRequestByTaxiID(Convert.ToInt64(txtTaxiID.Text.Trim()));
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

        void Services_Load(object sender, EventArgs e)
        {
            if (txtTaxiID.Text != "")
            {
                txtTaxiID.Enabled = false;
                txtTaxiID.BackColor = Color.White;
            }
            LoadComboBox();
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
            grdRequests.Columns[3].Width =150;
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

        private void btnOK1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void Services_Load_1(object sender, EventArgs e)
        {

        }
    }
}