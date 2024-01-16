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
    public partial class fHocPhan : Form
    {
        public fHocPhan()
        {
            InitializeComponent();
            LoadAllHocPhan();
        }

        void LoadAllHocPhan()
        {
            BUSSubject.Instance.GetAllHocPhan(dataGridViewContent);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string mahp = textBoxMaHp.Text;
            string tenhp = textBoxTenHp.Text;

            if (!string.IsNullOrEmpty(mahp) && !string.IsNullOrEmpty(tenhp))
            {
                if (string.IsNullOrEmpty(numericUpDownSoTC.Text) || numericUpDownSoTC.Value == 0)
                {
                    MessageBox.Show("Số Tín Chỉ Không Hợp Lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int sotc = (int)numericUpDownSoTC.Value;
                    string message = BUSSubject.Instance.InsertSubject(mahp, tenhp, sotc);
                    if (message == "")
                    {
                        MessageBox.Show($"Thêm Học Phần Có Mã {mahp} Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllHocPhan();
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
            string mahp = textBoxMaHp.Text;
            string tenhp = textBoxTenHp.Text;

            if (!string.IsNullOrEmpty(mahp) && !string.IsNullOrEmpty(tenhp))
            {
                if (string.IsNullOrEmpty(numericUpDownSoTC.Text) || numericUpDownSoTC.Value == 0)
                {
                    MessageBox.Show("Số Tín Chỉ Không Hợp Lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int sotc = (int)numericUpDownSoTC.Value;
                    string message = BUSSubject.Instance.UpdateSubject(mahp, tenhp, sotc);
                    if (message == "")
                    {
                        MessageBox.Show($"Cập Nhật Thông Tin Học Phần Có Mã {mahp} Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllHocPhan();
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
            DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Học Phần Có Mã: {textBoxMaHp.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (BUSSubject.Instance.DeleteSubject(textBoxMaHp.Text) > 0)
                {
                    MessageBox.Show($"Xóa Thành Công Học Phần Có Mã: {textBoxMaHp.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllHocPhan();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. Không Tồn Tại Học Phần Có Mã: {textBoxMaHp.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHp.Text = dataGridViewContent.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string columnsearch = comboBoxColumn.Text;
            string valueSearch = "";
            if (comboBoxColumn.SelectedIndex != -1)
            {
                columnsearch = comboBoxColumn.SelectedItem.ToString();
              
            }
            switch (columnsearch)
            {
                case "Khoa":
                    columnsearch = "Makhoa";
                    valueSearch = "KCNTT";
                    comboBoxValue.Enabled = false;
                    break;
                case "Số Tín Chỉ":
                    comboBoxValue.Enabled = true;
                    columnsearch = "SOTC";
                    valueSearch = comboBoxValue.Text;
                    break;
                case "Học Phần":
                    comboBoxValue.Enabled = true;

                    columnsearch = "TenHocPhan";
                    valueSearch = comboBoxValue.Text;
                    if (comboBoxValue.SelectedIndex != -1)
                    {
                        valueSearch = comboBoxValue.SelectedItem.ToString();
                    }
                    break;
                default:
                    break;
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

        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ColumnSearch = comboBoxColumn.Text;
            if(comboBoxColumn.SelectedIndex != -1)
            {
                 ColumnSearch = comboBoxColumn.SelectedItem.ToString();

            }
            switch (ColumnSearch)
            {
                case "Số Tín Chỉ":
                    comboBoxValue.Text = "";
                    comboBoxValue.DataSource = null;
                    break;
                case "Khoa":
                    comboBoxValue.Text = "CNTT";
                    comboBoxValue.Enabled = false;
                    break;
                case "Học Phần":
                    BUSSubject.Instance.GetAllSubject(comboBoxValue);
                    break;
            }
        }
    }
}
