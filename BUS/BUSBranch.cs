using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSBranch
    {
        private static BUSBranch _instance;
        public static BUSBranch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSBranch();
                }
                return _instance;
            }
        }
        public void GetAllBranchName(ComboBox cbx)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALBranch.Instance.GetAllBranchName();
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;
        }
        public string GetIDByName(string name)
        {
            string result = "";
            DataTable dataTable = DALBranch.Instance.GetIDByName(name);

            foreach (DataRow row in dataTable.Rows)
            {
                result = row[0].ToString();
            }
            return result;
        }

        public void GetAllBranch(DataGridView datagrid)
        {
            datagrid.DataSource = DALBranch.Instance.GetAllBranh();
        }
        public string InsertBranch(string macn, string tencn)
        {
            if (DALBranch.Instance.GetBranchByID(macn).Rows.Count > 0)
            {
                return "Chuyên ngành Có Mã Này Đã Tồn Tại";
            }
            else
            {
                if (DALBranch.Instance.GetBranchByName(tencn).Rows.Count > 0)
                {
                    return "Chuyên ngành Có Tên Này Đã Tồn Tại";
                }
                else
                {
                    if (DALBranch.Instance.InsertBranch(macn, tencn) > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Thêm Không Thành Công";
                    }

                }
            }
        }

        public string UpdateBranch(string macn, string tencn)
        {
            if (DALBranch.Instance.GetBranchByID(macn).Rows.Count == 0)
            {
                return "Lớp Có Mã Này Không Tồn Tại Tồn Tại";
            }
            else
            {
                if (DALBranch.Instance.GetBranchByName(tencn).Rows.Count > 0)
                {
                    return "Lớp Có Tên Này Đã Tồn Tại";
                }
                else
                {
                    if (DALBranch.Instance.UpdateBranch(macn, tencn) != 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Cập Nhật Không Thành Công";
                    }

                }
            }
        }

        public int DeleteBranch(string macn)
        {
            return DALBranch.Instance.DeleteBranch(macn);
        }

        public void FilterBranch(DataGridView datagird, string column, string value)
        {
            datagird.DataSource = DALBranch.Instance.FilterBranch(column, value);
        }


    }
}

