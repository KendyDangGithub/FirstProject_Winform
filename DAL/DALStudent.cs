using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DAL
{
    public class DALStudent
    {
        private static DALStudent _instance;
        public static DALStudent Instance
        {
            get
            {
                if( _instance == null)
                {
                   _instance = new DALStudent();
                }
                return _instance;
            }
        }

        public DataTable GetAllStudent()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("USP_ThongTinSinhVien");

            return data;
        }

        public DataTable GetStudentByID(string ID)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM v_SinhVien WHERE MASV = @ID";
            dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] {ID});
            return dataTable;
        }

        public int AddHoSoSinhVien(string masv,
                                    string hoten,
                                    string gioitinh,
                                    string dantoc,
                                    DateTime ngaysinh,
                                    string diachi,
                                    string sdt,
                                    string socccd,
                                    string hotennt,
                                    string quanhe,
                                    DateTime ngaysinhnt,
                                    string sdtnnt,
                                    string malop,
                                    string nienkhoa,
                                    string hdt,
                                    string namnhaphoc)
        {
            string query = "USP_AddHoSoSinhVien @MASV , @HOTEN , @GIOITINH , @DANTOC , @NGAYSINH , @DIACHI , @SDT , @SOCCCD , @HOTENNT , @QUANHE , @NGAYSINHNT , @SDTNT , @MALOP , @NIENKHOA , @HDT , @NAMNHAPHOC";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, socccd, hotennt, quanhe, ngaysinhnt, sdtnnt, malop, nienkhoa, hdt, namnhaphoc });
        }

        public int UpdateHoSoSinhVien(string masv,
                            string hoten,
                            string gioitinh,
                            string dantoc,
                            DateTime ngaysinh,
                            string diachi,
                            string sdt,
                            string socccd,
                            string hotennt,
                            string quanhe,
                            DateTime ngaysinhnt,
                            string sdtnnt,
                            string malop,
                            string nienkhoa,
                            string hdt,
                            string namnhaphoc)
        {
            string query = "USP_UPDATESTUDENT @MASV , @HOTEN , @GIOITINH , @DANTOC , @NGAYSINH , @DIACHI , @SDT , @SOCCCD , @HOTENNT , @QUANHE , @NGAYSINHNT , @SDTNT , @MALOP , @NIENKHOA , @HDT , @NAMNHAPHOC";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, socccd, hotennt, quanhe, ngaysinhnt, sdtnnt, malop, nienkhoa, hdt, namnhaphoc });
        }


        public int DeleteStudent(string ID)
        {
            string query = "USP_DELETESTUDENT @MASV";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
        }

        public DataTable FilterStudent(string columnname, string value)
        {
            string query = "USP_SEARCH_STUDENT @SearchColumn , @SearchValue";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { columnname, value });
            return dataTable;
        }
    }

}
