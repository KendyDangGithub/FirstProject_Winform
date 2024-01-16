using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            BUSStudent.Instance.GetAllStudent(dataGridViewContent);

        }

        #region Event
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
                string message = BUSStudent.Instance.AddHoSoSinhVien(masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, socccd, hotennt, quanhe, ngaysinhnt, sdtnnt, malop, nienkhoa, hdt, namnhaphoc);
                if (message == "")
                {
                    MessageBox.Show("Thêm Sinh Viên Mới Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BUSStudent.Instance.GetAllStudent(dataGridViewContent);
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
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

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                textBoxSearch.Text = comboBoxSearchBy.Text;
                textBoxSearch.ForeColor = SystemColors.ActiveBorder;
            }
        }

        #endregion

        private void ButtonUpdate_Click(object sender, EventArgs e)
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
            if (comboBoxLop.SelectedIndex != -1)
            {
                malop = comboBoxLop.SelectedValue.ToString();

            }
            string nienkhoa = textBoxNienKhoa.Text;
            string hdt = comboBoxHDT.Text;
            if (comboBoxHDT.SelectedIndex != -1)
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
                string message = BUSStudent.Instance.UpdateHoSoSinhVien(masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, socccd, hotennt, quanhe, ngaysinhnt, sdtnnt, malop, nienkhoa, hdt, namnhaphoc);
                if (message == "")
                {
                    MessageBox.Show("Cập Nhật Thông Tin Sinh Viên Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BUSStudent.Instance.GetAllStudent(dataGridViewContent);
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        int index = -1;
        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            textBoxMaSV.Text = dataGridViewContent.Rows[index].Cells[0].Value.ToString();
            textBoxHoTen.Text = dataGridViewContent.Rows[index].Cells[1].Value.ToString();
            comboBoxGioiTinh.Text = dataGridViewContent.Rows[index].Cells[2].Value.ToString();
            textBoxDanToc.Text = dataGridViewContent.Rows[index].Cells[3].Value.ToString();
            string dateStringsv = dataGridViewContent.Rows[index].Cells[4].Value.ToString();
            if (DateTime.TryParseExact(dateStringsv, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime svparsedDate))
            {
                // Chuyển đổi DateTime sang chuỗi theo định dạng mới
                string newDateString = svparsedDate.ToString("MM/dd/yyyy");
                TimePickerBirthday.Value = DateTime.ParseExact(newDateString, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            }
            textBoxAddress.Text = dataGridViewContent.Rows[index].Cells[5].Value.ToString();
            textBoxPhone.Text = dataGridViewContent.Rows[index].Cells[6].Value.ToString();
            textBoxSoCCCD.Text = dataGridViewContent.Rows[index].Cells[7].Value.ToString();
            comboBoxLop.Text = dataGridViewContent.Rows[index].Cells[8].Value.ToString();
            textBoxHoTenNT.Text = dataGridViewContent.Rows[index].Cells[9].Value.ToString();
            textBoxRelative.Text = dataGridViewContent.Rows[index].Cells[10].Value.ToString();
            string dateStringnt = dataGridViewContent.Rows[index].Cells[11].Value.ToString();
            if (DateTime.TryParseExact(dateStringnt, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ntparsedDate))
            {
                // Chuyển đổi DateTime sang chuỗi theo định dạng mới
                string newDateString = ntparsedDate.ToString("MM/dd/yyyy");
                TimePickerBirthdayNT.Value = DateTime.ParseExact(newDateString, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            }
            textBoxPhoneNT.Text = dataGridViewContent.Rows[index].Cells[12].Value.ToString();

            textBoxNienKhoa.Text = dataGridViewContent.Rows[index].Cells[13].Value.ToString();
            comboBoxHDT.Text = dataGridViewContent.Rows[index].Cells[14].Value.ToString();
            textBoxNamNhapHoc.Text = dataGridViewContent.Rows[index].Cells[15].Value.ToString();
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Sinh Viên Có Mã: {textBoxMaSV.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if (isDelete(textBoxMaSV.Text))
                {
                    MessageBox.Show($"Xóa Thành Công Sinh Viên Có Mã: {textBoxMaSV.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSinhVien();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. Không Tồn Tại Sinh Viên Có Mã: {textBoxMaSV.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        bool isDelete(string ID)
        {
            return BUSStudent.Instance.DeleteStudent(ID);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string columnsearch = comboBoxSearchBy.Text;
            if (comboBoxSearchBy.SelectedIndex != -1)
            {
                columnsearch = comboBoxSearchBy.SelectedItem.ToString();
                switch (columnsearch)
                {
                    case "Mã SV":
                        columnsearch = "MaSV";
                        break;
                    case "Địa Chỉ":
                        columnsearch = "DiaChi";
                        break;
                    case "Tên":
                        columnsearch = "Hoten";
                        break;
                    case "Lớp":
                        columnsearch = "Lop";
                        break;
                    default:
                        break;
                }
            }
            string valueSearch = textBoxSearch.Text;
            
            if (string.IsNullOrEmpty(valueSearch))
            {
                MessageBox.Show("Nhập Giá Trị Cần Tìm Kiếm");
            }
            else
            {
                //Ok
                BUSStudent.Instance.FilterStudent(dataGridViewContent,columnsearch, valueSearch);
            }
        }

        private void textBoxSearch_Click_1(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.ForeColor = Color.Black; // Đặt màu chữ xám
        }

        private void kdDateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
