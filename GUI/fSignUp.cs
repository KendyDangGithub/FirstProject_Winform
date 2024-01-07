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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
        }

        public event EventHandler SignUpRequested;
        private void linkLabelLoginHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpRequested?.Invoke(this, EventArgs.Empty);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Texts;
            string password = TextBoxPassword.Texts;
            string confirmpass = TextBoxConfirmPass.Texts;
            string phoneNumber = TextBoxPhoneNumber.Texts;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmpass) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                // Hiển thị thông báo lỗi hoặc thực hiện xử lý tương ứng
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (confirmpass != password)
                {
                    MessageBox.Show("Mật Khẩu Xác Nhận Không Chính Xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Ok
                    if (IsValid(username, password, phoneNumber))
                    {
                        MessageBox.Show("Tạo Tài Khoản Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Thất Bại. Tài Khoản Đã Tồn Tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        bool IsValid(string username, string password, string phone )
        {
            return BUSAccount.Instance.Createaccount(username, password, phone);
        }
    }
}
