using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Taximeter
{
    public partial class TaxiTransaction
    {
        #region public partial class tblDetailInfo   
        public partial class tblDetailInfo
        {
            public DataTable GetDetailInfo()
            {
                string SqlStr = "SELECT * FROM tblDetailInfo";
                SqlConnection Cnn = new SqlConnection(ConfigurationSettings.AppSettings["Con"]);
                SqlDataAdapter Da = new SqlDataAdapter(SqlStr, Cnn);
                DataTable dt = new DataTable();
                Cnn.Open();
                Da.Fill(dt);
                return dt;
            }

            public DataTable GetDetailInfoByBaseInfoID(int BaseInfoID)
            {
                string SqlStr = "SELECT DetailInfoID, DetailInfoTitle " +
                    "FROM tblDetailInfo WHERE BaseInfoID=@BaseInfoID ORDER BY " +
                    "DetailInfoTitle ASC";
                SqlConnection Cnn = new SqlConnection(ConfigurationSettings.AppSettings["Con"]);
                SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                Cmd.Parameters.Add("@BaseInfoID", SqlDbType.Int).Value = BaseInfoID;
                SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Cnn.Open();
                Da.Fill(dt);
                return dt;
            }
            
            public bool InsertDetailInfo(MyObjects.DetailInfo detail)
            {
                string SqlStr = "INSERT INTO tblDetailInfo (DetailInfoTitle, " +
                    "BaseInfoID) VALUES(@DetailInfoTitle, @BaseInfoID)";
                try
                {
                    SqlConnection Cnn = new SqlConnection(ConfigurationSettings.AppSettings["Con"]);
                    SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                    Cmd.Parameters.Add("@DetailInfoTitle", SqlDbType.NVarChar, 50).Value = detail.DetailInfoTitle;
                    Cmd.Parameters.Add("@BaseInfoID", SqlDbType.Int).Value = detail.BaseInfoID;
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    return true;
                }
                catch { return false; }
            }
        }
        #endregion

        #region public partial class tblTaxiData   
        public partial class tblTaxiData
        {
            //string TaxiCode,string CarNumber,int CarType,int CarColor,
            //int TaxiOrganization,string DriverName,string DriverFamily,string Description
            public Int64 AddTaxi(MyObjects.Taxi taxi)
            {
                Int64 LastID = 0;
                string SqlStr = "INSERT INTO tblTaxiData (TaxiCode,CarNumberVersion,CarNumber," +
                    "CarType,CarColor,TaxiOrganization,DriverName,DriverFamily,DriverPhone," +
                    "Description) VALUES (@TaxiCode,@CarNumberVersion,@CarNumber,@CarType," +
                    "@CarColor,@TaxiOrganization,@DriverName,@DriverFamily,@DriverPhone," +
                    "@Description);" +
                    "SELECT SCOPE_IDENTITY() AS LastID";
                try
                {
                    SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                    SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                    if (taxi.TaxiCode != "")
                        Cmd.Parameters.Add("@TaxiCode", SqlDbType.NChar, 10).Value = taxi.TaxiCode;
                    else
                        Cmd.Parameters.Add("@TaxiCode", SqlDbType.NChar, 10).Value = DBNull.Value;
                    Cmd.Parameters.Add("@CarNumberVersion", SqlDbType.Bit).Value = taxi.CarNumberVersion;
                    Cmd.Parameters.Add("@CarNumber", SqlDbType.NChar, 15).Value = taxi.CarNumber;
                    Cmd.Parameters.Add("@CarType", SqlDbType.Int).Value = taxi.CarType;
                    Cmd.Parameters.Add("@CarColor", SqlDbType.Int).Value = taxi.CarColor;
                    Cmd.Parameters.Add("@TaxiOrganization", SqlDbType.Int).Value = taxi.Organization;
                    Cmd.Parameters.Add("@DriverName", SqlDbType.NVarChar, 25).Value = taxi.DriverName;
                    Cmd.Parameters.Add("@DriverFamily", SqlDbType.NVarChar, 40).Value = taxi.DriverFamily;
                    Cmd.Parameters.Add("@DriverPhone", SqlDbType.NVarChar, 50).Value = taxi.DriverPhone;
                    Cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = taxi.Description;
                    SqlDataReader Dr;
                    Cnn.Open();
                    Dr = Cmd.ExecuteReader();
                    Dr.Read();
                    if (Dr.HasRows)
                        LastID = Convert.ToInt64(Dr.GetValue(0));
                    Dr.Close();
                    Cnn.Close();
                    return LastID;
                }
                catch { return 0; }
            }

            public bool EditTaxi(MyObjects.Taxi taxi)
            {
                string SqlStr = "UPDATE tblTaxiData SET TaxiCode=@TaxiCode," +
                    "CarNumberVersion=@CarNumberVersion,CarNumber=@CarNumber," +
                    "CarType=@CarType,CarColor=@CarColor,TaxiOrganization=@TaxiOrganization," +
                    "DriverName=@DriverName,DriverFamily=@DriverFamily,DriverPhone=@DriverPhone," +
                    "Description=@Description WEHER TaxiID=@TaxiID";
                try
                {
                    SqlConnection Cnn = new SqlConnection(ConfigurationSettings.AppSettings["Con"]);
                    SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                    Cmd.Parameters.Add("@TaxiID", SqlDbType.BigInt).Value = taxi.TaxiID;
                    Cmd.Parameters.Add("@TaxiCode", SqlDbType.NChar, 10).Value = taxi.TaxiCode;
                    Cmd.Parameters.Add("@CarNumberVersion", SqlDbType.Bit).Value = taxi.CarNumberVersion;
                    Cmd.Parameters.Add("@CarNumber", SqlDbType.NChar, 15).Value = taxi.CarNumber;
                    Cmd.Parameters.Add("@CarType", SqlDbType.Int).Value = taxi.CarType;
                    Cmd.Parameters.Add("@CarColor", SqlDbType.Int).Value = taxi.CarColor;
                    Cmd.Parameters.Add("@TaxiOrganization", SqlDbType.Int).Value = taxi.Organization;
                    Cmd.Parameters.Add("@DriverName", SqlDbType.NVarChar, 25).Value = taxi.DriverName;
                    Cmd.Parameters.Add("@DriverFamily", SqlDbType.NVarChar, 40).Value = taxi.DriverFamily;
                    Cmd.Parameters.Add("DriverPhone", SqlDbType.NVarChar, 50).Value = taxi.DriverPhone;
                    Cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = taxi.Description;
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    return true;
                }
                catch { return false; }
            }

            public MyObjects.Taxi GetTaxiDataByTaxiID(int TaxiID)
            {
                MyObjects.Taxi taxi = new MyObjects.Taxi();
                string SqlStr = "SELECT * FROM tblTaxiData WHERE TaxiID=@TaxiID";
                SqlConnection Cnn = new SqlConnection(ConfigurationSettings.AppSettings["Con"]);
                SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                Cmd.Parameters.Add("@TaxiID", SqlDbType.BigInt).Value = TaxiID;
                SqlDataReader Dr;
                Cnn.Open();
                Dr = Cmd.ExecuteReader();
                Dr.Read();
                if (Dr.HasRows)
                {
                    taxi.TaxiCode = Dr.GetValue(1).ToString();
                    taxi.CarNumberVersion = Convert.ToBoolean(Dr.GetValue(2).ToString());
                    taxi.CarNumber = Dr.GetValue(3).ToString();
                    taxi.CarType = Convert.ToInt32(Dr.GetValue(4).ToString());
                    taxi.CarColor = Convert.ToInt32(Dr.GetValue(5).ToString());
                    taxi.Organization = Convert.ToInt32(Dr.GetValue(6).ToString());
                    taxi.DriverName = Dr.GetValue(7).ToString();
                    taxi.DriverFamily = Dr.GetValue(8).ToString();
                    taxi.Description = Dr.GetValue(9).ToString();
                }
                return taxi;    
            }
        }
        #endregion

        #region public partial class tblRequests   
        public partial class tblRequests
        {
            public DataTable GetRequestByRequestID(Int64 RequestID)
            {
                string SqlStr = "SELECT * FROM tblRequests WHERE RequestID=@RequestID";
                SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                Cmd.Parameters.Add("@ServiceID", SqlDbType.BigInt).Value = RequestID;
                SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Cnn.Open();
                Da.Fill(dt);
                return dt;
            }
            
            public DataTable GetRequestByServiceID(int ServiceID)
            {
                string SqlStr = "SELECT * FROM tblRequests WHERE ServiceID=@ServiceID";
                SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                Cmd.Parameters.Add("@ServiceID", SqlDbType.Int).Value = ServiceID;
                SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Cnn.Open();
                Da.Fill(dt);
                return dt;
            }

            public DataTable GetRequestByTaxiID(Int64 TaxiID)
            {
                string SqlStr = "SELECT R.RequestID,R.TaxiID,R.ServiceID,S.ServiceTitle," +
                    "R.RequestDate,R.RequestTime,R.ExecuteDate,R.DeliveryDate,R.IsDone," +
                    "R.Operator,R.Description,R.UserID,R.CreationDate,S.ServicePrice " +
                    "FROM tblRequests AS R INNER JOIN tblServices AS S ON R.ServiceID" +
                    "=S.ServiceID WHERE TaxiID=@TaxiID";
                SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                Cmd.Parameters.Add("@TaxiID", SqlDbType.BigInt).Value = TaxiID;
                SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Cnn.Open();
                Da.Fill(dt);
                return dt;
            }

            public bool AddRequest(MyObjects.Request request)
            {
                string SqlStr = "INSERT INTO tblRequests (TaxiID,ServiceID,RequestDate," +
                    "RequestTime,ExecuteDate,DeliveryDate,Operator,Description,Status) " +
                    "VALUES (@TaxiID,@ServiceID,@RequestDate,@RequestTime," +
                    "@ExecuteDate,@DeliveryDate,@Operator,@Description,@Status)";
                try
                {
                    SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                    SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                    Cmd.Parameters.Add("@TaxiID", SqlDbType.BigInt).Value = request.TaxiID; ;
                    Cmd.Parameters.Add("@ServiceID", SqlDbType.Int).Value = request.ServiceID;
                    Cmd.Parameters.Add("@RequestDate", SqlDbType.DateTime).Value = request.RequestDate;
                    Cmd.Parameters.Add("@RequestTime", SqlDbType.VarChar, 5).Value = request.RequestTime;
                    Cmd.Parameters.Add("@ExecuteDate", SqlDbType.DateTime).Value = request.ExecuteDate;
                    Cmd.Parameters.Add("@DeliveryDate", SqlDbType.DateTime).Value = request.DeliveryDate;
                    Cmd.Parameters.Add("@Operator", SqlDbType.Int).Value = request.Operator;
                    Cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = request.Description;
                    Cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50).Value = request.Status1;
                   
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    return true;
                }
                catch { return false; }
            }

            public bool EditRequest(MyObjects.Request request)
            {
                string SqlStr = "UPDATE tblRequests SET TaxiID=@TaxiID,ServiceID=@ServiceID," +
                    "RequestDate=@RequestDate,RequestTime=@RequestTime," +
                    "ExecuteDate=@ExecuteDate,DeliveryDate=@DeliveryDate,Operator=@Operator," +
                    "Description=@Description,Status=@Status WHERE ServiceID=@ServiceID";
                try
                {
                    SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                    SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                    Cmd.Parameters.Add("@ServiceID", SqlDbType.BigInt).Value = request.RequestID;
                    Cmd.Parameters.Add("@TaxiID", SqlDbType.BigInt).Value = request.TaxiID; ;
                    Cmd.Parameters.Add("@RequestID", SqlDbType.Int).Value = request.ServiceID;
                    Cmd.Parameters.Add("@RequestDate", SqlDbType.DateTime).Value = request.RequestDate;
                    Cmd.Parameters.Add("@RequestTime", SqlDbType.VarChar, 5).Value = request.RequestTime;
                    Cmd.Parameters.Add("@ExecuteDate", SqlDbType.DateTime).Value = request.ExecuteDate;
                    Cmd.Parameters.Add("@DeliveryDate", SqlDbType.DateTime).Value = request.DeliveryDate;
                    Cmd.Parameters.Add("@Operator", SqlDbType.Int).Value = request.Operator;
                    Cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = request.Description;
                    Cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50).Value = request.Status1;
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    return true;
                }
                catch { return false; }
            }
        }
        #endregion

        #region public partial class tblServices   
        public partial class tblServices
        {
            public DataTable GetServices()
            {
                string SqlStr = "SELECT * FROM tblServices";
                SqlConnection Cnn = new SqlConnection(ConfigurationSettings.AppSettings["Con"]);
                SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Cnn.Open();
                Da.Fill(dt);
                return dt;
            }
        }
        #endregion

        #region public partial class tblAccount
        public partial class tblAccount
        {
            public DataTable GetAccountByPaymentID(Int64 PaymentID)
            {
                string SqlStr = "SELECT * FROM tblAccount WHERE PaymentID=@PaymentID";
                SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                Cmd.Parameters.Add("@PaymentID", SqlDbType.BigInt).Value = PaymentID;
                SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Cnn.Open();
                Da.Fill(dt);
                return dt;
            }

            public DataTable GetAccountByTaxiID(Int64 TaxiID)
            {
                string SqlStr = "SELECT A.TaxiID,A.Payment,A.Debt,A.Date " +
                    "FROM tblAccount AS A INNER JOIN tblTaxiData AS T ON T.TaxiID" +
                    "=A.TaxiID WHERE TaxiID=@TaxiID";
                SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                Cmd.Parameters.Add("@TaxiID", SqlDbType.BigInt).Value = TaxiID;
                SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Cnn.Open();
                Da.Fill(dt);
                return dt;
            }

            public DataTable GetServicePriceByTaxiIDAndServiceID(Int64 TaxiID, Int64 ServiceID)
            {
                //string SqlStr = "SELECT R.RequestID,R.TaxiID,R.ServiceID,S.ServiceTitle," +
                //    "R.RequestDate,R.RequestTime,R.ExecuteDate,R.DeliveryDate,R.IsDone," +
                //    "R.Operator,R.Description,R.UserID,R.CreationDate,S.ServicePrice " +
                //    "FROM tblRequests AS R INNER JOIN tblServices AS S ON R.ServiceID" +
                //    "=S.ServiceID WHERE TaxiID=@TaxiID and ServiceID=@ServiceID";
                string SqlStr = "SELECT ServicePrice" +
                    "FROM tblRequests AS R INNER JOIN tblServices AS S ON R.ServiceID" +
                    "=S.ServiceID WHERE TaxiID=@TaxiID and ServiceID=@ServiceID";
                SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                Cmd.Parameters.Add("@TaxiID", SqlDbType.BigInt).Value = TaxiID;
                Cmd.Parameters.Add("@ServiceID", SqlDbType.BigInt).Value = ServiceID;
                SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Cnn.Open();
                Da.Fill(dt);
                return dt;
            }
            public bool AddAccount(MyObjects.Account account)
            {
                string SqlStr = "INSERT INTO tblAccount (PaymentID,TaxiID,Payment," +
                    "Debt,Date,Desc) " +
                    "VALUES (@PaymentID,@TaxiID,@Payment,@Debt," +
                    "@Date,@Desc)";
                try
                {
                    SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                    SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                    Cmd.Parameters.Add("@PaymentID", SqlDbType.Int).Value = account.PaymentID;
                    Cmd.Parameters.Add("@TaxiID", SqlDbType.Int).Value = account.TaxiID; ;
                    Cmd.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = account.Desc;
                    Cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = account.Date;
                    Cmd.Parameters.Add("@Debt", SqlDbType.Int, 50).Value = account.Debt;
                    Cmd.Parameters.Add("@Payment", SqlDbType.Int, 50).Value = account.Payment;
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    return true;
                }
                catch { return false; }
            }

            public bool EditAccount(MyObjects.Account account)
            {
                string SqlStr = "UPDATE tblAccount SET TaxiID=@TaxiID,PaymentID=@PaymentID," +
                    "Payment=@Payment,Debt=@Debt,Date=@Date,Desc=@Desc";
                    //" WHERE ServiceID=@ServiceID";
                try
                {
                    SqlConnection Cnn = new SqlConnection(ConfigurationManager.AppSettings["Con"]);
                    SqlCommand Cmd = new SqlCommand(SqlStr, Cnn);
                    Cmd.Parameters.Add("@PaymentID", SqlDbType.Int).Value = account.PaymentID;
                    Cmd.Parameters.Add("@TaxiID", SqlDbType.Int).Value = account.TaxiID; ;
                    Cmd.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = account.Desc;
                    Cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = account.Date;
                    Cmd.Parameters.Add("@Debt", SqlDbType.Int, 50).Value = account.Debt;
                    Cmd.Parameters.Add("@Payment", SqlDbType.Int, 50).Value = account.Payment;
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    return true;
                }
                catch { return false; }
            }
        }
        #endregion
    }
}
