﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAL
{
    public class DALAccount
    {
        private static DALAccount _instance;
        public static DALAccount Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DALAccount();
                }
                return _instance;
            }
        }

        public DataTable IsLogin(string username, string password)
        {
            string query = "USP_GetAccountsLogin @Username , @Password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password /*list*/});

            return result;
        }
            
        public int CreateAccount(string username, string password, string phonenumber)
        {
            if (GetAllUsername(username) == 0)
            {
                string query = "insert into TAIKHOAN(USERNAME, [PASSWORD], SODIENTHOAI) values ( @username , @password , @Sodienthoai )";
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, password, phonenumber });
            }
            else return -1;

        }

         int GetAllUsername(string username)
        {
            string query = "select count(*) from TaiKhoan where USERNAME = '" + username + "'";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public DataTable GetPassword(string username, string phonenumber)
        {
            string query = "USP_ForgotPassword @Username , @PhoneNumber";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, phonenumber /*list*/});

            return result;
        }

        public DataTable GetAllUsernameByUS(string username)
        {
            string query = "select USERNAME from TAIKHOAN where username = @us";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {username});
        }

        public int UpdatePass(string us, string pass, string sdt)
        {
            string query = "CapNhatThongTinTaiKhoan @Username , @Password , @Sodienthoai ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { us, pass, sdt });
        }

        public DataTable GetAllUser()
        {
            string query = "select id, username, sodienthoai from TAIKHOAN";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int DeleteAccount(string us)
        {
            string query = "delete TAIKHOAN where USERname = @US";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { us });
        }

    }
}
