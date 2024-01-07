using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fHoSoSinhVien : Form
    {
        public fHoSoSinhVien()
        {
            InitializeComponent();
            LoadSinhVien();
            //TimePickerBirthday.Format = DateTimePickerFormat.Custom;
            TimePickerBirthday.CustomFormat = "dd/MM/yyyy";
            TimePickerBirthdayNT.CustomFormat = "dd/MM/yyyy";
            LoadClassList();
        }

        void LoadClassList()
        {
            BUSClass.Instance.GetAllLopHoc(comboBoxLop);
        }
        void LoadSinhVien()
        {
            BUSSinhVien.Instance.GetAllStudent(dataGridViewContent);

        }
        private void fHoSoSinhVien_Load(object sender, EventArgs e)
        {

        }

        

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string masv = textBoxMaSV.Text;
            string hoten = textBoxHoTen.Text;
            string gioitinh = comboBoxGioiTinh.Text;
            if (comboBoxGioiTinh.SelectedIndex != -1)
            {
                gioitinh = comboBoxGioiTinh.SelectedItem.ToString();

            }
            string dantoc = textBoxDanToc.Text;
            DateTime ngaysinh = DateTime.Parse(TimePickerBirthday.Value.ToString());
            string diachi = textBoxAddress.Text;
            string sdt = textBoxPhone.Text;
            string socccd = textBoxSoCCCD.Text;

            string hotennt = textBoxHoTenNT.Text;
            string quanhe = textBoxRelative.Text;
            DateTime ngaysinhnt = DateTime.Parse(TimePickerBirthdayNT.Value.ToString());
            string sdtnnt = textBoxPhoneNT.Text;

            string malop = comboBoxLop.Text;
            if(comboBoxLop.SelectedIndex != -1)
            {
                malop = comboBoxLop.SelectedValue.ToString();

            }
            string nienkhoa = textBoxNienKhoa.Text;
            string hdt = comboBoxHDT.Text;
            if(comboBoxHDT.SelectedIndex != -1)
            {
                hdt = comboBoxHDT.SelectedItem.ToString();

            }
            string namnhaphoc = textBoxNamNhapHoc.Text;


            if (string.IsNullOrWhiteSpace(masv) ||
                string.IsNullOrWhiteSpace(hoten) ||
                string.IsNullOrWhiteSpace(gioitinh) ||
                string.IsNullOrWhiteSpace(dantoc) ||
                ngaysinh == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(diachi) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(socccd) ||
                string.IsNullOrWhiteSpace(hotennt) ||
                string.IsNullOrWhiteSpace(quanhe) ||
                ngaysinhnt == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(sdtnnt) ||
                string.IsNullOrWhiteSpace(malop) ||
                string.IsNullOrWhiteSpace(nienkhoa) ||
                string.IsNullOrWhiteSpace(hdt) ||
                string.IsNullOrWhiteSpace(namnhaphoc))
            {
                // Hiển thị thông báo hoặc thực hiện các hành động xử lý khi thông tin chưa được nhập đủ
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Thực hiện các hành động khi thông tin đã được nhập đủ
                // Ví dụ: Gọi stored procedure hoặc thêm dữ liệu vào CSDL
            }
        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSearch.Text = comboBoxSearchBy.Text;
            textBoxSearch.ForeColor = SystemColors.ActiveBorder;
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black; // Đặt màu chữ xám
        }

        private void TextBoxSearch_Load(object sender, EventArgs e)
        {
            textBoxSearch.Text = comboBoxSearchBy.Text;
            textBoxSearch.ForeColor = SystemColors.ActiveBorder;
        }

        private void textBoxSearch_Click_1(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.ForeColor = Color.Black;
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Text = comboBoxSearchBy.Text;
            textBoxSearch.ForeColor = SystemColors.ActiveBorder;
        }
    }
}
