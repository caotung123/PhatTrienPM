using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QLThietBi;
using DTO_QLThietBi;
using System.IO;

namespace QLThietBi.Presentation
{
    public partial class GUI_NhapHang : Form
    {
        BLL_View_DonNhap blldviewdonnhap = new BLL_View_DonNhap();
        BLL_NhaCungCap bllcungcap = new BLL_NhaCungCap();
        BLL_NhanVien bllnhanvien = new BLL_NhanVien();
        BLL_ThietBi bllthietbi = new BLL_ThietBi();
        BLL_View_CTNhap bllviewctdonnhap = new BLL_View_CTNhap();
        BLL_DonNhap blldonnhap = new BLL_DonNhap();
        BLL_CTDonNhap bllctdonnhap = new BLL_CTDonNhap();

        public GUI_NhapHang()
        {
            InitializeComponent();
        }

        private void GUI_NhapHang_Load(object sender, EventArgs e)
        {
            dateNgayLap.Value = DateTime.Now;
            loadDonNhap();
            loadCB();
            loadCTDonNhap();
            clear();
            setButtom(false);
        }
        
        void clear()
        {
            cboThietBi.SelectedItem = null;            
            cboTenNV.Text = "";
            cboNhaCungCap.Text = "";
            txtGia.Text = "";
            txtTongTien.Text = "";
            txtTThanhTien.Text = "";
            txtSLTB.Text = "0";
            dateNgayLap.Text = "1/1/2000";
        }
        
        public void loadCTDonNhap()
        {
            if (!string.IsNullOrEmpty(txtMaDN.Text))
            {
                int manhap = int.Parse(txtMaDN.Text);
                dtCTDonNhap.DataSource = bllviewctdonnhap.loadCTDonNhapMa(manhap);
                dtCTDonNhap.Columns[0].Visible = false;
                dtCTDonNhap.Columns[1].Visible = false;
                dtCTDonNhap.Columns[5].DefaultCellStyle.Format = "#,#";
                dtCTDonNhap.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtCTDonNhap.Columns[6].DefaultCellStyle.Format = "#,#" ;
                dtCTDonNhap.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        public void loadCB()
        {
            cboNhaCungCap.DataSource = bllcungcap.loadNhaCungCap();
            cboNhaCungCap.DisplayMember = "TENNCC";
            cboNhaCungCap.ValueMember = "MANCC";
            
            cboTenNV.DataSource = bllnhanvien.loadNhanVien();
            cboTenNV.DisplayMember = "TENNV";
            cboTenNV.ValueMember = "MANV";

            
            cboThietBi.DataSource = bllthietbi.loadThietBi();
            cboThietBi.DisplayMember = "TENTB";
            cboThietBi.ValueMember = "MATB";            
        }
        //Chinh lai thanh tien
        void loadDonNhap()
        {
            dtDonNhap.DataSource = blldviewdonnhap.loadViewDonNhap();
            dtDonNhap.Columns[4].DefaultCellStyle.Format = "#,#";
            dtDonNhap.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        
        private void btnThemDH_Click(object sender, EventArgs e)
        {
            if(cboTenNV.SelectedItem.ToString() != "")
            {
                int maNV = int.Parse(cboTenNV.SelectedValue.ToString());
                int maNCC = int.Parse(cboNhaCungCap.SelectedValue.ToString());
                NHANVIEN nv = bllnhanvien.timNhanVienTheoMa(maNV);
                NHACC ncc = bllcungcap.timNhaCungCapTheoMa(maNCC);

                if (ncc == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng vui lòng thêm khác hàng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GUI_NhaCungCap frm = new GUI_NhaCungCap();
                    frm.ShowDialog();
                }

                if(nv == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng vui lòng thêm khác hàng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GUI_KhachHang frm = new GUI_KhachHang();
                    frm.ShowDialog();
                }
                else
                {
                    DONNHAP donNhap = new DONNHAP();
                    donNhap.MANV = maNV;
                    donNhap.MANCC = maNCC;
                    donNhap.NGAYLAP = dateNgayLap.Value;
                    donNhap.TONGTIEN = 0;

                    int kq = blldonnhap.themDonNhap(donNhap);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành công", "Thông báo");
                        loadDonNhap();
                        loadCTDonNhap();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo");
                    }    
                }
            }
        }

        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDN.Text))
                return;
            int madn = int.Parse(txtMaDN.Text);
            DONNHAP dn = blldonnhap.timDonNhapTheoMa(madn);
            if (dn == null)
            {
                MessageBox.Show("Không tìm thấy cơ sở có mã:" + madn, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                int kq = blldonnhap.xoaDonNhap(dn);
                if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDonNhap();
                }
            }
        }

        private void btnSuaDH_Click(object sender, EventArgs e)
        {
            if (cboTenNV.SelectedItem.ToString() != "")
            {
                int maNV = int.Parse(cboTenNV.SelectedValue.ToString());
                int maNCC = int.Parse(cboNhaCungCap.SelectedValue.ToString());
                NHANVIEN nv = bllnhanvien.timNhanVienTheoMa(maNV);
                NHACC ncc = bllcungcap.timNhaCungCapTheoMa(maNCC);

                if (ncc == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng vui lòng thêm khác hàng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GUI_NhaCungCap frm = new GUI_NhaCungCap();
                    frm.ShowDialog();
                }

                if (nv == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng vui lòng thêm khác hàng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GUI_KhachHang frm = new GUI_KhachHang();
                    frm.ShowDialog();
                }
                else
                {
                    DONNHAP donNhap = new DONNHAP();
                    donNhap.MANV = maNV;
                    donNhap.MANCC = maNCC;
                    donNhap.NGAYLAP = dateNgayLap.Value;
                    donNhap.TONGTIEN = 0;

                    int kq = blldonnhap.suaDonNhap(donNhap);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành công", "Thông báo");
                        loadDonNhap();
                        loadCTDonNhap();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo");
                    }
                }
            }
        }

        int maDN;
        private void dtDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtDonNhap.SelectedRows.Count > 0 )
            {
                txtMaDN.Text = dtDonNhap.CurrentRow.Cells[0].Value.ToString();
                maDN = int.Parse(txtMaDN.Text);
                cboTenNV.Text = dtDonNhap.CurrentRow.Cells[1].Value.ToString();
                cboNhaCungCap.Text = dtDonNhap.CurrentRow.Cells[2].Value.ToString();                
                dateNgayLap.Text = dtDonNhap.CurrentRow.Cells[3].Value.ToString();

                int thanhTien = int.Parse( dtDonNhap.CurrentRow.Cells[4].Value.ToString());
                txtTThanhTien.Text = thanhTien.ToString("#,#");

                btnThem.Enabled = true;
            }     
            else
                btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(txtSoLuong.Value.ToString());
            int maDN = int.Parse(txtMaDN.Text);
            int maTB = int.Parse(cboThietBi.SelectedValue.ToString());

            CTDONHAP ctDonNhap = new CTDONHAP();
            ctDonNhap.MADN = maDN;
            ctDonNhap.MATB = maTB;
            ctDonNhap.SOLUONG = sl;
            ctDonNhap.GIANHAP = int.Parse(txtGia.Text);

            ctDonNhap.THANHTIEN = ctDonNhap.SOLUONG * ctDonNhap.GIANHAP;

            //Kiem tra xem CTDonNhap đã có TB đó chưa
            CTDONHAP ktra = bllctdonnhap.timCTDonNhapTheoMaDNMaTB(maDN, maTB);
            int kq = 0;
            if (ktra != null)
            {
                CTDONHAP ctdn = bllctdonnhap.timCTDonNhapTheoMaDNMaTB(maDN, maTB);
                int valueSL = sl - ctdn.SOLUONG.Value;

                kq = bllctdonnhap.suaCTDonNhap(ctDonNhap);
                suaSoLuongThietBi(maTB, valueSL);          
            }                
            else
            {
                kq = bllctdonnhap.themCTDonNhap(ctDonNhap);
                suaSoLuongThietBi(maTB, - ctDonNhap.SOLUONG.Value);         // Tang so luong tb ton kho
            }
                
            if (kq == 1)
            {
                MessageBox.Show("Thành công", "Thông báo");
                //loadTongTien();
                loadDonNhap();                
                loadCTDonNhap();                
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo");
            }
        }
        void loadTongTien()
        {
            int maDN = int.Parse(txtMaDN.Text);
            txtTongTien.Text = blldonnhap.tinhTongThanhTien(maDN).ToString() ;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maTB = int.Parse( cboThietBi.SelectedValue.ToString());                       
            int maDN = int.Parse(txtMaDN.Text);

            CTDONHAP ctDonNhap = new CTDONHAP();
            ctDonNhap.MADN = maDN;
            ctDonNhap.MATB = maTB;
            ctDonNhap.SOLUONG = int.Parse(txtSoLuong.Value.ToString());

            int giaNhap = int.Parse(txtGia.Text);
            ctDonNhap.GIANHAP = giaNhap;

            ctDonNhap.THANHTIEN = int.Parse((ctDonNhap.SOLUONG * giaNhap).ToString());

            //Kiem tra xem CTDonNhap đã có TB đó chưa
            CTDONHAP ktra = bllctdonnhap.timCTDonNhapTheoMaDNMaTB(maDN, maTB);
            if (ktra == null)
            {
                MessageBox.Show("Không tìm thấy chi tiết đơn nhập", "Thông báo");
                return;
            }
            int kq = bllctdonnhap.suaCTDonNhap(ctDonNhap);

            if (kq == 1)
            {
                MessageBox.Show("Thành công", "Thông báo");
                loadDonNhap();
                loadCTDonNhap();
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo");
            }
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
                int maTB = int.Parse(cboThietBi.SelectedValue.ToString());
                int maDN = int.Parse(txtMaDN.Text);
                CTDONHAP ctDonNhap = bllctdonnhap.timCTDonNhapTheoMaDNMaTB(maDN, maTB);
                if (ctDonNhap == null)
                {
                    MessageBox.Show("Không tìm thấy chi tiết đơn nhập", "Thông báo");
                    return;
                }
                int kq = bllctdonnhap.xoaCTDonNhap(ctDonNhap);

                if (kq == 1)
                {
                    MessageBox.Show("Thành công", "Thông báo");
                    loadTongTien();
                    loadDonNhap();
                    loadCTDonNhap();
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
            


        }

        private void dtCTDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtCTDonNhap.SelectedRows.Count < 1)
                return;
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            cboThietBi.Text = dtCTDonNhap.CurrentRow.Cells[2].Value.ToString();
            //txtGia.Text = dtCTDonNhap.CurrentRow.Cells[5].Value.ToString();
            txtSoLuong.Text = dtCTDonNhap.CurrentRow.Cells[4].Value.ToString();

            pictureBox3.Image = Image.FromFile(projectPath + "\\Resources\\" +
                dtCTDonNhap.CurrentRow.Cells[3].Value.ToString());
            txtMaTB.Text = dtCTDonNhap.CurrentRow.Cells[1].Value.ToString();
            txtTenTB.Text = dtCTDonNhap.CurrentRow.Cells[2].Value.ToString();
            txtSLTB.Text = dtCTDonNhap.CurrentRow.Cells[4].Value.ToString();
            //txtGia.Text = dtCTDonNhap.CurrentRow.Cells[5].Value.ToString();

            setButtom(true);
            
        }

        private void cboMaDonNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCTDonNhap();

        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            dtDonNhap.DataSource = blldviewdonnhap.loadViewDonNhap().OrderByDescending(x=>x.NGAYLAP).ToList();
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            dtDonNhap.DataSource = blldviewdonnhap.loadViewDonNhap().OrderBy(x => x.NGAYLAP).ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //var date = (DateTime)sender.Value;
            dtDonNhap.DataSource = blldviewdonnhap.loadViewDonNhap().Where(x => 
                x.NGAYLAP.HasValue && x.NGAYLAP.Value.Date == dateTimePicker1.Value.Date).ToList();
        }       

        private void txtMaDN_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaDN.Text))            
                loadCTDonNhap();                            
            else
                setButtom(false);
        }

        void setButtom(bool ktra)
        {
            btnThem.Enabled = ktra;
            btnXoa.Enabled = ktra;
            btnSua.Enabled = ktra;
            btnLuu.Enabled = ktra;
            btnIN.Enabled = ktra;
        }        

        private void cboThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {            
           
        }

        private void btnThem_EnabledChanged(object sender, EventArgs e)
        {
            if(btnThemDH.Enabled == true)
            {
                cboThietBi.Enabled = true;
                txtTThanhTien.Enabled = true;
            }
            else
            {
                cboThietBi.Enabled = false;
                txtTThanhTien.Enabled = false;
            }
            
        }

        private void dtDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool suaSoLuongThietBi(int pMaTB, int sl)
        {
            THIETBI tb = bllthietbi.timThietBiTheoMa(pMaTB);
            tb.SOLUONG -= sl;
            bllthietbi.suaThietBi(tb);

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DONNHAP dn = blldonnhap.timDonNhapTheoMa(maDN);

            if (dn == null)
                return;

            int kq = blldonnhap.tinhTongThanhTien(maDN);
            if( kq != 0)
            {
                MessageBox.Show("Thành công!", "Thông báo");
                loadDonNhap();
                txtTThanhTien.Text = kq.ToString("#,#");
                
            }
            else
            {
                MessageBox.Show("Thất bại!","Thông báo");               
            }
        }

        private void cboThietBi_TextChanged(object sender, EventArgs e)
        {

            int maTB = -1;
            try
            {
                maTB = int.Parse(cboThietBi.SelectedValue.ToString());   
            }
            catch { }
            if (cboThietBi.SelectedIndex >= 0 && maTB != -1)
            {
                THIETBI tb = bllthietbi.timThietBiTheoMa(maTB);

                int gia = int.Parse(tb.GIA.ToString());
                txtGia.Text = gia.ToString();

                int sl = int.Parse(txtSoLuong.Value.ToString());
                txtTongTien.Text = (sl * gia).ToString();
            }                        
        }
        
        

    }
}
