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
    public partial class fForgotPassword : Form
    {
        public fForgotPassword()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Texts;
            string phonenumber = TextBoxPhoneNumber.Texts;

            if(Isvalid(username, phonenumber)!=null)
            {
                textBoxNewPass.Texts = Isvalid(username, phonenumber);
            }
            else
            {
                MessageBox.Show("Tài Khoản Không Tồn Tại. Vui Lòng Kiểm Tra Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        string Isvalid(string username, string phonenumber)
        {
            return BUSAccount.Instance.GetPassword(username, phonenumber);
        }
    }
}
