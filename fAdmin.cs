using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void LoadAccountList()
        {
            string query = "exec USP_GetAccountByUserName @username";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff" });
        }

        void LoadFoodList()
        {
            string query = "select * from Food";


            dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
