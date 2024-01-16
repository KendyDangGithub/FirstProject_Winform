using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSScore
    {
        private static BUSScore _instance;
        public static BUSScore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSScore();
                }
                return _instance;
            }
        }
        public void GetAllScore(DataGridView datagird)
        {
            datagird.DataSource = DALScore.Instance.GetAllScore();
        }

        public string InsertScore(string diem, int hocky, string masv, string mahocphan)
        {
            Regex regex = new Regex(@"^-?\d+(\.\d+)?$");
            if (!regex.IsMatch(diem))
            {
                return "Định Dạng Điểm Không Hợp Lệ";
            }
            else
            {
                float diemthi = float.Parse(diem);
                if(diemthi < 0 || diemthi > 10)
                {
                    return "Định Dạng Điểm Không Hợp Lệ";
                }
            }
            if (DALStudent.Instance.GetStudentByID(masv).Rows.Count > 0)
            {
                if(DALScore.Instance.GetScoreSubject(masv, mahocphan).Rows.Count == 0)
                {
                    if (DALScore.Instance.InsertScore(float.Parse(diem), hocky, masv, mahocphan) > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Nhập Điểm Thất Bại";
                    }
                }
                else
                {
                    return "Sinh Viên Đã Có Điểm Môn Học Này";
                }
          
            }
            else
            {
                return "Không Tồn Tại Sinh Viên Có Mã Này";
            }
        }

        public string UpdateScore(string diem, int hocky, string masv, string mahocphan)
        {
            Regex regex = new Regex(@"^-?\d+(\.\d+)?$");
            if (!regex.IsMatch(diem))
            {
                return "Định Dạng Điểm Không Hợp Lệ";
            }
            else
            {
                float diemthi = float.Parse(diem);
                if (diemthi < 0 || diemthi > 10)
                {
                    return "Định Dạng Điểm Không Hợp Lệ";
                }
            }
            if (DALScore.Instance.GetStudentByIDInScore(masv).Rows.Count > 0)
            {
                if (DALScore.Instance.GetScoreSubject(masv, mahocphan).Rows.Count != 0)
                {
                    if (DALScore.Instance.InsertScore(float.Parse(diem), hocky, masv, mahocphan) > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Nhập Điểm Thất Bại";
                    }
                }
                else
                {
                    return "Sinh Viên Chưa Có Điểm Môn Học Này";
                }

            }
            else
            {
                return "Không Tồn Tại Sinh Viên Có Mã Này";
            }
        }

        public int DeleteScore(string mahp)
        {
            return DALScore.Instance.DeleteScore(mahp);
        }

        public void FilterScore(DataGridView datagird, string column, string value)
        {
            datagird.DataSource = DALScore.Instance.FilterScore(column, value);
        }

        public void SortDESC(DataGridView datagird)
        {
            datagird.DataSource = DALScore.Instance.SortDESC();
        }
        public void SortASC(DataGridView datagird)
        {
            datagird.DataSource = DALScore.Instance.SortASC();
        }

    }
}
