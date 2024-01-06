using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class UCSignIn : UserControl
    {
        private static UCSignIn _instance;
        public static UCSignIn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCSignIn();
                }
                return _instance;

            }
        }

        public UCSignIn()
        {
            InitializeComponent();
        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            fHome fhome = new fHome();
            fhome.Show();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fLogin flogin = new fLogin();
            flogin.panelLogin.Controls.Add(UCSignUp.Instance);
            UCSignUp.Instance.BringToFront();
        }


    }
}
