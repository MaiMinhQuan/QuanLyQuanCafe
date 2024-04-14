using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int foodId, int count)
        {
            this.ID = id;
            this.BillId = billID;
            this.FoodId = foodId;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillId = (int)row["billID"];
            this.FoodId = (int)row["foodId"];
            this.Count = (int)row["count"];
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int foodId;

        public int FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }

        private int billId;

        public int BillId 
        {
            get { return billId; }
            set { billId = value; }
        }

        private int iD;

        public int ID
        {   
            get { return iD; } 
            set {  iD = value; } 
        }

        
    }
}
