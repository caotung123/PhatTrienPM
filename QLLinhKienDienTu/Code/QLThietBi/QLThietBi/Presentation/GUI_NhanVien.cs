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
    public partial class GUI_NhanVien : Form
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        BLL_NhanVien bllNhanVien = new BLL_NhanVien();
        BLL_TaiKhoang bllTaiKhoang = new BLL_TaiKhoang();
        BLL_DMMangHinh bllDMMangHinh = new BLL_DMMangHinh();

        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            loadNhanVien();
        }
        void loadNhanVien()
        {
            dtgNhanVien.DataSource = bllNhanVien.loadNhanVien();
            chinhSuaDtgNV();
        }
        void chinhSuaDtgNV()
        {
            dtgNhanVien.Columns[0].Width = 60;
            dtgNhanVien.Columns[1].Width = 200;
            dtgNhanVien.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgNhanVien.Columns[2].Width = 120;
            dtgNhanVien.Columns[3].Width = 100;
            dtgNhanVien.Columns[4].Width = 120;
            dtgNhanVien.Columns[5].Width = 300;
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
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = -1;
            nv.TENNV = txtTen.Text;
            nv.NGAYSINH = dtpNgaySinh.Value;
            nv.GIOITINH = layGioiTinh();
            nv.SDT = txtSDT.Text;
            nv.DIACHI = this.txtDiaChi.Text;

            int kq = bllNhanVien.themNhanVien(nv);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadNhanVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
                return;
            int maNV = int.Parse(txtMa.Text);
            NHANVIEN nv = bllNhanVien.timNhanVienTheoMa(maNV);
            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy cơ sở có mã:" + maNV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                List<DMMANGHINH> dsDM = bllDMMangHinh.loadDMMangHinhTheoMaNV(maNV);
                foreach (DMMANGHINH mh in dsDM)
                {
                    bllDMMangHinh.xoaDMMangHinh(mh);
                }
                TAIKHOANG tk = bllTaiKhoang.timTaiKhoangTheoMaNV(nv.MANV);
                bllTaiKhoang.xoaTaiKhoang(tk);
                int kq = bllNhanVien.xoaNhanVien(nv);
                if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadNhanVien();
                    clear();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
                return;

            int maNV = int.Parse(txtMa.Text);

            NHANVIEN nv = bllNhanVien.timNhanVienTheoMa(maNV);
            nv.TENNV = txtTen.Text;
            nv.NGAYSINH = dtpNgaySinh.Value;
            nv.GIOITINH = layGioiTinh();
            nv.SDT = txtSDT.Text;
            nv.DIACHI = this.txtDiaChi.Text;
            int kq = bllNhanVien.suaNhanVien(nv);
            if (kq == 1)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadNhanVien();
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dtgNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dtgNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = dtgNhanVien.CurrentRow.Cells[2].Value.ToString();
            string gioiTinh = dtgNhanVien.CurrentRow.Cells[3].Value.ToString();
            if (gioiTinh == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            txtSDT.Text = dtgNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dtgNhanVien.CurrentRow.Cells[5].Value.ToString();

        }

    }
}
