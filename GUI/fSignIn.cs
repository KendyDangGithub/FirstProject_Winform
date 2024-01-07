using BUS;
using GUI.UserControls;
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
    public partial class fSignIn : Form
    {
        public fSignIn()
        {
            InitializeComponent();
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fForgotPassword fForgotPassword = new fForgotPassword();
            fForgotPassword.ShowDialog();
        }

        public event EventHandler SignInRequested;
        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler LoginRequested;
        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            if (isLogin(userName, password))
            {
                LoginRequested?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool isLogin(string userName, string password)
        {
            return BUSAccount.Instance.IsLogin(userName, password);
        }

        private void textBoxUserName_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "Username")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black; // Đặt màu chữ mặc định
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserName.Text))
            {
                textBoxUserName.Text = "Username";
                textBoxUserName.ForeColor = SystemColors.ActiveBorder; // Đặt màu chữ xám
            }
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black; // Đặt màu chữ mặc định
                textBoxPassword.PasswordChar = '*'; // Nếu bạn muốn hiển thị ký tự nhấn
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = SystemColors.ActiveBorder; // Đặt màu chữ xám
                textBoxPassword.PasswordChar = '\0'; // Hiển thị ký tự thường
            }
        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "Password")
            {
                if (checkBoxRemember.Checked)
                {
                    textBoxPassword.PasswordChar = '\0'; // Hiển thị ký tự thường
                }
                else
                {
                    textBoxPassword.PasswordChar = '*'; // Nếu bạn muốn hiển thị ký tự nhấn

                }
            }

        }
    }
}
