using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["date_check_in"];
            var dateCheckOutTemp = row["date_check_out"];
            if (dateCheckOutTemp.ToString() != "" ) 
            {
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            }
            
            this.Status = (int)row["status"];

            if (row["discount"].ToString() != "")
            {
                this.Discount = (int)row["discount"];
            }
            
        }

        private int status;

        public int Status
        {
            get { return status; }
            private set { status = value; }
        }

        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            private set { dateCheckOut = value; }
        }

        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            private set { dateCheckIn = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            private set { iD = value; }
        }

        

        private int discount;

        public int Discount { get => discount; set => discount = value; }
    }
}
