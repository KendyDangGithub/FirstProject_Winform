using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GUI
{
    public partial class fChuyenNganh : Form
    {
        public fChuyenNganh()
        {
            InitializeComponent();
            LoadAllBranch();
        }

        void LoadAllBranch()
        {
            BUSBranch.Instance.GetAllBranch(dataGridViewContent);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string macn = textBoxMaNganh.Text;
            string tencn = textBoxTenNganh.Text;

            if (string.IsNullOrEmpty(macn) || string.IsNullOrEmpty(tencn))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string message = BUSBranch.Instance.InsertBranch(macn, tencn);
                if (message == "")
                {
                    MessageBox.Show("Thêm Chuyên Ngành Mới Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllBranch();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string macn = textBoxMaNganh.Text;
            string tencn = textBoxTenNganh.Text;
            if (string.IsNullOrEmpty(macn) || string.IsNullOrEmpty(tencn))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string message = BUSBranch.Instance.UpdateBranch(macn, tencn);
                if (message == "")
                {
                    MessageBox.Show("Cập Nhật Thông Tin Chuyên Ngành Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllBranch();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Chuyên Ngành Có Mã: {textBoxMaNganh.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (BUSBranch.Instance.DeleteBranch(textBoxMaNganh.Text) > 0)
                {
                    MessageBox.Show($"Xóa Thành Công Lớp Có Mã: {textBoxMaNganh.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllBranch();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. Không Tồn Tại Lớp Có Mã: {textBoxMaNganh.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaNganh.Text = dataGridViewContent.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ColumnSearch = comboBoxColumn.SelectedItem.ToString();
            switch (ColumnSearch)
            {
                case "Mã Ngành":
                    comboBoxValue.Text = "";
                    comboBoxValue.DataSource = null;
                    break;
                case "Tên Ngành":
                    BUSBranch.Instance.GetAllBranchName(comboBoxValue);
                    break;
            }
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
                    case "Mã Ngành":
                        columnsearch = "MACHUYENNGANHNGANH";
                        valueSearch = comboBoxValue.Text;
                        break;
                    case "Tên Ngành":
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
                BUSSubject.Instance.FilterSubject(dataGridViewContent, columnsearch, valueSearch);
            }
        }
    }
}
