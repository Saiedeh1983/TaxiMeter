using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taximeter
{
    
    public partial class Account : Form
    {
        MyObjects.Request request = new MyObjects.Request();
        TaxiTransaction.tblRequests tblrequests = new TaxiTransaction.tblRequests();
        TaxiTransaction.tblAccount account = new TaxiTransaction.tblAccount();
        long ServicesPrice = 0;
        public Account()
        {
            InitializeComponent();
        }

       
        private void Account_Load(object sender, EventArgs e)
        {
            Account account=new Account();
            TaxiTransaction.tblAccount tblAccount = new TaxiTransaction.tblAccount();
            btnCancel1.Click+=new EventHandler(btnCancel1_Click);
            btnEdit.Click+=new EventHandler(btnEdit_Click);
            btnNew1.Click+=new EventHandler(btnNew1_Click);
            btnOK1.Click+=new EventHandler(btnOK1_Click);
            if (txtTaxiID.Text != "")
            {
                txtTaxiID.Enabled = false;
                txtTaxiID.BackColor = Color.White;
            }
            //LoadComboBox();
            //grdAccount.DataSource = tblAccount.GetAccountByTaxiID(Convert.ToInt64(10111));
        }

        void LoadComboBox()
        {
            TaxiTransaction.tblDetailInfo detail = new TaxiTransaction.tblDetailInfo();
            TaxiTransaction.tblServices service = new TaxiTransaction.tblServices();
            DataTable dt1 = service.GetServices();
            //comRequest.DataSource = dt1;
            //comRequest.DisplayMember = "ServiceTitle";
            //comRequest.ValueMember = "ServiceID";

            //DataTable dt3 = detail.GetDetailInfoByBaseInfoID(6);
            //comOperator.DataSource = dt3;
            //comOperator.DisplayMember = "DetailInfoTitle";
            //comOperator.ValueMember = "DetailInfoID";
        }

        void GridStyle()
        {
            string date, value;
            grdAccount.Columns[0].Visible = false;
            grdAccount.Columns[1].Visible = false;
            grdAccount.Columns[2].Visible = false;
            grdAccount.Columns[3].HeaderText = "درخواست";
            grdAccount.Columns[3].Width = 150;
            grdAccount.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grdAccount.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grdAccount.Columns[4].HeaderText = "تاريخ درخواست";
            grdAccount.Columns[4].Width = 100;
            grdAccount.Columns[5].Visible = false;
            grdAccount.Columns[3].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            for (int count = 0; count < grdAccount.Rows.Count; count++)
            {
                value = grdAccount.Rows[count].Cells[4].Value.ToString();
                date = Convert.ToDateTime(value).ToShortDateString();
                date = CalPersianDate(date);
                grdAccount.Rows[count].Cells[4].Value = date;

                value = grdAccount.Rows[count].Cells[6].Value.ToString();
                date = Convert.ToDateTime(value).ToShortDateString();
                date = CalPersianDate(date);
                grdAccount.Rows[count].Cells[6].Value = date;
            }
        }
        string CalPersianDate(string mdate)
        {
            DateTime MDate = Convert.ToDateTime(mdate);
            CDate date = new CDate();
            string tt = date.GetPersianDate(MDate.ToShortDateString(), true, true);
            return tt;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            MyObjects.Account account = new MyObjects.Account();
            TaxiTransaction.tblAccount tblAccount = new TaxiTransaction.tblAccount();
            account.PaymentID = Convert.ToInt32(grdAccount.CurrentRow.Cells[0].Value.ToString());
            account.TaxiID = Convert.ToInt32(txtTaxiID.Text.ToString());
            account.Desc = txtDesc.Text.ToString();
            account.Payment = Convert.ToInt32(txtPayment.Text.ToString());
            account.Debt =Convert.ToInt32( lblDebt.Text);
            account.Date = CalDate(ExecuteDate.Text);
            bool Result = tblAccount.EditAccount(account);
            if (Result)
            {
                MessageBox.Show("اطلاعات ويرايش گرديد");
                grdAccount.DataSource = tblAccount.GetAccountByTaxiID(Convert.ToInt64(txtTaxiID.Text));
                GridStyle();
            }
            //tranx.EditRequest
            //throw new Exception("The method or operation is not implemented.");
        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            MyObjects.Account account = new MyObjects.Account();
            TaxiTransaction.tblAccount tblAccount = new TaxiTransaction.tblAccount();
            //account.PaymentID = Convert.ToInt32(grdAccount.CurrentRow.Cells[0].Value.ToString());
            account.TaxiID = Convert.ToInt32(txtTaxiID.Text.ToString());
            account.Desc =txtDesc.Text.ToString();
            account.Payment = Convert.ToInt32(txtPayment.Text.ToString());
            account.Debt = Convert.ToInt32(lblDebt.Text);
            account.Date = CalDate(ExecuteDate.Text);
            bool Result = tblAccount.AddAccount(account);
            if (Result)
            {
                MessageBox.Show("اطلاعات ثبت گرديد");
                grdAccount.DataSource = tblAccount.GetAccountByTaxiID(Convert.ToInt64(txtTaxiID.Text));
                GridStyle();
            }
        }

        private void grdAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEdit.Enabled = true;
                btnOK1.Enabled = false;
                //comRequest.sele
                txtTaxiID.Text = grdAccount.CurrentRow.Cells[1].Value.ToString();
                txtPayment.Text = grdAccount.CurrentRow.Cells[2].Value.ToString();
                lblDebt.Text = grdAccount.CurrentRow.Cells[3].Value.ToString();
                ExecuteDate.Text = grdAccount.CurrentRow.Cells[4].Value.ToString();
            }
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

        private void btnNew1_Click(object sender, EventArgs e)
        {
            btnOK1.Enabled = true;
            btnEdit.Enabled = false;
            txtPayment.Text = string.Empty;
            txtTaxiID.Text = string.Empty;
            txtDesc.Text = string.Empty;
            lblDebt.Text = string.Empty;
            label7.Text = string.Empty;            
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTaxiID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                if (SearchService())
                    txtPayment.Focus();
                else
                    txtTaxiID.Focus();
        }
        bool SearchService()
        {
            bool result = false;
            if (txtTaxiID.Text.Trim() != "")
            {
                TaxiTransaction.tblAccount account = new TaxiTransaction.tblAccount();
                DataTable dt = account.GetAccountByTaxiID(Convert.ToInt64(txtTaxiID.Text.Trim()));
                if (dt.Rows.Count > 0)
                {
                    grdAccount.DataSource = dt;
                    GridStyle();
                    grdAccount.Rows[0].Selected = false;
                    result = true;
                }
            }
            else
                result = false;
            return result;
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
                 DataTable dt =tblrequests.GetRequestByTaxiID(Convert.ToInt64(txtTaxiID.Text.Trim()));
                 grdAccount.DataSource = tblrequests.GetRequestByTaxiID(Convert.ToInt64(txtTaxiID.Text.Trim()));
                 if (dt.Rows.Count > 0)
                 {
                     for (int count = 0; count < grdAccount.Rows.Count; count++)
                     {
                         //long X = Convert.ToInt64(grdAccount.Rows[count].Cells[2].ToString());
                         //DataTable dt2 = account.GetServicePriceByTaxiIDAndServiceID(Convert.ToInt64(txtTaxiID.Text.Trim()), X);
                         //ServicesPrice += Convert.ToInt64(dt.Rows[count].ToString());
                         //value = grdAccount.Rows[count].Cells[4].Value.ToString();
                         //date = Convert.ToDateTime(value).ToShortDateString();
                         //date = CalPersianDate(date);
                         //grdAccount.Rows[count].Cells[4].Value = date;

                         //value = grdAccount.Rows[count].Cells[6].Value.ToString();
                         //date = Convert.ToDateTime(value).ToShortDateString();
                         //date = CalPersianDate(date);
                         //grdAccount.Rows[count].Cells[6].Value = date;
                     }

                     //for (int i = 0; i <= dt.Rows.Count; i++)
                     //{
                     //    DataTable dt2 = account.GetServicePriceByTaxiIDAndServiceID(Convert.ToInt64(txtTaxiID.Text.Trim()),Convert.ToInt64(dt.Rows[i].ToString()));
                     //    ServicesPrice += Convert.ToInt64(dt.Rows[i].ToString());
                     //}
                     lblTotal.Text = ServicesPrice.ToString();
                 }

        }
    }
}