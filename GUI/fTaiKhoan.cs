using BUS;
using DevExpress.XtraReports.UI;
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
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
            LoadAllAccount();
        }

        private void fBaoCao_Load(object sender, EventArgs e)
        {

        }

        void LoadAllAccount()
        {
            BUSAccount.Instance.GetAllUser(dataGridViewContent);
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUsername.Text = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string username= textBoxUsername.Text;
            string pass = textBoxPass.Text;
            string sdt = textBoxSDT.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string message = BUSAccount.Instance.UpdateAccountPass(username, pass, sdt);
                if (message == "")
                {
                    MessageBox.Show("Cập Nhật Thông Tin Lớp Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllAccount();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Username: {textBoxUsername.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (BUSAccount.Instance.DeleteAccount(textBoxUsername.Text) > 0)
                {
                    MessageBox.Show($"Xóa Thành Công Username: {textBoxUsername.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllAccount();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. Không Tồn Username: {textBoxUsername.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
