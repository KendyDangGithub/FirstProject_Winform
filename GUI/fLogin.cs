using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI
{
    public partial class fLogin : Form
    {
        public fSignIn formSignIn;
        public fSignUp formSignUp;
        public fForgotPassword formForgotPassword;

        public fLogin()
        {
            InitializeComponent();
            formSignIn = new fSignIn();
            formSignIn.SignInRequested += FormSignIn_SignUpRequested;
            formSignIn.LoginRequested += FormSignIn_LoginRequested; 

            formSignIn.FormBorderStyle = FormBorderStyle.None;
            formSignIn.TopLevel = false;
            formSignIn.Parent = panelLogin;
            formSignIn.Show();

            formSignUp = new fSignUp();
            formSignUp.SignUpRequested += FormSignUp_SignInRequested;
            formSignUp.FormBorderStyle = FormBorderStyle.None;
            formSignUp.TopLevel = false;
            formSignUp.Parent = panelLogin;
            formSignUp.Hide(); // Ẩn Form SignUp ban đầu

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            buttonSignIn.BackColor = SystemColors.Highlight;
            buttonSignUp.BackColor = SystemColors.ActiveBorder;

            formSignUp.Hide();
            formSignIn.Show();

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            buttonSignUp.BackColor = SystemColors.Highlight;
            buttonSignIn.BackColor = SystemColors.ActiveBorder;

            formSignIn.Hide();
            formSignUp.Show();

        }

        private void FormSignIn_SignUpRequested(object sender, EventArgs e)
        {
            buttonSignUp.BackColor = SystemColors.Highlight;
            buttonSignIn.BackColor = SystemColors.ActiveBorder;
            // Khi nhận được yêu cầu từ FormSignIn, ẩn FormSignIn và hiển thị FormSignUp
            formSignIn.Hide();
            formSignUp.Show();
        }

        private void FormSignUp_SignInRequested(object sender, EventArgs e)
        {
            buttonSignIn.BackColor = SystemColors.Highlight;
            buttonSignUp.BackColor = SystemColors.ActiveBorder;
            // Khi nhận được yêu cầu từ FormSignUp, ẩn FormSignUp và hiển thị FormSignIn
            formSignUp.Hide();
            formSignIn.Show();
        }

        private void FormSignIn_LoginRequested(object sender, EventArgs e)
        {
            buttonSignIn.BackColor = SystemColors.Highlight;
            buttonSignUp.BackColor = SystemColors.ActiveBorder;
            // Khi nhận được yêu cầu từ FormSignIn, ẩn FormSignIn và hiển thị fHome
            fHome fHome = new fHome();
            this.Hide();
            fHome.Show();
        }
    }
}
