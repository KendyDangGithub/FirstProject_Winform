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
    public partial class UCForgotPassword : UserControl
    {
        private static UCForgotPassword _instance;
        public static UCForgotPassword Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UCForgotPassword();
                }
               return _instance;
            }
        }
        public UCForgotPassword()
        {
            InitializeComponent();
        }

    }
}
