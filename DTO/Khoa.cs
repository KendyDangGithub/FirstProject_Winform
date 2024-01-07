using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class Khoa
    {
        // Thuộc tính (Properties)
        private string maKhoa;
        private string tenKhoa;

        // Constructor mặc định
        public Khoa()
        {
            // Khởi tạo giá trị mặc định hoặc thực hiện các tác vụ khởi tạo khác nếu cần.
        }

        // Constructor có tham số
        public Khoa(string maKhoa, string tenKhoa)
        {
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
        }

        // Thuộc tính MaKhoa với tính đóng gói
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }

        // Thuộc tính TenKhoa với tính đóng gói
        public string TenKhoa
        {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }
    }


}
