using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace GUI
{
    public partial class fHoSoGiangVien : Form
    {
        public fHoSoGiangVien()
        {
            InitializeComponent();
            LoadGiangVien();
            TimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        #region Method

        #endregion

        #region Event

        void LoadGiangVien()
        {
            BUSLecturer.Instance.GetAllGiangVien(dataGridViewContent);
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string maGV = textBoxMaGV.Text;
            string hoten = textBoxHoten.Text;
            string gioitinh = comboBoxGioiTInh.Text;
            if (comboBoxGioiTInh.SelectedIndex != -1)
            {
                gioitinh = comboBoxGioiTInh.SelectedItem.ToString();

            }
            DateTime ngaysinh = DateTime.Parse(TimePickerNgaySinh.Value.ToString());
            string diachi = textBoxDiaChi.Text;
            string socccd = textBoxSoCCCD.Text;
            string sdt = textBoxSDT.Text;
            string makhoa = "K" + comboBoxKhoa.Text;

            if (string.IsNullOrWhiteSpace(maGV) ||
                string.IsNullOrWhiteSpace(hoten) ||
                string.IsNullOrWhiteSpace(gioitinh) ||
                ngaysinh == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(diachi) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(socccd) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(makhoa))

            {
                // Hiển thị thông báo hoặc thực hiện các hành động xử lý khi thông tin chưa được nhập đủ
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string message = BUSLecturer.Instance.InsertGiangVien(maGV, hoten, gioitinh, ngaysinh, diachi, sdt, socccd, makhoa);
                if (message == "")
                {
                    MessageBox.Show("Thêm Giảng Viên Mới Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BUSLecturer.Instance.GetAllGiangVien(dataGridViewContent);
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string maGV = textBoxMaGV.Text;
            string hoten = textBoxHoten.Text;
            string gioitinh = comboBoxGioiTInh.Text;
            if (comboBoxGioiTInh.SelectedIndex != -1)
            {
                gioitinh = comboBoxGioiTInh.SelectedItem.ToString();

            }
            DateTime ngaysinh = DateTime.Parse(TimePickerNgaySinh.Value.ToString());
            string diachi = textBoxDiaChi.Text;
            string socccd = textBoxSoCCCD.Text;
            string sdt = textBoxSDT.Text;
            string makhoa = "K" + comboBoxKhoa.Text;

            if (string.IsNullOrWhiteSpace(maGV) ||
                string.IsNullOrWhiteSpace(hoten) ||
                string.IsNullOrWhiteSpace(gioitinh) ||
                ngaysinh == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(diachi) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(socccd) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(makhoa))

            {
                // Hiển thị thông báo hoặc thực hiện các hành động xử lý khi thông tin chưa được nhập đủ
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string message = BUSLecturer.Instance.UpdateGiangVien(maGV, hoten, gioitinh, ngaysinh, diachi, socccd, sdt, makhoa);
                if (message == "")
                {
                    MessageBox.Show("Cập Nhật Thông Tin Giảng Viên Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BUSLecturer.Instance.GetAllGiangVien(dataGridViewContent);
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Giảng Viên Có Mã: {textBoxMaGV.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (isDelete(textBoxMaGV.Text))
                {
                    MessageBox.Show($"Xóa Giảng Viên Sinh Viên Có Mã: {textBoxMaGV.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGiangVien();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. Không Tồn Tại Giảng Viên Có Mã: {textBoxMaGV.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        bool isDelete(string magv)
        {
            return BUSLecturer.Instance.DeleteGiangVien(magv);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string columnsearch = comboBoxColumnSearch.Text;
            if (comboBoxColumnSearch.SelectedIndex != -1)
            {
                columnsearch = comboBoxColumnSearch.SelectedItem.ToString();
                switch (columnsearch)
                {
                    case "Tên":
                        columnsearch = "Hoten";
                        break;
                    case "Địa Chỉ":
                        columnsearch = "DiaChi";
                        break;
                    case "Mã GV":
                        columnsearch = "MaGiangVien";
                        break;
                    default:
                        break;
                }
            }
            string valueSearch = textBoxValueSearch.Text;

            if (string.IsNullOrEmpty(valueSearch))
            {
                MessageBox.Show("Nhập Giá Trị Cần Tìm Kiếm");
            }
            else
            {
                //Ok
                BUSLecturer.Instance.FilterLectures(dataGridViewContent, columnsearch, valueSearch);
            }
        }


        #endregion

        int index;
        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            textBoxMaGV.Text = dataGridViewContent.Rows[index].Cells[0].Value.ToString();
            textBoxHoten.Text = dataGridViewContent.Rows[index].Cells[1].Value.ToString();
            comboBoxGioiTInh.Text = dataGridViewContent.Rows[index].Cells[2].Value.ToString();
            string dateStringsv = dataGridViewContent.Rows[index].Cells[3].Value.ToString();
            if (DateTime.TryParseExact(dateStringsv, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime svparsedDate))
            {
                // Chuyển đổi DateTime sang chuỗi theo định dạng mới
                string newDateString = svparsedDate.ToString("MM/dd/yyyy");
                TimePickerNgaySinh.Value = DateTime.ParseExact(newDateString, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            }
            textBoxDiaChi.Text = dataGridViewContent.Rows[index].Cells[4].Value.ToString();
            textBoxSoCCCD.Text = dataGridViewContent.Rows[index].Cells[5].Value.ToString();
            textBoxSDT.Text = dataGridViewContent.Rows[index].Cells[6].Value.ToString();
        }



   

        private void textBoxValueSearch_Click(object sender, EventArgs e)
        {
            textBoxValueSearch.Text = "";
            textBoxValueSearch.ForeColor = Color.Black;
        }

        private void textBoxValueSearch_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxValueSearch.Text))
            {
                textBoxValueSearch.Text = comboBoxColumnSearch.Text;
                textBoxValueSearch.ForeColor = SystemColors.ActiveBorder;
            }
      
        }

    }
}
