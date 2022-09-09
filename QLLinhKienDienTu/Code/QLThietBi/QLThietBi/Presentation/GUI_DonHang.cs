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
    public partial class GUI_DonHang : Form
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();

        BLL_LoaiThietBi bllLoai = new BLL_LoaiThietBi();
        BLL_ThietBi bllThietBi = new BLL_ThietBi();
        BLL_KhachHang bllKhachHang = new BLL_KhachHang();
        BLL_NhanVien bllNhanVien = new BLL_NhanVien();
        BLL_DonHang bllDonHang = new BLL_DonHang();
        BLL_CTDonHang bllCTDonHang = new BLL_CTDonHang();

        public GUI_DonHang()
        {
            InitializeComponent();
        }

        private void GUI_DonHang_Load(object sender, EventArgs e)
        {
            loadCbbNhanVien();
            loadCbbKhachHang();
            loadCbbThietBi();
            loadCbbHinhThuc();
            loadCbbTrangThai();
            loadCbbGia();
        }
        void loadDgvDonHang()
        {            
            dgvDonHang.DataSource = bllDonHang.loadDonHang();
            chinhDgvDonHang();
        }
        void loadDgvDonHangTheoGia(int giaDuoi, int giaTren)
        {
            dgvDonHang.DataSource = bllDonHang.loadDonHangTheoGia(giaDuoi, giaTren);
            chinhDgvDonHang();
        }
        void loadDgvDonHangTheoNgay(DateTime ngayLap)
        {
            dgvDonHang.DataSource = bllDonHang.loadDonHangTheoNgay(ngayLap);
            chinhDgvDonHang();
        }
        void chinhDgvDonHang()
        {
            dgvDonHang.Columns[0].Visible = false;
            dgvDonHang.Columns[1].Width = 60;
            dgvDonHang.Columns[2].Width = 60;
            dgvDonHang.Columns[3].Width = 100;
            dgvDonHang.Columns[4].Width = 100;
            dgvDonHang.Columns[4].DefaultCellStyle.Format = "#,#";
            dgvDonHang.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDonHang.Columns[5].Width = 150;
            dgvDonHang.Columns[6].Width = 150;
            dgvDonHang.Columns[7].Visible = false;
            dgvDonHang.Columns[8].Visible = false;
        }
        void loadDgvCTDonHang(int maDH)
        {
            dgvCTDonHang.DataSource = bllCTDonHang.loadCTDonHangTheoMa(maDH);           
            chinhDgvCTDonHang();
        }
        void chinhDgvCTDonHang()
        {
            dgvCTDonHang.Columns[0].Visible = false;
            dgvCTDonHang.Columns[1].Width = 90;
            dgvCTDonHang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTDonHang.Columns[2].Width = 100;
            dgvCTDonHang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTDonHang.Columns[3].Width = 200;
            dgvCTDonHang.Columns[3].DefaultCellStyle.Format = "#,#";
            dgvCTDonHang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCTDonHang.Columns[4].Width = 200;
            dgvCTDonHang.Columns[4].DefaultCellStyle.Format = "#,#";
            dgvCTDonHang.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCTDonHang.Columns[5].Visible = false;
            dgvCTDonHang.Columns[6].Visible = false;
        }

        void loadCbbNhanVien()
        {
            cbbNhanVien.DataSource = bllNhanVien.loadNhanVien();
            cbbNhanVien.DisplayMember = "TENV";
            cbbNhanVien.ValueMember = "MANV";
        }
        void loadCbbKhachHang()
        {
            cbbKhachHang.DataSource = bllKhachHang.loadKhachHang();
            cbbKhachHang.DisplayMember = "TENKH";
            cbbKhachHang.ValueMember = "MAKH";
        }
        void loadCbbThietBi()
        {
            cbbSanPham.DataSource = bllThietBi.loadThietBi();
            cbbSanPham.DisplayMember = "TENTB";
            cbbSanPham.ValueMember = "MATB";
        }
        void loadCbbHinhThuc()
        {
            cbbHinhThuc.Items.Add("Trả góp");
            cbbHinhThuc.Items.Add("Thanh toán");
        }
        void loadCbbTrangThai()
        {
            cbbTinhTrang.Items.Add("Đã thanh toán");
            cbbTinhTrang.Items.Add("Chưa thanh toán");
        }
        void loadCbbGia()
        {
            cbbGia.Items.Add("< 200,000");
            cbbGia.Items.Add("< 500,000");
            cbbGia.Items.Add("< 1,000,000");
            cbbGia.Items.Add("< 2,000,000");
            cbbGia.Items.Add("< 5,000,000");
            cbbGia.Items.Add("< 10,00,000");
            cbbGia.Items.Add("< 20,00,000");
            cbbGia.Items.Add("> 20,00,000");
        }

        int maDH = -1;
        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maDH = int.Parse(dgvDonHang.CurrentRow.Cells[0].Value.ToString());
            txtMa.Text = maDH.ToString();

            cbbKhachHang.SelectedValue = int.Parse( dgvDonHang.CurrentRow.Cells[1].Value.ToString());
            cbbNhanVien.SelectedValue = int.Parse( dgvDonHang.CurrentRow.Cells[2].Value.ToString());
            dtpNgayLap.Text = dgvDonHang.CurrentRow.Cells[3].Value.ToString();
            txtThanhTien.Text = dgvDonHang.CurrentRow.Cells[4].Value.ToString();
            cbbHinhThuc.Text = dgvDonHang.CurrentRow.Cells[5].Value.ToString();
            cbbTinhTrang.Text = dgvDonHang.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvCTDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbSanPham.SelectedValue = int.Parse( dgvCTDonHang.CurrentRow.Cells[1].Value.ToString());           
            txtSL.Value = int.Parse(dgvCTDonHang.CurrentRow.Cells[2].Value.ToString());
            //int gia = int.Parse(dgvCTDonHang.CurrentRow.Cells[3].Value.ToString()).toString("#,#)";   //kieu money ko dùng dượdc
            txtGiaBan.Text = dgvCTDonHang.CurrentRow.Cells[3].Value.ToString();

        }
        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            DONHANG dh = bllDonHang.timDonHangTheoMa(maDH);

            if (dh == null)
                return;

            dgvCTDonHang.DataSource = bllCTDonHang.loadCTDonHangTheoMa(maDH);
            chinhDgvCTDonHang();

        }

        private void btnThem_Click(object sender, EventArgs e)          /// Chưa xong
        {
            //int maKH = -1;
            int maNV = NVDangNhap.nv;
            int sl = int.Parse(txtSL.Value.ToString());

            //Nếu sl tồn kho không đủ thì không kết thúc
            int maTB = int.Parse(cbbSanPham.SelectedValue.ToString());

            THIETBI tb = bllThietBi.timThietBiTheoMa(maTB);
            if (tb.SOLUONG < txtSL.Value)
            {
                MessageBox.Show("Thất bại \n\nSố lượng tồn kho không đủ", "Thông báo");
                return;
            }       
            
            ///////
            //nêu ct DH đã có sản phẩm này rồi thì tăng số lượng lên

            CTDONHANG ct = bllCTDonHang.timCTDonHangTheoMaSP(maDH, maTB);
            if (ct != null)
            {
                ct.SOLUONG += int.Parse(txtSL.Value.ToString());

                int kq = bllCTDonHang.suaCTDonHang(ct);
                if (kq == 1)
                {
                    MessageBox.Show("Thành công!", "Thông báo");
                    loadDgvCTDonHang(maDH);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông báo");
                }
            }
            else
            {
                ct = new CTDONHANG();
                ct.MADH = maDH;
                ct.MATB = maTB;

                //THIETBI tb = bllThietBi.timThietBiTheoMa(ct.MATB);

                ct.GIABAN = tb.GIA;
                ct.SOLUONG = int.Parse(txtSL.Value.ToString());
                ct.THANHTIEN = ct.GIABAN * ct.SOLUONG;

                int kq = bllCTDonHang.themCTDonHang(ct);
                if (kq == 1)
                {
                    MessageBox.Show("Thành công!", "Thông báo");
                    loadDgvDonHang();
                    loadDgvCTDonHang(maDH);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông báo");
                    maDH = -1;
                    loadDgvCTDonHang(maDH);
                    loadThanhTien();
                }
            }                      
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(cbbSanPham.SelectedValue.ToString());
            CTDONHANG ct = bllCTDonHang.timCTDonHangTheoMaSP(maDH, maSP);

            if (ct == null)
                return;

            int kq = bllCTDonHang.xoaCTDonHang(ct);
            if (kq == 1)
            {
                MessageBox.Show("Thành công!", "Thông báo");
                loadDgvCTDonHang(maDH);
                loadThanhTien();
                maDH = -1;
            }
            else
            {
                MessageBox.Show("Thất bại!", "Thông báo");
                loadDgvCTDonHang(maDH);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(cbbSanPham.SelectedValue.ToString());
            CTDONHANG ct = bllCTDonHang.timCTDonHangTheoMaSP(maDH, maSP);
            ct.SOLUONG = int.Parse(txtSL.Value.ToString());

            int kq = bllCTDonHang.suaCTDonHang(ct);
            if (kq == 1)
            {
                MessageBox.Show("Thành công!", "Thông báo");
                loadDgvCTDonHang(maDH);
                loadThanhTien();
                maDH = -1;
            }
            else
            {
                MessageBox.Show("Thất bại!", "Thông báo");
                loadDgvCTDonHang(maDH);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void cbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maSP = -1;
            try
            {
                maSP = int.Parse(cbbSanPham.SelectedValue.ToString());

                THIETBI tb = bllThietBi.timThietBiTheoMa(maSP);
                txtGiaBan.Text = tb.GIA.ToString();
            }
            catch (Exception ex)
            { }
        }

        void loadThanhTien()
        {
            //txtThanhTien.Text = bllCTDonHang.tinhTongCTDonHang(maDH).ToString("#,#");
            DONHANG dh = bllDonHang.timDonHangTheoMa(maDH);
            txtThanhTien.Text = dh.TONGTIEN.ToString();
        }

        private void cbbGia_SelectedIndexChanged(object sender, EventArgs e)
        {       
            int giaT = int.MaxValue;
            int giaD = 0;
            int index = cbbGia.SelectedIndex;
            if (index == 0)
            {
                giaD = 0;
                giaT = 200000;
            }
            else if (index == 1)
            {
                giaD = 200000;
                giaT = 500000;
            }
            else if (index == 2)
            {
                giaD = 500000;
                giaT = 1000000;
            }
            else if (index == 3)
            {
                giaD = 1000000;
                giaT = 2000000;
            }
            else if (index == 4)
            {
                giaD = 2000000;
                giaT = 5000000;
            }
            else if (index == 5)
            {
                giaD = 5000000;
                giaT = 10000000;
            }
            else if (index == 6)
            {
                giaD = 10000000;
                giaT = 20000000;
            }
            else if (index == 7)
            {
                giaD = 20000000;
                giaT = int.MaxValue;
            }

            dgvDonHang.DataSource = bllDonHang.loadDonHangTheoGia(giaD, giaT);
            chinhDgvDonHang();
        }

        private void chkALL_CheckedChanged(object sender, EventArgs e)
        {
            if( chkALL.Checked)
                loadDgvDonHang();
            else
            {
                dgvDonHang.DataSource = bllDonHang.loadDonHangTheoGia(0, 0);
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            loadDgvDonHangTheoNgay(dtpNgay.Value);
        }


    }
}
