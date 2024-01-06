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
            LoginRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
