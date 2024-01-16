using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBranch
    {
        private static DALBranch _instance;
        public static DALBranch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DALBranch();
                }
                return _instance;
            }
        }

        public DataTable GetAllBranchName()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT TENCHUYENNGANH FROM CHUYENNGANH";
            dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;

        }

        public DataTable GetIDByName(string name)
        {
            string query = "select MACHUYENNGANHNGANH from CHUYENNGANH where TENCHUYENNGANH = @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public DataTable GetAllBranh()
        {
            string query = "select MACHUYENNGANHNGANH as [Mã Chuyên Ngành], TENCHUYENNGANH [Tên Chuyên Ngành], MAKHOA  [Mã Khoa] from CHUYENNGANH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertBranch(string macn, string tencn)
        {
            string query = "USP_INSERT_CHUYENNGANH @MACHUYENNGANH , @TENCHUYENNGANH";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {macn, tencn});    
        }

        public DataTable GetBranchByID(string macn)
        {
            string query = "select * from CHUYENNGANH where MACHUYENNGANHNGANH = @macn";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { macn });
        }
        public DataTable GetBranchByName(string name)
        {
            string query = "select * from CHUYENNGANH where TenChuyenNganh = @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public int UpdateBranch(string macn, string tencn)
        {
            string query = "USP_UPDATE_CHUYENNGANH @MACHUYENNGANH , @TENCHUYENNGANH";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {macn, tencn});
        }

        public int DeleteBranch(string macn)
        {
            string query = "delete CHUYENNGANH where MACHUYENNGANHNGANH = @mcn";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { macn });
        }

        public DataTable FilterBranch(string column, string name)
        {
            string query = "USP_SearchBranch @SearchColumn , @SearchValue";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { column, name});
        }

    }
}
