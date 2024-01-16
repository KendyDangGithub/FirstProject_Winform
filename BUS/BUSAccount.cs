using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BUS
{
    public class BUSAccount
    {
        private static BUSAccount _instance;
        public static BUSAccount Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSAccount();
                }
                return _instance;
            }
        }

        public bool IsLogin(string username, string password)
        {
            return DALAccount.Instance.IsLogin(username, password).Rows.Count > 0;
        }

        public bool Createaccount(string username, string password, string phoneNumber)
        {
            return DALAccount.Instance.CreateAccount(username, password, phoneNumber) > 0;
        }

        public string GetPassword(string username, string phonenumber)
        {
            string getPassword = null;
            DataTable data = DALAccount.Instance.GetPassword(username, phonenumber);
            foreach (DataRow row in data.Rows)
            {
                if (username == row[1].ToString() && phonenumber == row[3].ToString())
                {
                    getPassword = row[2].ToString();
                }
            }
            return getPassword;
        }

        //public void GetAllUsername()
        //{
        //    List<string> classList = new List<string>();
        //    DataTable dataTable = DALClass.Instance.GetAllLopHoc();
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        classList.Add(row[0].ToString());
        //    }
        //    cbx.DataSource = classList;
        //}

        public string UpdateAccountPass(string username, string pass, string sdt)
        {
            if (DALAccount.Instance.GetAllUsernameByUS(username).Rows.Count == 0)
            {
                return "Username không Tồn Tại";
            }
            else
            {

                if (DALAccount.Instance.UpdatePass(username, pass, sdt) != 0)
                {
                    return "";
                }
                else
                {
                    return "Cập Nhật Không Thành Công";
                }


            }
        }

        public void GetAllUser(DataGridView datagird)
        {
            datagird.DataSource = DALAccount.Instance.GetAllUser();
        }

        public int DeleteAccount(string us)
        {
            return DALAccount.Instance.DeleteAccount(us);
        }


    }


}
