using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void GetAllStudent(DataGridView data)
        {
            data.DataSource =  DALStudent.Instance.GetAllStudent();
        }

        //public string AddHoSoSinhVien(string masv,
        //                            string hoten,
        //                            string gioitinh,
        //                            string dantoc,
        //                            DateTime ngaysinh,
        //                            string diachi,
        //                            string sdt,
        //                            string socccd,
        //                            string hotennt,
        //                            string quanhe,
        //                            DateTime ngaysinhnt,
        //                            string sdtnnt,
        //                            string malop,
        //                            string nienkhoa,
        //                            string hdt,
        //                            string namnhaphoc)
        //{
        //    Regex regex = new Regex(@"^[\p{L} ]+$");
        //    if (!regex.IsMatch(hoten))
        //    {
        //        return "Họ Tên Không Hợp Lệ";
        //    }
        //    DateTime a;
        //    if(DateTime.TryParse(ngaysinh, out a))

        //    return "";
        //}
    }
}
