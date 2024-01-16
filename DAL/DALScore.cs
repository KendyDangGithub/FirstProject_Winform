using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALScore
    {

        private static DALScore _instance;
        public static DALScore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DALScore();
                }
                return _instance;
            }
        }

        public DataTable GetAllScore()
        {
            string query = "USP_GetAllScore";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public int InsertScore(float diem, int hocky, string masv, string mahocphan)
        {
            int result = 0;
            string query = "USP_InsertScore @DIEMTHI , @HOCKY , @MASINHVIEN , @MAHOCPHAN";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { diem, hocky, masv , mahocphan });
            return result;
        }

        public DataTable GetScoreSubject(string masv, string mahp)
        {
            string query = "select * from DIEMTHI where masv = @masv and MAHOCPHAN = @mahp ";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { masv, mahp });
            return dataTable;
        }

        public int UpdateScore(float diem, int hocky, string masv, string mahp)
        {
            int result = 0;
            string query = "USP_UpdateScore @DIEM , @HOCKY , @MASINHVIEN , @MAHOCPHAN";
            result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { diem, hocky, masv, mahp });
            return result;
        }
        public DataTable GetStudentByIDInScore(string ID)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM diemthi WHERE MASV = @ID";
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { ID });
            return dataTable;
        }

        public int DeleteScore(string mahp)
        {
            int result = 0;
            string query = "DELETE FROM DIEMTHI WHERE MAHOCPHAN = @MAHP";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {mahp});
            return result;
        }

        public DataTable FilterScore(string column, string value)
        {
            DataTable dataTable = new DataTable();
            string query = "USP_SearchScore @SearchColumn , @SearchValue";
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { column, value });
            return dataTable;
        }

        public DataTable SortASC()
        {
            string query = "select * from v_SearchByMonHoc order by diem";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SortDESC()
        {
            string query = "select * from v_SearchByMonHoc order by diem DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }



        //public void 
    }
}
