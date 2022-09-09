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
    public partial class GUI_BanHang : Form
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        BLL_NhanVien bllNhanVien = new BLL_NhanVien();
        BLL_LoaiThietBi bllLoai = new BLL_LoaiThietBi();
        BLL_ThietBi bllThietBi = new BLL_ThietBi();
        BLL_KhachHang bllKhachHang = new BLL_KhachHang();
        BLL_VIEW_GioHang bllGioHang = new BLL_VIEW_GioHang();
        BLL_DonHang bllDonHang = new BLL_DonHang();
        BLL_CTDonHang bllCTDonHang = new BLL_CTDonHang();

        public GUI_BanHang()
        {
            InitializeComponent();
        }

        private void GUI_DonHang_Load(object sender, EventArgs e)
        {           
            loadCbbLoai();
            loadGrbThietBi();
            loadCbbKhachHang();
            loadCbbGia();
            
        }

        void loadCbbLoai()
        {
            cbbLoai.DataSource = bllLoai.loadLoaiThietBi();
            cbbLoai.DisplayMember = "TENLOAI";
            cbbLoai.ValueMember = "MALOAI";
        }
        void loadGrbThietBi()
        {
            dtgSanPham.DataSource = bllThietBi.loadThietBi();
            dtgSanPham.Columns[0].Visible = false;
            dtgSanPham.Columns[5].Visible = false;
            dtgSanPham.Columns[6].Visible = false;
            dtgSanPham.Columns[7].Visible = false;
            dtgSanPham.Columns[8].Visible = false;
            dtgSanPham.Columns[9].Visible = false;
            dtgSanPham.Columns[1].Width = 270;
            dtgSanPham.Columns[3].DefaultCellStyle.Format = "#,#";
            dtgSanPham.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        void loadCbbKhachHang()
        {
            cbbKH.DataSource = bllKhachHang.loadKhachHang();
            cbbKH.DisplayMember = "TENKH";
            cbbKH.ValueMember = "MAKH";
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


        void loadDgvDSChon(int pMaDH)
        {
            dgvDSChon.DataSource = bllGioHang.loadVIEWGioHangMaDH(pMaDH);            
            dgvDSChon.Columns[0].Visible = false;
            dgvDSChon.Columns[1].Visible = false;
            dgvDSChon.Columns[2].Width = 170;
            dgvDSChon.Columns[6].Visible = false;
            dgvDSChon.Columns[4].Width = 150;
            dgvDSChon.Columns[4].DefaultCellStyle.Format = "#,#";
            dgvDSChon.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDSChon.Columns[5].Width = 150;
            dgvDSChon.Columns[5].DefaultCellStyle.Format = "#,#";
            dgvDSChon.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maL = -1;
            try
            {
                maL = int.Parse(cbbLoai.SelectedValue.ToString());
                dtgSanPham.DataSource = bllThietBi.loadThietBiTheoMaLoai(maL);
            }
            catch { }
        }

        private void dtgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSL.Value = 1;
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            pcbAnhTB.Image = Image.FromFile(projectPath + "\\Resources\\" +
                dtgSanPham.CurrentRow.Cells[2].Value.ToString());

            //Nếu sl tồn kho không đủ thì không kết thúc
            int maTB = int.Parse(dtgSanPham.CurrentRow.Cells[0].Value.ToString());

            THIETBI tb = bllThietBi.timThietBiTheoMa(maTB);
        }

        private void dgvDsChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {         
            txtSL.Value = int.Parse(dgvDSChon.CurrentRow.Cells[3].Value.ToString());
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            pcbAnhTB.Image = Image.FromFile(projectPath + "\\Resources\\" +
                dgvDSChon.CurrentRow.Cells[6].Value.ToString());
        }

        int maDH = -1;
        private void btnDat_Click(object sender, EventArgs e)
        {
            int maKH = -1;
            try
            {
                maKH = int.Parse(cbbKH.SelectedValue.ToString());
            }
            catch { }
            
            int maNV = NVDangNhap.nv;
            int sl = int.Parse(txtSL.Value.ToString());

            if (dtgSanPham.SelectedRows.Count < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo");
            }
            else
            {
                if (sl < 1)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo");
                    txtSL.Focus();
                    return;
                }
                KHACHHANG kh = bllKhachHang.timKhachHangTheoMa(maKH);
                if (kh == null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Không tìm thấy khách hàng: " + cbbKH.SelectedItem.ToString()
                            + "\n\n Bạn có muốn thêm khách hàng mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        GUI_KhachHang frm = new GUI_KhachHang();
                        frm.ShowDialog();
                        cbbKH.Focus();
                    }
                    return;
                }

                //Nếu sl tồn kho không đủ thì không kết thúc
                int maTB = int.Parse(dtgSanPham.CurrentRow.Cells[0].Value.ToString());

                THIETBI tb = bllThietBi.timThietBiTheoMa(maTB);
                if (tb.SOLUONG < txtSL.Value)
                {
                    MessageBox.Show("Thất bại \n\nSố lượng tồn kho không đủ", "Thông báo");
                    return;
                }       


                //Nếu đã có đơn hàng thì thêm vào chhi tiêt, ngược lại thêm đơn hàng
                DONHANG dh = bllDonHang.timDonHangTheoMa(maDH);
                int kq = 1;
                if (dh == null)
                {
                    dh = new DONHANG();
                    dh.MAKH = maKH;
                    dh.MANV = maNV;
                    dh.NGAYLAP = DateTime.Now;
                    dh.HINHTHUCTT = "THANH TOÁN";
                    if (chkTraGop.Checked == true)
                        dh.HINHTHUCTT = "TRẢ GÓP";
                    dh.TONGTIEN = 0;
                    dh.TINHTRANG = "CHƯA THANH TOÁN";
                     kq = bllDonHang.themDonHang(dh);
                }

                if (kq == 0)
                {
                    MessageBox.Show("Thất bại!", "Thông báo");
                    return;
                }
                else
                {
                    //nêu ct DH đã có sản phẩm này rồi thì tăng số lượng lên

                    maDH = dh.MADH;                    
                    CTDONHANG ct = bllCTDonHang.timCTDonHangTheoMaSP(maDH, maTB);              
                    if(ct != null)                                                             
                    {                                               
                        ct.SOLUONG += sl;        // sua trong CTDH

                        if (!suaSoLuongThietBi(ct.MATB, sl))      //sua trong Thiet Bi
                            MessageBox.Show("Thất bại!", "Thông báo"); 
                        kq = bllCTDonHang.suaCTDonHang(ct);
                        if (kq == 1)
                        {
                            MessageBox.Show("Thành công!", "Thông báo");
                            loadDgvDSChon(maDH);
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

                        kq = bllCTDonHang.themCTDonHang(ct);
                        suaSoLuongThietBi(ct.MATB, sl);
                        
                        if (kq == 1)
                        {
                            MessageBox.Show("Thành công!", "Thông báo");
                            loadGrbThietBi();
                            loadDgvDSChon(maDH);
                        }
                        else
                        {
                            MessageBox.Show("Thất bại!", "Thông báo");
                            bllDonHang.xoaDonHang(dh);
                            maDH = -1;
                            loadDgvDSChon(maDH);
                            loadThanhTien();
                        }
                    }
                   
                    

                }
            }

        }

        void loadThanhTien()
        {
            if (maDH == -1)
                txtThanhTien.Text = "0";
            else
            {
                DONHANG dh = bllDonHang.timDonHangTheoMa(maDH);
                decimal d = decimal.Parse( dh.TONGTIEN.Value.ToString());
                txtThanhTien.Text = d.ToString("#,#");
                
                //txtThanhTien.Text =  int.Parse(dh.TONGTIEN.ToString()).ToString("#,#");
            }
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DONHANG dh = bllDonHang.timDonHangTheoMa(maDH);

            if (dh == null)
                return;

            //dh.TINHTRANG = "HOÀN THÀNH";
            //db_LinhKien.SubmitChanges();

            int kq = bllDonHang.thanhToanDonHang(dh);
            if (kq == 1)
            {
                MessageBox.Show("Thành công!", "Thông báo");
                loadDgvDSChon(maDH);                
                loadThanhTien();
                maDH = -1;
            }
            else
            {
                MessageBox.Show("Thất bại!", "Thông báo");
                loadDgvDSChon(maDH);
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            DONHANG dh = bllDonHang.timDonHangTheoMa(maDH);

            if (dh == null)
                return;
            List<CTDONHANG> dsCT = bllCTDonHang.loadCTDonHangTheoMa(maDH);
            foreach (CTDONHANG ct in dsCT)
            {
                bllCTDonHang.xoaCTDonHang(ct);
            }
            int kq = bllDonHang.xoaDonHang(dh);
            if (kq == 1)
            {
                MessageBox.Show("Thành công!", "Thông báo");
                loadDgvDSChon(maDH);
                loadGrbThietBi();
                maDH = -1;
                loadThanhTien();
                
            }
            else
            {
                MessageBox.Show("Thất bại!", "Thông báo");
                loadDgvDSChon(maDH);                
            }
        }

        private void btnHuyCTDonHang_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(dgvDSChon.CurrentRow.Cells[1].Value.ToString());
            CTDONHANG ct = bllCTDonHang.timCTDonHangTheoMaSP(maDH, maSP);

            if (ct == null)
                return;

            int kq = bllCTDonHang.xoaCTDonHang(ct);
            if (kq == 1)
            {
                MessageBox.Show("Thành công!", "Thông báo");
                loadDgvDSChon(maDH);
                loadThanhTien();                
            }
            else
            {
                MessageBox.Show("Thất bại!", "Thông báo");
                loadDgvDSChon(maDH);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtgSanPham.DataSource = bllThietBi.loadThietBiTheoTen(txtTimKiem.Text);
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
            dtgSanPham.DataSource = bllThietBi.loadThietBiTheoGia(giaD, giaT);

        }     

        private void chkALLSP_Click(object sender, EventArgs e)
        {
            if (chkALLSP.Checked == true)
                loadGrbThietBi();
        }

        private void dgvDSChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maTB = int.Parse(dgvDSChon.CurrentRow.Cells[1].Value.ToString());
            int sl = int.Parse(txtSL.Value.ToString());
            int valueSL = 0;


            CTDONHANG ct = bllCTDonHang.timCTDonHangTheoMaSP(maDH, maTB);
            valueSL = sl - ct.SOLUONG.Value;

            ct.SOLUONG = sl;
            bllCTDonHang.suaCTDonHang(ct);
            suaSoLuongThietBi(maTB, valueSL);
            loadDgvDSChon(maDH);
            loadGrbThietBi();
                    
        }

        bool suaSoLuongThietBi(int pMaTB, int sl)
        {               
            THIETBI tb = bllThietBi.timThietBiTheoMa(pMaTB);
            tb.SOLUONG -= sl;
            bllThietBi.suaThietBi(tb);            

            return true;
        }
    }
}
