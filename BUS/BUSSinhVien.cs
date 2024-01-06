using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSSinhVien
    {
        private static BUSSinhVien _instance;
        public static BUSSinhVien Instance
        {
            get
            {
                if( _instance == null)
                {
                    _instance = new BUSSinhVien();
                }
                return _instance;
            }
            set => _instance = value;
        }

        public DataSet GetAllStudent()
        {
            return DALSinhVien.Instance.GetAllStudent();
        }

    }
}
