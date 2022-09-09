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
using System.IO;

namespace QLThietBi.Presentation
{
    public partial class GUI_TaiKhoang : Form
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        BLL_NhanVien bllNhanVien = new BLL_NhanVien();
        BLL_TaiKhoang bllTaiKhoang = new BLL_TaiKhoang();
        BLL_DMMangHinh bllDMMangHinh = new BLL_DMMangHinh();
        string tenTK = "";
        string matKhau = "";
        int maNV = -1;
        public GUI_TaiKhoang()
        {
            InitializeComponent();
        }

        private void GUI_TaiKhoang_Load(object sender, EventArgs e)
        {
            loadCbbNhanVien();
        }
        void loadCbbNhanVien()
        {
            cbbNhanVien.DataSource = bllNhanVien.loadNhanVien();
            cbbNhanVien.DisplayMember = "TENNV";
            cbbNhanVien.ValueMember = "MANV";
            cbbNhanVien.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tenTK = txtTenTK.Text;
            matKhau = txtMatKhau.Text;
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
            if (string.IsNullOrEmpty(txtXNMK.Text))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtXNMK.Focus();
                return;
            }
            if(txtXNMK.Text != txtMatKhau.Text)    
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtXNMK.Focus();
                return;
            }
            maNV = int.Parse(cbbNhanVien.SelectedValue.ToString());
            TAIKHOANG tk1 = bllTaiKhoang.timTaiKhoangTheoMaNV(maNV);
            if(tk1 != null)
            {
                MessageBox.Show("Nhân viên đã tồn tại tài khoảng!\n\nVui lòng chọn nhân viên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cbbNhanVien.Focus();
                return;
            }

            TAIKHOANG tk = new TAIKHOANG();
            tk.MANV = maNV;
            tk.TENTK = tenTK.ToString().Trim();
            tk.MATKHAU = matKhau.ToString().Trim();
            int kq = bllTaiKhoang.themTaiKhoang(tk);
            if (kq == 0)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtTenTK.Focus();
            }
            else
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DMMANGHINH dm = new DMMANGHINH();                
                dm.MANV = tk.MANV;
                dm.CHON = false;
                dm.TENMH = "Màng Hình Bán Hàng";
                bllDMMangHinh.themDMMangHinh(dm);
                dm = new DMMANGHINH();
                dm.MANV = tk.MANV;
                dm.CHON = false;
                dm.TENMH = "Màng Hình Nhân Viên";                
                bllDMMangHinh.themDMMangHinh(dm);
                dm = new DMMANGHINH();
                dm.MANV = tk.MANV;
                dm.CHON = false;
                dm.TENMH = "Màng Hình Khách Hàng"; 
                bllDMMangHinh.themDMMangHinh(dm);
                dm = new DMMANGHINH();
                dm.MANV = tk.MANV;
                dm.CHON = false;
                dm.TENMH = "Màng Hình Thiết Bị"; 
                bllDMMangHinh.themDMMangHinh(dm);
                dm = new DMMANGHINH();
                dm.MANV = tk.MANV;
                dm.CHON = false;
                dm.TENMH = "Màng Hình Loại Thiết Bị"; 
                bllDMMangHinh.themDMMangHinh(dm);
                dm = new DMMANGHINH();
                dm.MANV = tk.MANV;
                dm.CHON = false;
                dm.TENMH = "Màng Hình Cơ Sở"; 
                bllDMMangHinh.themDMMangHinh(dm);
                dm = new DMMANGHINH();
                dm.MANV = tk.MANV;
                dm.CHON = false;
                dm.TENMH = "Màng Hình Đơn Nhập"; 
                bllDMMangHinh.themDMMangHinh(dm);
                dm = new DMMANGHINH();
                dm.MANV = tk.MANV;
                dm.CHON = false;
                dm.TENMH = "Màng Hình Phân Quyền"; 
                bllDMMangHinh.themDMMangHinh(dm);
                dm = new DMMANGHINH();
                dm.MANV = tk.MANV;
                dm.CHON = false;
                dm.TENMH = "Màng Hình Báo Cáo"; 
                bllDMMangHinh.themDMMangHinh(dm);               
                
            }
        }

        private void pcbHienMK_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar == '\0')
            {
                txtMatKhau.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
                
            else
            {
                txtMatKhau.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
                
        }
    }
}
