using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLThietBi;
using BLL_QLThietBi;

namespace QLThietBi.Presentation
{
    public partial class GUI_DangNhap : Form
    {
        QL_LinhKienDataContext dbLinhKien = new QL_LinhKienDataContext();
        BLL_TaiKhoang bllTaiKhoang = new BLL_TaiKhoang();
        BLL_DMMangHinh bllDMMangHinh = new BLL_DMMangHinh();

        public GUI_DangNhap()
        {
            InitializeComponent();                        
            this.AcceptButton = btnDangNhap;
            this.CancelButton = btnThoat;
        }

        

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {
            ReadSettings();
        }

        private void ReadSettings()
        {
            
            if (Properties.Settings.Default.RememberMe == "true")
            {
                txtTenTK.Text = Properties.Settings.Default.User;
                txtMatKhau.Text = Properties.Settings.Default.Pass;
                chkNhoMK.Checked = true;
            }
            else
            {
                txtTenTK.Text = "";
                txtMatKhau.Text = "";
                chkNhoMK.Checked = false;
            }
        }

        private void SaveSettings()
        {
            if (chkNhoMK.Checked)
            {
                Properties.Settings.Default.User = txtTenTK.Text;
                Properties.Settings.Default.Pass = txtMatKhau.Text;
                Properties.Settings.Default.RememberMe = "true";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.User = txtTenTK.Text;
                Properties.Settings.Default.Pass = "";
                Properties.Settings.Default.RememberMe = "false";
                Properties.Settings.Default.Save();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtTenTK.Text))
            {
                MessageBox.Show("Không được bỏ trống tên  tài khoảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtTenTK.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtMatKhau.Focus();
                return;
            }
            string tenDN = txtTenTK.Text.ToString().Trim();
            string matKhau = txtMatKhau.Text.ToString().Trim();            
            TAIKHOANG tk = bllTaiKhoang.dangNhap(tenDN, matKhau);
            if (tk == null)
            {
                MessageBox.Show("Tài khoảng hoặc mật khẩu không chính xác!/n/nVui lòng nhập đúng thông tin tài khoảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtTenTK.Focus();
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;

                NVDangNhap.nv = int.Parse(tk.MANV.ToString());
                new GUI_Main_1().Show();
            }
            SaveSettings();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Visible = false;                            
        }

        private void GUI_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void chkNhoMK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                pictureBox1.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                pictureBox1.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
                
        }

       

        


    }
}
