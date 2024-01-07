using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BUS
{
    public class BUSClass
    {
        private static BUSClass _instance;
        public static BUSClass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSClass();
                }
                return _instance;
            }
            set => _instance = value;
        }

        public void GetAllLopHoc(ComboBox cbx)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALClass.Instance.GetAllLopHoc();
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;
        }
    }
}
