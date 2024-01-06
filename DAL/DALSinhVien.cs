using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSinhVien
    {
        private static DALSinhVien _instance;
        public static DALSinhVien Instance
        {
            get
            {
                if( _instance == null)
                {
                   _instance = new DALSinhVien();
                }
                return _instance;
            }
            set => _instance = value; 
        }

        public DataSet GetAllStudent()
        {
            DataSet data = new DataSet();
            using(SqlConnection sqlconnection = new SqlConnection(ConnectionString.connectionString))
            {
                sqlconnection.Open();
                string query = "USP_ThongTinSinhVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlconnection);
                adapter.Fill(data, "SinhVien");
                sqlconnection.Close();
            }
            return data;
        }
    }

}
