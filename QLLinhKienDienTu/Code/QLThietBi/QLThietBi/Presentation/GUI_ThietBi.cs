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
    public partial class GUI_ThietBi : Form
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        BLL_ThietBi bllThietBi = new BLL_ThietBi();
        BLL_LoaiThietBi bllLoaiTB = new BLL_LoaiThietBi();
        BLL_NhaCungCap bllNhaCC = new BLL_NhaCungCap();
       
        public GUI_ThietBi()
        {
            InitializeComponent();
        }

        private void GUI_ThietBi_Load(object sender, EventArgs e)
        {
            loadDgvThietBi();
            loadCbbLoai();
            loadCbbNCC();
            txtSL.Value = 0;
        }
        void loadDgvThietBi()
        {
            dtgThietBi.DataSource = bllThietBi.loadThietBi();
            chinhSuaDtgThietBi();
        }
        void chinhSuaDtgThietBi()
        {
            dtgThietBi.Columns[0].Width = 60;
            dtgThietBi.Columns[1].Width = 200;
            dtgThietBi.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgThietBi.Columns[2].Width = 120;
            dtgThietBi.Columns[3].Width = 100;
            dtgThietBi.Columns[3].DefaultCellStyle.Format = "#,#";
            dtgThietBi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgThietBi.Columns[4].Width = 120;
            dtgThietBi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgThietBi.Columns[5].Width = 700;
            dtgThietBi.Columns[6].Visible = false;
            dtgThietBi.Columns[7].Visible = false;
            dtgThietBi.Columns[8].Visible = false;
            dtgThietBi.Columns[9].Visible = false;
        }
        void loadCbbLoai()
        {
            cbbLoai.DataSource = bllLoaiTB.loadLoaiThietBi();
            cbbLoai.DisplayMember = "TENLOAI";
            cbbLoai.ValueMember = "MALOAI";
        }
        void loadCbbNCC()
        {
            cbbNCC.DataSource = bllNhaCC.loadNhaCungCap();
            cbbNCC.DisplayMember = "TENNCC";
            cbbNCC.ValueMember = "MANCC";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            THIETBI tb = new THIETBI();

            tb.TENTB = txtTen.Text;
            if (lblImagePath.Text == "C:\\anhsp.jpg")
                tb.HINHANH = "";
            else
                tb.HINHANH = lblImagePath.Text;

            string[] gia1 = txtGia.Text.ToString().Split(',');
            string gia = "";
            for (int i = 0; i < gia1.Length; i++)
            {
                gia += gia1[i];
            }
            tb.GIA = int.Parse(gia);
            tb.MOTA = txtMoTa.Text;
            txtSL.Value = int.Parse(txtSL.Value.ToString());
            tb.MALOAI = int.Parse(cbbLoai.SelectedValue.ToString());
            tb.MANCC = int.Parse(cbbNCC.SelectedValue.ToString());

            int kq = bllThietBi.themThietBi(tb);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDgvThietBi();
            }
            else
            {
                MessageBox.Show("Thất bại!", "Thông báo");
                loadDgvThietBi();
                clear();
            }

            //string[] s = lblImagePath.Text.ToString().Split('\\');
            //string path = s[s.Length - 1];
            // tb.HINHANH = s[s.Length - 1];
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
                return;
            int maTB = int.Parse(txtMa.Text);
            THIETBI tb = bllThietBi.timThietBiTheoMa(maTB);
            if (tb == null)
            {
                MessageBox.Show("Không tìm thấy cơ sở có mã:" + maTB, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                int kq = bllThietBi.xoaThietBi(tb);
                if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDgvThietBi();
                    clear();
                }
            }
        }
        void clear()
        {
            txtTen.Clear();
            lblImagePath.Text = "";
            txtGia.Clear();
            txtMoTa.Clear();
            txtSL.Value = 0;
            cbbLoai.Text = "";
            cbbNCC.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
                return;

            int maTB = int.Parse(txtMa.Text);

            THIETBI tb = bllThietBi.timThietBiTheoMa(maTB);
            tb.TENTB = txtTen.Text;
            if (lblImagePath.Text == "C:\\anhsp.jpg")
                tb.HINHANH = "";
            else
                tb.HINHANH = lblImagePath.Text;

            //Lay gia
            string[] gia1 = txtGia.Text.ToString().Split(',');
            string gia = "";
            for(int i = 0; i < gia1.Length; i ++)
            {
                gia += gia1[i];
            }
            tb.GIA = int.Parse(gia);

            tb.SOLUONG = int.Parse(txtSL.Value.ToString());
            tb.MALOAI = int.Parse(cbbLoai.SelectedValue.ToString());
            tb.MANCC = int.Parse(cbbNCC.SelectedValue.ToString());

            int kq = bllThietBi.suaThietBi(tb);
            if (kq == 1)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDgvThietBi();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dtgThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dtgThietBi.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dtgThietBi.CurrentRow.Cells[1].Value.ToString();        
            
            lblImagePath.Text = dtgThietBi.CurrentRow.Cells[2].Value.ToString();
            //pcbHinhAnh.BackgroundImage = Image.FromFile(@"../../Resources/" + lblImagePath);

            int gia = int.Parse(dtgThietBi.CurrentRow.Cells[3].Value.ToString());
            txtGia.Text = gia.ToString("#,#");

            string sl = "";
            int sol = 0;
            try
            {
                sl = dtgThietBi.CurrentRow.Cells[4].Value.ToString();
                sol = int.Parse(sl);
            }
            catch (Exception ex) { }                  
            
            txtSL.Value = sol;


            txtMoTa.Text = dtgThietBi.CurrentRow.Cells[5].Value.ToString();
           
            cbbLoai.SelectedValue = int.Parse(dtgThietBi.CurrentRow.Cells[6].Value.ToString());
            cbbNCC.SelectedValue = int.Parse(dtgThietBi.CurrentRow.Cells[7].Value.ToString());
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "Image File (*.jpg;*.jpeg;*.bmp;*.gif;*.png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
                dlg.Title = "Chọn Hình";

                DialogResult dlgRes = dlg.ShowDialog();
                if (dlgRes != DialogResult.Cancel)
                {
                    //Gán hình vào Picture box
                    pcbHinhAnh.ImageLocation = dlg.FileName;
                    pcbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Gán đường dẫn ảnh vào lbimgpath
                    lblImagePath.Text = dlg.FileName;
                }
                string[] s = lblImagePath.Text.ToString().Split('\\');
                lblImagePath.Text = s[s.Length - 1];                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllThietBi.loadSanPhamTheoTimKiem(txt_timkiem.Text);
        }

        private void btnXoaHinh_Click(object sender, EventArgs e)
        {
            lblImagePath.Text = "";
        }


    }
}
