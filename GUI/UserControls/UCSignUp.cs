using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class UCSignUp : UserControl
    {
        private static UCSignUp _instance;
        public static UCSignUp Instance
        {
            get
            {
                if(_instance == null )
                {
                    _instance = new UCSignUp();
                }    
                return _instance;
            }
        }
        public UCSignUp()
        {
            InitializeComponent();
        }

        private void linkLabelLoginHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fLogin fLogin = new fLogin();

            fLogin.panelLogin.Controls.Add(UCSignIn.Instance);
            UCSignIn.Instance.BringToFront();
        }
    }
}
