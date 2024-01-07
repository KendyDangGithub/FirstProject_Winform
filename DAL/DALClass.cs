using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALClass
    {
        private static DALClass _instance;
        public static DALClass Instance
        {
            get
            {
                if( _instance == null )
                    _instance = new DALClass();
                return _instance;
            }
           
        }

        public DataTable GetAllLopHoc()
        {
            string query = "SELECT MALOP FROM LOP";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
    }
}
