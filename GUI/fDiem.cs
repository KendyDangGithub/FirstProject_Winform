using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fDiem : Form
    {
        public fDiem()
        {
            InitializeComponent();
            LoadAllSubject();
            LoadAllScore();
        }

        void LoadAllSubject()
        {
            BUSSubject.Instance.GetAllSubject(comboBoxMonHoc);
            //BUSSubject.Instance.GetAllSubject(comboBoxValueSearch);
        }
        void LoadAllScore()
        {
            BUSScore.Instance.GetAllScore(dataGridViewContent);
        }

        string GetSubjectIDByName(ComboBox cbx)
        {
            string result = cbx.Text;
            if (cbx.SelectedIndex != -1)
            {
                result = cbx.SelectedItem.ToString();
            }
            switch (result)
            {
                case "Công Dân Số":
                    result = "CDS";
                    break;
                case "Cơ Sở Dữ Liệu":
                    result = "CSDL";
                    break;
                case "CSKT Lập Trình":
                    result = "CKTLT";
                    break;
                case "CTDL Và GT":
                    result = "CTDLGT";
                    break;
                case "Hệ Điều Hành":
                    result = "CTDLGT";
                    break;
                case "HQT CSDL":
                    result = "HQT";
                    break;

                case "Kiến Trúc MT":
                    result = "KTMT";
                    break;
                case "LT Huớng Ðối Tượng":
                    result = "OOP";
                    break;
                case "LT Python":
                    result = "PT";
                    break;
                case "LT Windows Form":
                    result = "WF";
                    break;
                default:
                    break;
            }

            return result;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string masv = textBoxMaSV.Text;
            string diemthi = textBoxDiemThi.Text;
            string tenhocphan = comboBoxMonHoc.Text;
            if (comboBoxMonHoc.SelectedIndex != -1)
            {
                tenhocphan = comboBoxMonHoc.SelectedItem.ToString();
            }
            string maHocPhan = BUSSubject.Instance.GetIDByName(tenhocphan);

            if (!string.IsNullOrEmpty(masv) && !string.IsNullOrEmpty(diemthi) && !string.IsNullOrEmpty(maHocPhan))
            {
                if (string.IsNullOrEmpty(numericUpDownHocKy.Text) || numericUpDownHocKy.Value == 0)
                {
                    MessageBox.Show("Học Kỳ Không Hợp Lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int hocky = (int)numericUpDownHocKy.Value;
                    string message = BUSScore.Instance.InsertScore(diemthi, hocky, masv, maHocPhan);
                    if (message == "")
                    {
                        MessageBox.Show($"Nhập Điểm Cho Sinh Viên {masv} Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUSScore.Instance.GetAllScore(dataGridViewContent);
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string masv = textBoxMaSV.Text;
            string diemthi = textBoxDiemThi.Text;
            string mahocphan = GetSubjectIDByName(comboBoxMonHoc);


            if (!string.IsNullOrEmpty(masv) && !string.IsNullOrEmpty(diemthi) && !string.IsNullOrEmpty(mahocphan))
            {
                if (string.IsNullOrEmpty(numericUpDownHocKy.Text) || numericUpDownHocKy.Value == 0)
                {
                    MessageBox.Show("Học Kỳ Không Hợp Lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int hocky = (int)numericUpDownHocKy.Value;
                    string message = BUSScore.Instance.UpdateScore(diemthi, hocky, masv, mahocphan);
                    if (message == "")
                    {
                        MessageBox.Show($"Cập Nhật Điểm Cho Sinh Viên {masv} Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUSScore.Instance.GetAllScore(dataGridViewContent);
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Điểm Môn Học: {comboBoxMonHoc.SelectedItem} Của Sinh Viên Có Mã: {textBoxMaSV.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (BUSScore.Instance.DeleteScore(GetSubjectIDByName(comboBoxMonHoc)) != 0)
                {
                    MessageBox.Show($"Xóa Thành Công Điểm Môn Học: {comboBoxMonHoc.SelectedItem} Của Sinh Viên Có Mã: {textBoxMaSV.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllScore();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. Sinh Viên Chưa Có Điểm Môn Học Này: {textBoxMaSV.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaSV.Text = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string columnsearch = comboBoxSearch.Text;
            string valueSearch = "";
            if (comboBoxSearch.SelectedIndex != -1)
            {
                columnsearch = comboBoxSearch.SelectedItem.ToString();
                switch (columnsearch)
                {
                    case "Lớp":
                        columnsearch = "Malop";
                        valueSearch = comboBoxValueSearch.Text;
                        break;
                    case "Mã Sinh Viên":
                        columnsearch = "Masv";
                        valueSearch = comboBoxValueSearch.Text;
                        break;
                    case "Môn Học":
                        columnsearch = "TENHOCPHAN";
                        valueSearch = "LT Windows Form";
                        if (comboBoxValueSearch.SelectedIndex != -1)
                        {
                            valueSearch = comboBoxValueSearch.SelectedItem.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
            if (string.IsNullOrEmpty(valueSearch))
            {
                MessageBox.Show("Nhập Giá Trị Cần Tìm Kiếm");
            }
            else
            {
                //Ok
                BUSScore.Instance.FilterScore(dataGridViewContent, columnsearch, valueSearch);
            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ColumnSearch = comboBoxSearch.SelectedItem.ToString();
            switch (ColumnSearch)
            {
                case "Lớp":
                    comboBoxValueSearch.Text = "";
                    comboBoxValueSearch.DataSource = null;
                    break;
                case "Mã Sinh Viên":
                    comboBoxValueSearch.Text = "";
                    comboBoxValueSearch.DataSource = null;
                    break;
                case "Môn Học":
                    BUSSubject.Instance.GetAllSubject(comboBoxValueSearch);
                    break;
            }

        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            string SortType = comboBoxSort.Text;
            if (comboBoxSort.SelectedIndex != -1)
            {
                SortType = comboBoxSort.SelectedItem.ToString();
                switch (SortType)
                {
                    case "Giảm Dần":
                        BUSScore.Instance.SortDESC(dataGridViewContent);
                        break;
                    case "Tăng Dần":
                        BUSScore.Instance.SortASC(dataGridViewContent);
                        break;
                }
            }
        }
    }
}
