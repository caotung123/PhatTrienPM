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
    public partial class GUI_KhachHang : Form
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        BLL_KhachHang bllKhachHang = new BLL_KhachHang();

        public GUI_KhachHang()
        {            
            InitializeComponent();
        }

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            loadKhachHang();
        }
        void loadKhachHang()
        {
            dtgKhachHang.DataSource = bllKhachHang.loadKhachHang();
            chinhSuaDtgKhachHang();
        }
        void chinhSuaDtgKhachHang()
        {
            dtgKhachHang.Columns[0].Width = 60;
            dtgKhachHang.Columns[1].Width = 200;
            dtgKhachHang.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgKhachHang.Columns[2].Width = 120;
            dtgKhachHang.Columns[3].Width = 100;
            dtgKhachHang.Columns[4].Width = 120;
            dtgKhachHang.Columns[5].Width = 300;
        }

        string layGioiTinh()
        {
            if (rdNam.Checked)
                return "Nam";
            if (rdNu.Checked)
                return "Nữ";
            return null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            kh.TENKH = txtTen.Text;
            kh.NGAYSINH = dtpNgaySinh.Value;
            kh.GIOITINH = layGioiTinh();
            kh.SDT = txtSDT.Text;
            kh.DIACHI = this.txtDiaChi.Text;

            int kq = bllKhachHang.themKhachHang(kh);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadKhachHang();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
                return;
            int makh = int.Parse(txtMa.Text);
            KHACHHANG kh = bllKhachHang.timKhachHangTheoMa(makh);
            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy cơ sở có mã:" + makh, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                int kq = bllKhachHang.xoaKhachHang(kh);
                if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadKhachHang();
                    clear();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
                return;

            int makh = int.Parse(txtMa.Text);

            KHACHHANG kh = bllKhachHang.timKhachHangTheoMa(makh);
            kh.TENKH = txtTen.Text;
            kh.NGAYSINH = dtpNgaySinh.Value;
            kh.GIOITINH = layGioiTinh();
            kh.SDT = txtSDT.Text;
            kh.DIACHI = this.txtDiaChi.Text;
            int kq = bllKhachHang.suaKhachHang(kh);
            if (kq == 1)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadKhachHang();
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void dtgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dtgKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dtgKhachHang.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = dtgKhachHang.CurrentRow.Cells[2].Value.ToString();
            string gioiTinh = dtgKhachHang.CurrentRow.Cells[3].Value.ToString();
            if (gioiTinh == "Nam")
                rdNam.Checked = true;
            else            
                rdNu.Checked = true;
            txtSDT.Text = dtgKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dtgKhachHang.CurrentRow.Cells[5].Value.ToString();
        }
        void clear()
        {
            txtMa.Clear();
            txtTen.Clear();
            rdNam.Checked = false;
            rdNu.Checked = false;
            dtpNgaySinh.Value = DateTimePicker.MinimumDateTime;
            txtSDT.Clear();
            txtDiaChi.Clear();
        }
    }
}
