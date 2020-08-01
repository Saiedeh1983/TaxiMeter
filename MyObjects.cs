using System;
using System.Collections.Generic;
using System.Text;

namespace Taximeter
{
    public partial class MyObjects
    {
        public partial class Taxi
        {
            private string taxicode, carnumber,drivername,driverfamily,driverphone,description;
            private int taxiId, cartype,carcolor,organization;
            private bool carnumberVersion;

            public int TaxiID
            {
                get { return taxiId; }
                set { taxiId = value; }
            }
            
            public string TaxiCode
            {
                get { return taxicode; }
                set { taxicode = value; }
            }

            public bool CarNumberVersion
            {
                get { return carnumberVersion; }
                set { carnumberVersion = value; }
            }

            public string CarNumber
            {
                get { return carnumber; }
                set { carnumber = value; }
            }

            public int CarType
            {
                get { return cartype; }
                set { cartype = value; }
            }

            public int CarColor
            {
                get{ return carcolor; }
                set{ carcolor=value; }
            }

            public int Organization
            {
                get { return organization; }
                set { organization = value; }
            }

            public string DriverName
            {
                get { return drivername; }
                set { drivername = value; }
            }

            public string DriverFamily
            {
                get { return driverfamily; }
                set { driverfamily = value; }
            }

            public string DriverPhone
            {
                get { return driverphone; }
                set { driverphone = value; }
            }

            public string Description
            {
                get { return description; }
                set { description = value; }
            }
        }

        public partial class DetailInfo
        {
            int detailId, baseId;
            string detailtitle;

            public int DetailInfoID
            {
                get { return detailId; }
            }

            public string DetailInfoTitle
            {
                get { return detailtitle; }
                set { detailtitle = value; }
            }

            public int BaseInfoID
            {
                get { return baseId; }
                set { baseId = value; }
            }
        }

        public partial class Request
        {
            Int64 taxiId, requestId;
            bool isDone;
            int serviceId, userId, operator_;
            string requestTime, Status, description;
            DateTime requestDate, executeDate, deliveryDate, creationDate;

            public string Status1
            {
                get { return Status; }
                set { Status = value; }
            }

            public Int64 RequestID
            {
                get { return requestId; }
                set { requestId = value; }
            }
            
            public Int64 TaxiID
            {
                get { return taxiId; }
                set { taxiId = value; }
            }


            public int ServiceID
            {
                get { return serviceId; }
                set { serviceId = value; }
            }

            public DateTime RequestDate
            {
                get { return requestDate; }
                set { requestDate = value; }
            }

            public string RequestTime
            {
                get { return requestTime; }
                set { requestTime = value; }
            }

            public DateTime ExecuteDate
            {
                get { return executeDate; }
                set { executeDate = value; }
            }

            public DateTime DeliveryDate
            {
                get { return deliveryDate; }
                set { deliveryDate = value; }
            }

            public bool IsDone
            {
                get { return isDone; }
                set { isDone = value; }
            }

            public int Operator
            {
                get { return operator_; }
                set { operator_ = value; }
            }

            public string Description
            {
                get { return description; }
                set { description = value; }
            }

            public int UserID
            {
                get { return userId; }
                set { userId = value; }
            }

            public DateTime CreationDate
            {
                get { return creationDate; }
                set { creationDate = value; }
            }
        }

        public partial class Service
        {
            private Int64 serviceId;
            private string serviceTitle, description;
            decimal servicePrice;
            DateTime creationDate, expireDate;

            public Int64 ServiceID
            {
                get { return serviceId; }
                set { serviceId = value; }
            }

            public string ServiceTitle
            {
                get { return serviceTitle; }
                set { serviceTitle = value; }
            }

            public decimal ServicePrice
            {
                get { return servicePrice; }
                set { servicePrice = value; }
            }

            public DateTime CreationDate
            {
                get { return creationDate; }
                set { creationDate = value; }
            }

            public DateTime ExpireDate
            {
                get { return expireDate; }
                set { expireDate = value; }
            }

            public string Description
            {
                get { return description; }
                set { description = value; }
            }
        }

        public class Account
        {
            private int _PaymentID;
            private int _TaxiID;
            private string _Desc;
            private int _Payment;
            private int _Debt;
            private DateTime _Date;

            public DateTime Date
            {
                get { return _Date; }
                set { _Date = value; }
            }
            public int TaxiID
            {
                get { return _TaxiID; }
                set { _TaxiID = value; }
            }
            public int Debt
            {
                get { return _Debt; }
                set { _Debt = value; }
            }

            public int Payment
            {
                get { return _Payment; }
                set { _Payment = value; }
            } 

            public string Desc
            {
                get { return _Desc; }
                set { _Desc = value; }
            }

            public int PaymentID
            {
                get { return _PaymentID; }
                set { _PaymentID = value; }
            }
        }
    }
}
