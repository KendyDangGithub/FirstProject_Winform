using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Shell;

namespace GUI
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();

            hideSubMenu();
            ShowUserControls(new UCHome());

        }
        private void hideSubMenu()
        {
            flowLayoutPanelHoSo.Visible = false;
            flowLayoutPanelQuanLy.Visible = false;
            //panelToolsSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        void ShowUserControls(UserControl uc)
        {
            panelContent.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void ButtonHoSo_Click(object sender, EventArgs e)
        {
            showSubMenu(flowLayoutPanelHoSo);
        }

        private void ButtonQuanLy_Click(object sender, EventArgs e)
        {
            showSubMenu(flowLayoutPanelQuanLy);
        }
        private Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CenterLabel(Label lb)
        {
            int x = (panelTitle.Width - lb.Width) / 2;
            int y = (panelTitle.Height - lb.Height) / 2;
            lb.Location = new Point(x, y);
        }
        private void ButtonSinhVien_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonHoSo.Text + " " + ButtonSinhVien.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fHoSoSinhVien());
            //..
            //your codes
            //..
            //hideSubMenu();
        }

        private void ButtonGiangVien_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonHoSo.Text + " " + ButtonGiangVien.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fHoSoGiangVien());
            //..
            //your codes
            //..
            //hideSubMenu();
        }

        private void ButtonQuanLy_MouseEnter(object sender, EventArgs e)
        {
            ButtonQuanLy.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonQuanLy_MouseLeave(object sender, EventArgs e)
        {
            ButtonQuanLy.BackColor = Color.White;
        }

        private void ButtonHoSo_MouseEnter(object sender, EventArgs e)
        {
            ButtonHoSo.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonHoSo_MouseLeave(object sender, EventArgs e)
        {
            ButtonHoSo.BackColor = Color.White;

        }

        private void ButtonThongKe_MouseEnter(object sender, EventArgs e)
        {
            ButtonThongKe.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonThongKe_MouseLeave(object sender, EventArgs e)
        {
            ButtonThongKe.BackColor = Color.White;

        }

        private void ButtonBaoCao_MouseEnter(object sender, EventArgs e)
        {
            ButtonBaoCao.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonBaoCao_MouseLeave(object sender, EventArgs e)
        {
            ButtonBaoCao.BackColor = Color.White;

        }

        private void ButtonSinhVien_MouseEnter(object sender, EventArgs e)
        {
            ButtonSinhVien.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonSinhVien_MouseLeave(object sender, EventArgs e)
        {
            ButtonSinhVien.BackColor = Color.Silver;

        }

        private void ButtonGiangVien_MouseEnter(object sender, EventArgs e)
        {
            ButtonGiangVien.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonGiangVien_MouseLeave(object sender, EventArgs e)
        {
            ButtonGiangVien.BackColor = Color.Silver;

        }

        private void ButtonDiem_MouseEnter(object sender, EventArgs e)
        {
            ButtonDiem.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonDiem_MouseLeave(object sender, EventArgs e)
        {
            ButtonDiem.BackColor = Color.Silver;

        }

        private void ButtonHocPhan_MouseEnter(object sender, EventArgs e)
        {
            ButtonHocPhan.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonHocPhan_MouseLeave(object sender, EventArgs e)
        {
            ButtonHocPhan.BackColor = Color.Silver;

        }

        private void ButtonChuyenNganh_MouseEnter(object sender, EventArgs e)
        {
            ButtonChuyenNganh.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonChuyenNganh_MouseLeave(object sender, EventArgs e)
        {
            ButtonChuyenNganh.BackColor = Color.Silver;

        }

        private void kdCircularPictureBox1_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "ĐẠI HỌC SƯ PHẠM KỸ THẬT HƯNG YÊN";
            CenterLabel(labelTitle);
            ShowUserControls(new UCHome());
 
        }

        private void ButtonDiem_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonQuanLy.Text + " " + ButtonDiem.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fDiem());
        }

        private void ButtonHocPhan_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonQuanLy.Text + " " + ButtonHocPhan.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fHocPhan());
        }

        private void ButtonChuyenNganh_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonQuanLy.Text + " " + ButtonChuyenNganh.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fChuyenNganh());
        }

        private void ButtonThongKe_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonThongKe.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fThongKe());
        }

        private void ButtonBaoCao_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonBaoCao.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fTaiKhoan());
        }

        private void ButtonLopHoc_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonQuanLy.Text + " " + ButtonLopHoc.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fLopHoc());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Đăng Xuất Không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                this.Hide();

                fLogin formLogin = new fLogin();
                formLogin.Show();
            }
        }

        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng ứng dụng?", "Xác nhận đóng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result != DialogResult.OK)
            {
                e.Cancel = true; // Ngăn chặn đóng form nếu người dùng chọn Cancel
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void ButtonLopHoc_MouseEnter(object sender, EventArgs e)
        {
            ButtonLopHoc.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonLopHoc_MouseLeave(object sender, EventArgs e)
        {
            ButtonLopHoc.BackColor = Color.Silver;

        }
    }
}
