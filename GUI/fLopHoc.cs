using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace GUI
{
    public partial class fLopHoc : Form
    {
        public fLopHoc()
        {
            InitializeComponent();
            LoadAllBranch();
            LoadAllClass();
        }

        void LoadAllBranch()
        {
            BUSBranch.Instance.GetAllBranchName(comboBoxbranch);
        }
        void LoadAllClass()
        {
            BUSClass.Instance.GetAllClass(dataGridViewContent);
        }
        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ColumnSearch = comboBoxColumn.SelectedItem.ToString();
            switch (ColumnSearch)
            {
                case "Mã Lớp":
                    comboBoxValue.Text = "";
                    comboBoxValue.DataSource = null;
                    break;
                case "Tên Lớp":
                    comboBoxValue.Text = "";
                    comboBoxValue.DataSource = null;
                    break;
                case "Chuyên Ngành":
                    BUSBranch.Instance.GetAllBranchName(comboBoxValue);
                    break;
            }
        }

        string ConvertNameToID(ComboBox cbx)
        {
            string result = cbx.Text;
            if (cbx.SelectedIndex != -1)
            {
                result = cbx.SelectedItem.ToString();
            }
            switch (result)
            {
                case "Công Nghệ Di Động":
                    result = "CNDD";
                    break;
                case "Công Nghệ Web":
                    result = "CNW";
                    break;
                case "Internet of Things":
                    result = "IOT";
                    break;
                case "Khoa Học Máy Tính":
                    result = "KHMT";
                    break;
                case "Kiểm Thử":
                    result = "KT";
                    break;
                case "Thiết Kế Đồ Họa":
                    result = "TKDH";
                    break;
            }
            return result;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string maLop = textBoxMaLop.Text;
            string tenLop = textBoxTenLop.Text;
            //string maChuyenNganh = BUSSubject.Instance.GetIDByName(comboBoxbranch.SelectedItem.ToString());
            string tenchuyennganh = comboBoxbranch.Text;
            if (comboBoxbranch.SelectedIndex != -1)
            {
                tenchuyennganh = comboBoxbranch.SelectedItem.ToString();
            }
            string maChuyenNganh = BUSBranch.Instance.GetIDByName(tenchuyennganh);

            if(string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(maChuyenNganh))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string message = BUSClass.Instance.InsertClass(maLop, tenLop, maChuyenNganh);
                if (message== "")
                {
                    MessageBox.Show("Thêm Lớp Mới Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllClass();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string maLop = textBoxMaLop.Text;
            string tenLop = textBoxTenLop.Text;
            string maChuyenNganh = ConvertNameToID(comboBoxbranch);

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(maChuyenNganh))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string message = BUSClass.Instance.UpdateClass(maLop, tenLop, maChuyenNganh);
                if (message == "")
                {
                    MessageBox.Show("Cập Nhật Thông Tin Lớp Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllClass();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Lớp Có Mã: {textBoxMaLop.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (BUSClass.Instance.DeleteClass(textBoxMaLop.Text) > 0)
                {
                    MessageBox.Show($"Xóa Thành Công Lớp Có Mã: {textBoxMaLop.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllClass();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. Không Tồn Tại Lớp Có Mã: {textBoxMaLop.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaLop.Text = dataGridViewContent.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string columnsearch = comboBoxColumn.Text;
            string valueSearch = "";
            if (comboBoxColumn.SelectedIndex != -1)
            {
                columnsearch = comboBoxColumn.SelectedItem.ToString();
                switch (columnsearch)
                {
                    case "Mã Lớp":
                        columnsearch = "Malop";
                        valueSearch = comboBoxValue.Text;
                        break;
                    case "Tên Lớp":
                        columnsearch = "TenLop";
                        valueSearch = comboBoxValue.Text;
                        break;
                    case "Chuyên Ngành":
                        columnsearch = "TenChuyenNganh";
                        valueSearch = comboBoxValue.Text;
                        if (comboBoxValue.SelectedIndex != -1)
                        {
                            valueSearch = comboBoxValue.SelectedItem.ToString();
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
                BUSClass.Instance.FilterClass(dataGridViewContent, columnsearch, valueSearch);
            }
        }

       
    }
}
