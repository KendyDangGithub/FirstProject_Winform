using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSStudent
    {
        private static BUSStudent _instance;
        public static BUSStudent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSStudent();
                }
                return _instance;
            }
        }

        public void GetAllStudent(DataGridView data)
        {
            data.DataSource = DALStudent.Instance.GetAllStudent();
        }
        public DataTable GetAllStudent()
        {
            return DALStudent.Instance.GetAllStudent();

        }

        public string AddHoSoSinhVien(string masv,
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
                                    string sdtnt,
                                    string malop,
                                    string nienkhoa,
                                    string hdt,
                                    string namnhaphoc)
        {
            Regex regexString = new Regex(@"^[\p{L} ]+$");
            Regex regexNumber = new Regex("^[0-9]+$");
            if (!regexString.IsMatch(hoten))
            {
                return "Họ Tên Không Hợp Lệ";
            }

            if (!regexNumber.IsMatch(sdt) || !regexNumber.IsMatch(socccd) || !regexNumber.IsMatch(sdtnt))
            {
                return "Số Điện Thoại Hoặc Số CCCD Không Hợp Lệ";
            }
            if (DateTime.Now.Year - ngaysinh.Year < 18)
            {
                return "Ngày Sinh Không Hợp Lệ. Bạn Chưa Đủ 18 Tuổi";
            }

            if (DALStudent.Instance.GetStudentByID(masv).Rows.Count == 0)
            {
                int result = DALStudent.Instance.AddHoSoSinhVien(masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, socccd, hotennt, quanhe, ngaysinhnt, sdtnt, malop, nienkhoa, hdt, namnhaphoc);
                if (result > 0)
                {
                    return "";
                }
                else
                {
                    return "Thêm Sinh Viên Không Thành Công";
                }
            }
            else
            {
                return "Đã Tồn Tại Sinh Viên có mã này";
            }

        }

        public string UpdateHoSoSinhVien(string masv,
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
                                    string sdtnt,
                                    string malop,
                                    string nienkhoa,
                                    string hdt,
                                    string namnhaphoc)
        {
            Regex regexString = new Regex(@"^[\p{L} ]+$");
            Regex regexNumber = new Regex("^[0-9]+$");
            if (!regexString.IsMatch(hoten))
            {
                return "Họ Tên Không Hợp Lệ";
            }

            if (!regexNumber.IsMatch(sdt) || !regexNumber.IsMatch(socccd) || !regexNumber.IsMatch(sdtnt))
            {
                return "Số Điện Thoại Hoặc Số CCCD Không Hợp Lệ";
            }
            if (DateTime.Now.Year - ngaysinh.Year < 18)
            {
                return "Ngày Sinh Không Hợp Lệ. Bạn Chưa Đủ 18 Tuổi";
            }

            if (!(DALStudent.Instance.GetStudentByID(masv).Rows.Count == 0))
            {
                int result = DALStudent.Instance.UpdateHoSoSinhVien(masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, socccd, hotennt, quanhe, ngaysinhnt, sdtnt, malop, nienkhoa, hdt, namnhaphoc);
                if (result > 0)
                {
                    return "";
                }
                else
                {
                    return "Cập Nhật Thông Tin Sinh Viên Không Thành Công";
                }
            }
            else
            {
                return "Không Tồn Tại Sinh Viên có mã này";
            }

        }

        public bool DeleteStudent(string ID)
        {
            return DALStudent.Instance.DeleteStudent(ID) > 0;
        }

        public void FilterStudent(DataGridView data, string columnname, string value)
        {
            data.DataSource = DALStudent.Instance.FilterStudent(columnname, value);
        }
    }
}
