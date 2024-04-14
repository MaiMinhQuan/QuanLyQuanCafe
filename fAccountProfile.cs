using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public fAccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txbUsername.Text = loginAccount.Username;
            txbDisplayName.Text = loginAccount.DisplayName;



        }

        void UpdateAccountInfo()
        {
            string displayName = txbDisplayName.Text;
            string password = txbPassword.Text;
            string newPassword = txbNewPassword.Text;
            string reEnterPassword = txbReEnterPassword.Text;
            string username = txbUsername.Text;

            if (!newPassword.Equals(reEnterPassword)) 
            {
                MessageBox.Show("Mật khẩu nhập lại khác với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(username, displayName, password, newPassword))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công");
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUsername(username)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu");
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; } 
            remove { updateAccount -= value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
    }

    public class AccountEvent:EventArgs
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public AccountEvent(Account acc) 
        {
            this.Acc = acc;
        }
    }
}
