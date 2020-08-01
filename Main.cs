using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taximeter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            mnuCarInfo.Click += new EventHandler(mnuCarInfo_Click);
            mnuExit.Click += new EventHandler(mnuExit_Click);
            this.Load += new EventHandler(Main_Load);
        }

        void Main_Load(object sender, EventArgs e)
        {
            SqlConnection Cnn = new SqlConnection(ConfigurationSettings.AppSettings["Con"]);
            Cnn.Open();
            if (Cnn.State == ConnectionState.Open)
                Cnn.Close();
            else
                MessageBox.Show("The Connection is " + Cnn.State.ToString());
            //throw new Exception("The method or operation is not implemented.");
        }

        void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCarInfo_Click(object sender, EventArgs e)
        {
            Taxi taxi = new Taxi();
            taxi.MdiParent = this;
            taxi.Show();
        }

        private void mnuService_Click(object sender, EventArgs e)
        {
            Services service = new Services();
            //service.MdiParent = this;
            service.ShowDialog();
        }

        private void mnuAcounting_Click(object sender, EventArgs e)
        {
            Account acount = new Account();
            acount.MdiParent = this;
            acount.Show();
        }
    }
}