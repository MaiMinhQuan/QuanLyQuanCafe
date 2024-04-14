using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class Account
    {
        public Account(string username, string displayName, int type, string password = null)
        {
            this.Username = username;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.Username = row["username"].ToString();
            this.DisplayName = row["display_name"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["password"].ToString();
        }

        private string username;

        public string Username { get => username; set => username = value; }
        
        private string password;

        public string Password { get => password; set => password = value; }


        private string displayName;

        public string DisplayName { get => displayName; set => displayName = value; }

        private int type;

        public int Type { get => type; set => type = value; }
       
    }
}
