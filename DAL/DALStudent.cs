using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //using(SqlConnection sqlconnection = new SqlConnection(ConnectionString.connectionString))
            //{
            //    sqlconnection.Open();
            //    string query = "USP_ThongTinSinhVien";
            //    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlconnection);
            //    adapter.Fill(data, "SinhVien");
            //    sqlconnection.Close();
            //}
            data = DataProvider.Instance.ExecuteQuery("USP_ThongTinSinhVien");


            return data;

            
        }
    }

}
